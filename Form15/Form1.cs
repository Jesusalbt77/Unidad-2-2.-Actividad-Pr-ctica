namespace Form15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Aqui va el codigo para subir y leer el archivo

                lblAbrir.Text = openFileDialog1.FileName;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) { }
            {
                // Aqui va el codigo para guardar

                lblAbrir.Text = saveFileDialog1.FileName;
            }
        }

        private void lblAbrir_Click(object sender, EventArgs e)
        {

        }

        private void lblGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
