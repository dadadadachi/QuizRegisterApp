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

namespace QuizSaveApp
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
            SetTemplatesName();
        }

        private void SetTemplatesName()
        {
            foreach (var qType in xmlTypes)
            {
                cmbBox_Templates.Items.Add(qType.Attribute("name").Value);
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedTmplName = cmbBox_Templates.SelectedItem.ToString();

            flow_inputColumns.SuspendLayout();
            var generator = new InputFormGenerator();
            generator.GenerateInputForm(flow_inputColumns, selectedTmplName);
            flow_inputColumns.ResumeLayout();
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
