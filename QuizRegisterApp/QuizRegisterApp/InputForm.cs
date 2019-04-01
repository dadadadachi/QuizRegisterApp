using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static QuizSaveApp.Program;
using XmlManager.Mapping;

namespace QuizSaveApp
{
    public partial class InputForm : Form
    {
        private string genre_name_ = null;
        private string format_name_ = null;

        public InputForm()
        {
            InitializeComponent();
            SetTemplate();
        }

        private void SetTemplate()
        {
            // ジャンルのセレクトボックス生成
            cmbBox_Genre.SuspendLayout();
            foreach (var genre in quizSetting.Template.Genres)
            {
                cmbBox_Genre.Items.Add(genre.Name);
            }
            cmbBox_Genre.ResumeLayout();
        }

        private void cmbBox_Genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            genre_name_ = cmbBox_Genre.SelectedItem.ToString();
            var genre = quizSetting.Template.Genres.Find(ge => ge.Name == genre_name_);
            
            // 出題形式のセレクトボックス生成
            cmbBox_Format.SuspendLayout();
            cmbBox_Format.Items.Clear();
            foreach (var format in genre.Formats)
            {
                cmbBox_Format.Items.Add(format.Name);
            }
            cmbBox_Format.ResumeLayout();
        }

        private void cmbBox_Format_SelectedIndexChanged(object sender, EventArgs e)
        {
            format_name_ = cmbBox_Format.SelectedItem.ToString();

            // 入力項目を生成
            flow_inputColumns.SuspendLayout();
            var generator = new InputFormGenerator();
            generator.GenerateInputForm(flow_inputColumns, genre_name_, format_name_);
            flow_inputColumns.ResumeLayout();
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {

        }

    }
}
