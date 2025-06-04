namespace Form7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(textBox1.Text);

            textBox1.Clear();
        }
    }
}
