namespace Form16
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;

        private double resultado;

        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // n�mero 8
            textBox1.Text = textBox1.Text + "8";
        }


        private void button9_Click(object sender, EventArgs e)
        {
            // n�mero 6
            textBox1.Text = textBox1.Text + "6";
        }


        private void button14_Click(object sender, EventArgs e)
        {
            // n�mero 0
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // n�mero 2
            textBox1.Text = textBox1.Text + "2";
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            // n�mero 1
            textBox1.Text = textBox1.Text + "1";
        }


        private void btn3_Click(object sender, EventArgs e)
        {
            // n�mero 3
            textBox1.Text = textBox1.Text + "3";
        }


        private void btn4_Click(object sender, EventArgs e)
        {
            // n�mero 4
            textBox1.Text = textBox1.Text + "4";
        }


        private void btn5_Click(object sender, EventArgs e)
        {
            // n�mero 5
            textBox1.Text = textBox1.Text + "5";
        }


        private void btn7_Click(object sender, EventArgs e)
        {
            // n�mero 7
            textBox1.Text = textBox1.Text + "7";
        }


        private void btn9_Click(object sender, EventArgs e)
        {
            // n�mero 9
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            // bot�n limpiar
            textBox1.Text = "";

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            // bot�n igual 
            valor2 = Convert.ToDouble(textBox1.Text);
            resultado = valor1 + valor2;

            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    break;

            }
            textBox1.Text = resultado.ToString();

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            // bot�n suma 
            operacion = 1;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            // bot�n resta
            operacion = 2;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnmultiplicaci�n_Click(object sender, EventArgs e)
        {
            // bot�n multiplicaci�n 
            operacion = 3;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";


        }

        private void btndivisi�n_Click(object sender, EventArgs e)
        {
            // bot�n divisi�n
            operacion = 4;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            // bot�n punto
            textBox1.Text = textBox1.Text + ".";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

