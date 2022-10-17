namespace WordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (FontFamily fontFamily in FontFamily.Families)
                cBox_Font.Items.Add(fontFamily.Name);

            foreach (FontFamily fontFamily in FontFamily.Families)
                cBox_Font.Items.Add(fontFamily.Name);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font,FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
        }

        private void btn_LeftAlign_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btn_CenterAlign_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btn_RightAlign_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void cBox_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cBox_Color_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.ShowHelp = true;
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void cBox_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            float size = float.Parse(richTextBox1.Text);
            richTextBox1.Font = new Font(FontFamily.GenericSerif, size);
        }

        private void lbl_SaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new(saveFileDialog1.FileName);
                sw.Write(richTextBox1.Text);
            }
        }

        private void lbl_LoadFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using StreamReader sr = new(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
            }
        }
    }
}