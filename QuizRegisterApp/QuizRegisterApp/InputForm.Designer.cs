namespace QuizSaveApp
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flow_inputColumns = new System.Windows.Forms.FlowLayoutPanel();
            this.Line = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.cmbBox_Templates = new System.Windows.Forms.ComboBox();
            this.currentNum = new System.Windows.Forms.Label();
            this.slash = new System.Windows.Forms.Label();
            this.TotalNum = new System.Windows.Forms.Label();
            this.panel_picture = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_picture.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(1020, 12);
            this.listView1.MaximumSize = new System.Drawing.Size(300, 9999);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(200, 687);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(399, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(347, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // flow_inputColumns
            // 
            this.flow_inputColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flow_inputColumns.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flow_inputColumns.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_inputColumns.Location = new System.Drawing.Point(764, 12);
            this.flow_inputColumns.Name = "flow_inputColumns";
            this.flow_inputColumns.Size = new System.Drawing.Size(250, 633);
            this.flow_inputColumns.TabIndex = 3;
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line.Dock = System.Windows.Forms.DockStyle.Top;
            this.Line.Location = new System.Drawing.Point(5, 5);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(992, 2);
            this.Line.TabIndex = 4;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.AutoSize = true;
            this.btn_Insert.Location = new System.Drawing.Point(922, 13);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 25);
            this.btn_Insert.TabIndex = 5;
            this.btn_Insert.Text = "登録";
            this.btn_Insert.UseVisualStyleBackColor = true;
            // 
            // cmbBox_Templates
            // 
            this.cmbBox_Templates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBox_Templates.BackColor = System.Drawing.SystemColors.Window;
            this.cmbBox_Templates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Templates.FormattingEnabled = true;
            this.cmbBox_Templates.Location = new System.Drawing.Point(703, 15);
            this.cmbBox_Templates.MaxDropDownItems = 99;
            this.cmbBox_Templates.Name = "cmbBox_Templates";
            this.cmbBox_Templates.Size = new System.Drawing.Size(213, 23);
            this.cmbBox_Templates.TabIndex = 6;
            this.cmbBox_Templates.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // currentNum
            // 
            this.currentNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentNum.Location = new System.Drawing.Point(8, 18);
            this.currentNum.Name = "currentNum";
            this.currentNum.Size = new System.Drawing.Size(15, 23);
            this.currentNum.TabIndex = 7;
            // 
            // slash
            // 
            this.slash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.slash.Location = new System.Drawing.Point(29, 18);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(8, 23);
            this.slash.TabIndex = 8;
            this.slash.Text = "/";
            this.slash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalNum
            // 
            this.TotalNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalNum.Location = new System.Drawing.Point(43, 18);
            this.TotalNum.Name = "TotalNum";
            this.TotalNum.Size = new System.Drawing.Size(15, 23);
            this.TotalNum.TabIndex = 9;
            // 
            // panel_picture
            // 
            this.panel_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_picture.AutoSize = true;
            this.panel_picture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_picture.Controls.Add(this.label6);
            this.panel_picture.Controls.Add(this.label5);
            this.panel_picture.Controls.Add(this.label4);
            this.panel_picture.Controls.Add(this.label3);
            this.panel_picture.Controls.Add(this.pictureBox1);
            this.panel_picture.Controls.Add(this.pictureBox2);
            this.panel_picture.Location = new System.Drawing.Point(12, 12);
            this.panel_picture.Name = "panel_picture";
            this.panel_picture.Size = new System.Drawing.Size(746, 633);
            this.panel_picture.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(396, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "撮影日時：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(464, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "2019/01/01 00:00:00";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(0, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "撮影日時：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(92, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "2019/01/01 00:00:00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.currentNum);
            this.panel1.Controls.Add(this.cmbBox_Templates);
            this.panel1.Controls.Add(this.TotalNum);
            this.panel1.Controls.Add(this.btn_Insert);
            this.panel1.Controls.Add(this.slash);
            this.panel1.Controls.Add(this.Line);
            this.panel1.Location = new System.Drawing.Point(12, 651);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1002, 48);
            this.panel1.TabIndex = 11;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 711);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flow_inputColumns);
            this.Controls.Add(this.panel_picture);
            this.Name = "InputForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_picture.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flow_inputColumns;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label currentNum;
        private System.Windows.Forms.Label slash;
        private System.Windows.Forms.Label TotalNum;
        private System.Windows.Forms.Panel panel_picture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbBox_Templates;
    }
}