namespace Calculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0;
        double Numero2 = 0;
        char Operador;

        public Form1()
        {
            InitializeComponent();
        }
        //el object sender se dispara cuando se da click a cualquier boton
        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);// convertirmos el objeto sender a un boton
            if (textResultado.Text == "0")
            {
                textResultado.Text = "";
            }
            textResultado.Text += boton.Text;//resultado = a la propiedad text del boton es decir al nunero
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            Numero1 = Convert.ToDouble(textResultado.Text);
            Operador = Convert.ToChar(boton.Tag);

            if (Operador == '²')
            {
                Numero1 = Math.Pow(Numero1, 2);
                textResultado.Text = Numero1.ToString();
            }
            else if (Operador == '√')
            {
                Numero1 = Math.Sqrt(Numero1);
                textResultado.Text = Numero1.ToString();
            }
            else
            {
                textResultado.Text = "0";
            }

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(textResultado.Text);

            if (Operador == '+')
            {
                textResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Text);
            }
            else if (Operador == '−')
            {
                textResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Text);
            }
            else if (Operador == 'X')
            {
                textResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Text);
            }
            else if (Operador == '/')
            {
                if (textResultado.Text != "0")
                {
                    textResultado.Text = (Numero1 / Numero2).ToString();
                    Numero1 = Convert.ToDouble(textResultado.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero!!");
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (textResultado.Text.Length > 1)
            {
                textResultado.Text = textResultado.Text.Substring(0, textResultado.Text.Length - 1);
            }
            else
            {
                textResultado.Text = "0";
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            textResultado.Text = "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textResultado.Text = "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!textResultado.Text.Contains("."))
            {
                textResultado.Text += ".";
            }
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(textResultado.Text);
            Numero1 *= -1;
            textResultado.Text = Numero1.ToString();
        }
    }
}
