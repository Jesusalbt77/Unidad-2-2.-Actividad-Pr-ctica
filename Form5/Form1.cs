namespace Form5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
                { label1.Text = "Hombre";
                 }
            {
                if (radioButton2.Checked == true)

                { label1.Text = "Mujer"; }
            
            if (radioButton3.Checked== true)
                {
                    label1.Text = "Niño";

                }

               
            }
        }
    }
}
