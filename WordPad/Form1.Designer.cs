namespace WordPad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_SaveFile = new System.Windows.Forms.Button();
            this.lbl_LoadFile = new System.Windows.Forms.Button();
            this.cBox_Color = new System.Windows.Forms.ComboBox();
            this.btn_RightAlign = new System.Windows.Forms.Button();
            this.btn_CenterAlign = new System.Windows.Forms.Button();
            this.btn_LeftAlign = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cBox_Size = new System.Windows.Forms.ComboBox();
            this.cBox_Font = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(959, 419);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_SaveFile);
            this.panel1.Controls.Add(this.lbl_LoadFile);
            this.panel1.Controls.Add(this.cBox_Color);
            this.panel1.Controls.Add(this.btn_RightAlign);
            this.panel1.Controls.Add(this.btn_CenterAlign);
            this.panel1.Controls.Add(this.btn_LeftAlign);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cBox_Size);
            this.panel1.Controls.Add(this.cBox_Font);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 65);
            this.panel1.TabIndex = 1;
            // 
            // lbl_SaveFile
            // 
            this.lbl_SaveFile.Location = new System.Drawing.Point(823, 32);
            this.lbl_SaveFile.Name = "lbl_SaveFile";
            this.lbl_SaveFile.Size = new System.Drawing.Size(131, 23);
            this.lbl_SaveFile.TabIndex = 15;
            this.lbl_SaveFile.Text = "Save File";
            this.lbl_SaveFile.UseVisualStyleBackColor = true;
            this.lbl_SaveFile.Click += new System.EventHandler(this.lbl_SaveFile_Click);
            // 
            // lbl_LoadFile
            // 
            this.lbl_LoadFile.Location = new System.Drawing.Point(686, 32);
            this.lbl_LoadFile.Name = "lbl_LoadFile";
            this.lbl_LoadFile.Size = new System.Drawing.Size(131, 23);
            this.lbl_LoadFile.TabIndex = 14;
            this.lbl_LoadFile.Text = "Load File";
            this.lbl_LoadFile.UseVisualStyleBackColor = true;
            this.lbl_LoadFile.Click += new System.EventHandler(this.lbl_LoadFile_Click);
            // 
            // cBox_Color
            // 
            this.cBox_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Color.FormattingEnabled = true;
            this.cBox_Color.Location = new System.Drawing.Point(528, 33);
            this.cBox_Color.Name = "cBox_Color";
            this.cBox_Color.Size = new System.Drawing.Size(99, 23);
            this.cBox_Color.TabIndex = 13;
            this.cBox_Color.SelectedIndexChanged += new System.EventHandler(this.cBox_Color_SelectedIndexChanged);
            this.cBox_Color.Click += new System.EventHandler(this.cBox_Color_Click);
            // 
            // btn_RightAlign
            // 
            this.btn_RightAlign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_RightAlign.Location = new System.Drawing.Point(470, 33);
            this.btn_RightAlign.Name = "btn_RightAlign";
            this.btn_RightAlign.Size = new System.Drawing.Size(25, 25);
            this.btn_RightAlign.TabIndex = 11;
            this.btn_RightAlign.Text = "R";
            this.btn_RightAlign.UseVisualStyleBackColor = true;
            this.btn_RightAlign.Click += new System.EventHandler(this.btn_RightAlign_Click);
            // 
            // btn_CenterAlign
            // 
            this.btn_CenterAlign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CenterAlign.Location = new System.Drawing.Point(439, 33);
            this.btn_CenterAlign.Name = "btn_CenterAlign";
            this.btn_CenterAlign.Size = new System.Drawing.Size(25, 25);
            this.btn_CenterAlign.TabIndex = 10;
            this.btn_CenterAlign.Text = "C";
            this.btn_CenterAlign.UseVisualStyleBackColor = true;
            this.btn_CenterAlign.Click += new System.EventHandler(this.btn_CenterAlign_Click);
            // 
            // btn_LeftAlign
            // 
            this.btn_LeftAlign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LeftAlign.Location = new System.Drawing.Point(408, 33);
            this.btn_LeftAlign.Name = "btn_LeftAlign";
            this.btn_LeftAlign.Size = new System.Drawing.Size(25, 25);
            this.btn_LeftAlign.TabIndex = 9;
            this.btn_LeftAlign.Text = "L";
            this.btn_LeftAlign.UseVisualStyleBackColor = true;
            this.btn_LeftAlign.Click += new System.EventHandler(this.btn_LeftAlign_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(340, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(309, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "U";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(278, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "B";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBox_Size
            // 
            this.cBox_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Size.FormattingEnabled = true;
            this.cBox_Size.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cBox_Size.Location = new System.Drawing.Point(149, 35);
            this.cBox_Size.Name = "cBox_Size";
            this.cBox_Size.Size = new System.Drawing.Size(99, 23);
            this.cBox_Size.TabIndex = 3;
            this.cBox_Size.SelectedIndexChanged += new System.EventHandler(this.cBox_Size_SelectedIndexChanged);
            // 
            // cBox_Font
            // 
            this.cBox_Font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Font.FormattingEnabled = true;
            this.cBox_Font.Location = new System.Drawing.Point(28, 33);
            this.cBox_Font.Name = "cBox_Font";
            this.cBox_Font.Size = new System.Drawing.Size(99, 23);
            this.cBox_Font.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private Panel panel1;
        private Button lbl_SaveFile;
        private Button lbl_LoadFile;
        private ComboBox cBox_Color;
        private Button btn_RightAlign;
        private Button btn_CenterAlign;
        private Button btn_LeftAlign;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox cBox_Size;
        private ComboBox cBox_Font;
        private ColorDialog colorDialog1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}