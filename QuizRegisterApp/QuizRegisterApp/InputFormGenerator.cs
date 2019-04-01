using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Serialization = System.Xml.Serialization;
using XmlManager.Mapping;

namespace QuizSaveApp
{
    public class InputFormGenerator
    {
        private readonly QuizSetting.Define define_ = null;
        private readonly QuizSetting.Template template_ = null;

        public InputFormGenerator()
        {
            define_ = Program.quizSetting.Define;
            template_ = Program.quizSetting.Template;
        }

        /// <summary>
        /// テンプレートから入力フォームを生成します
        /// </summary>
        /// <param name="basePanel">入力フォームの生成先パネル</param>
        /// <param name="genre_name">ジャンル名</param>
        /// <param name="format_name">出題形式名</param>
        public void GenerateInputForm(Panel basePanel, string genre_name, string format_name)
        {
            basePanel.Controls.Clear();
            var genre = template_.Genres.Find(ge => ge.Name == genre_name);
            var format = genre.Formats.Find(fo => fo.Name == format_name);
            
            foreach(var prop in format.GetType().GetProperties())
            {
                // Xmlファイルにおける属性のプロパティはスキップする
                if (prop.CustomAttributes.First().AttributeType.UnderlyingSystemType == typeof(Serialization::XmlAttributeAttribute))  { continue; }
                // 設定値を判定
                if (Convert.ToBoolean(prop.GetValue(format)) != true) { continue; }
                
                //プロパティ名から入力項目定義を取得
                var column = define_.Columns.Find(col => col.Key == prop.Name);

                //入力項目毎にパネルを生成
                var subPanel = new FlowLayoutPanel { Name = "flowlayoutpanel_" + column.Key };
                subPanel.FlowDirection = FlowDirection.TopDown;
                basePanel.Controls.Add(subPanel);
                SetParentWidth(subPanel);
                
                //項目名
                var label = new Label { Name = "label_" + column.Key };
                label.AutoSize = true;
                label.Text = column.Title;
                subPanel.Controls.Add(label);

                //各種入力インプット生成
                switch (column.InputType)
                {
                    case "textbox":
                        var textbox = new TextBox { Name = "textbox_" + column.Key };
                        subPanel.Controls.Add(textbox);
                        SetParentWidth(textbox);
                        break;

                    case "textarea":
                        var textarea = new RichTextBox { Name = "textarea_" + column.Key };
                        subPanel.Controls.Add(textarea);
                        SetParentWidth(textarea);
                        break;

                    case "charbox10":
                        var flow_charPanel = new FlowLayoutPanel { Name = "charbox10_" + column.Key };
                        subPanel.Controls.Add(flow_charPanel);
                        SetParentWidth(flow_charPanel);

                        for (var i = 1; i <= 10; i++)
                        {
                            var charbox = new TextBox { Name = "charbox_" + i};
                            flow_charPanel.Controls.Add(charbox);
                            charbox.Width = 25;
                            charbox.Margin = new Padding(5);
                            if (i % 5 == 0) { subPanel.SetFlowBreak(charbox, true); }
                        }

                        flow_charPanel.AutoSize = true;
                        break;

                    case "radio":
                        foreach (string opt_group in column.Options.Split(','))
                        {
                            var flow_radioGroup = new FlowLayoutPanel { Name = "flowlayoutpanel_opt_group" };
                            subPanel.Controls.Add(flow_radioGroup);
                            SetParentWidth(flow_radioGroup);

                            string[] options = opt_group.Split(';');
                            foreach (string opt in options)
                            {
                                var radio_button = new RadioButton { Name = "radiobtn_" + opt };
                                radio_button.Text = opt;
                                radio_button.AutoSize = true;
                                flow_radioGroup.Controls.Add(radio_button);
                            }
                            Control lastRadio = flow_radioGroup.Controls.Find("radiobtn_" + options.Last(), false).First();
                            subPanel.SetFlowBreak(lastRadio, true);
                            flow_radioGroup.AutoSize = true;
                        }
                        break;
                }
                subPanel.AutoSize = true;
            }
        }

        /// <summary>
        /// コントロールに対してその親要素のWidthを設定します
        /// </summary>
        /// <param name="control">コントロール</param>
        static void SetParentWidth(Control control)
        {
            control.Width = control.Parent.Width - control.Margin.Horizontal;
        }

    }
}
