namespace day_5_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Добавляем обработчик события нажатия на пункт меню "Выход"
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(richTextBox1.Text);
            string result = "";
            for (int i = 25; i >= 26 - n; i--)
            {
                result += (char)(i + 65);
            }
            richTextBox1.Text = result;
        }
    }
}