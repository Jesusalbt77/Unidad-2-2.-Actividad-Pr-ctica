using System.Runtime.CompilerServices;

namespace Form13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProgressBar pBar = new ProgressBar();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void btndetener_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }
    }
}
