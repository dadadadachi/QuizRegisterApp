using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static QuizSaveApp.Program;

namespace QuizSaveApp
{
    public class InputFormGenerator
    {
        #region Generatorメソッド
        /// <summary>
        /// テンプレートから入力フォームを生成します
        /// </summary>
        /// <param name="basePanel">入力フォームの生成先パネル</param>
        /// <param name="tmpl">テンプレート名</param>
        public void GenerateInputForm(Panel basePanel, string tmpl)
        {
            basePanel.Controls.Clear();
            XElement type = xmlTypes.Where(t => t.Attribute("name").Value == tmpl).First();

            foreach (var viewColumn in type.Elements())
            {
                //入力項目毎にパネルを生成
                var flow_subInputColumns = new FlowLayoutPanel();
                flow_subInputColumns.FlowDirection = FlowDirection.TopDown;
                basePanel.Controls.Add(flow_subInputColumns);
                SetParentWidth(flow_subInputColumns);

                //項目名
                var label = new Label();
                label.AutoSize = true;
                label.Text = viewColumn.Name.ToString();
                flow_subInputColumns.Controls.Add(label);

                //各種入力インプット
                XElement inputColumn = xmlColumns.Where(c => c.Attribute("name").Value == viewColumn.Name.ToString()).First();
                XElement input_type = inputColumn.Elements().Where(icd => icd.Name.ToString() == "InputType").First();
                switch (input_type.Value)
                {
                    case "textbox":
                        var textbox = new TextBox { Name = viewColumn.Name.ToString() };
                        flow_subInputColumns.Controls.Add(textbox);
                        SetParentWidth(textbox);
                        break;

                    case "charbox10":
                        var flow_charPanel = new FlowLayoutPanel();
                        flow_subInputColumns.Controls.Add(flow_charPanel);
                        SetParentWidth(flow_charPanel);

                        for (var i = 1; i <= 10; i++)
                        {
                            var charbox = new TextBox();
                            flow_charPanel.Controls.Add(charbox);
                            charbox.Width = 25;
                            charbox.Margin = new Padding(5);
                            if (i % 5 == 0) { flow_subInputColumns.SetFlowBreak(charbox, true); }
                        }

                        flow_charPanel.AutoSize = true;
                        break;

                    case "textarea":
                        var textarea = new RichTextBox { Name = viewColumn.Name.ToString() };
                        flow_subInputColumns.Controls.Add(textarea);
                        SetParentWidth(textarea);
                        break;

                    case "radio":
                        IEnumerable<XElement> Groups = inputColumn.Elements("Group");

                        foreach (XElement group in Groups)
                        {
                            List<string> values = new List<string>();
                            values = group.Elements("Value").Select(v => v.Value).ToList();

                            var flow_radioGroup = new FlowLayoutPanel { Name = "radio_group" };
                            flow_subInputColumns.Controls.Add(flow_radioGroup);
                            SetParentWidth(flow_radioGroup);

                            foreach (string value in values)
                            {
                                string[] radio_options = value.Split(',');
                                foreach (string opt in radio_options)
                                {
                                    var radio_button = new RadioButton { Name = "radio_" + opt };
                                    radio_button.Text = opt;
                                    radio_button.AutoSize = true;
                                    flow_radioGroup.Controls.Add(radio_button);
                                }
                                Control lastRadio = flow_radioGroup.Controls.Find("radio_" + radio_options.Last(), false).First();
                                flow_subInputColumns.SetFlowBreak(lastRadio, true);
                            }
                            flow_radioGroup.AutoSize = true;
                        }
                        break;

                    case "select":
                        string[] options = viewColumn.Value.Split(',');

                        var selectbox = new ComboBox { Name = viewColumn.Name.ToString() };
                        selectbox.DropDownStyle = ComboBoxStyle.DropDownList;
                        foreach (var opt in options)
                        {
                            selectbox.Items.Add(opt);
                        }
                        flow_subInputColumns.Controls.Add(selectbox);
                        SetParentWidth(selectbox);
                        break;
                }

                flow_subInputColumns.AutoSize = true;
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
        #endregion

    }
}
