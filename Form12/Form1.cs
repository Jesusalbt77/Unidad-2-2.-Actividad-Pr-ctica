namespace Form12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nc, nf;
            nc = Convert.ToInt32(textBox1.Text);
            nf = nc * 9 / 5 + 32;
            label2.Text = Convert.ToString(nf);
        }
    }
}
