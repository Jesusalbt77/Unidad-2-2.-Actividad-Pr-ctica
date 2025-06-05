namespace Form11
{
    public partial class Form1 : Form
    {
        private object salida;
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime Fecha = dateTimePicker1.Value;
            salida = dateTimePicker1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }
    }
}
