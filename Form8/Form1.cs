namespace Form8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count;

            if (int.TryParse(label1.Text, out count))
            {
                count++;
                label1.Text = count.ToString();
            }
            else
            {
                label1.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

