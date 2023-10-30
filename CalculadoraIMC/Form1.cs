using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            try
            {
                double pesot = double.Parse(txtPeso.Text);
                double alturat = double.Parse(txtAltura.Text);

                double result = pesot / (alturat * alturat);


                txtResultado.Text = Math.Round(result,2).ToString();

                if (result < 18.5)
                {
                    lblResposta.Text = "Abaixo do peso!";
                    lblResposta.ForeColor = Color.Red;
                } 
                else if (result < 24.9)
                {
                    lblResposta.Text = "Peso ideal (parabéns!)";
                    lblResposta.ForeColor = Color.BlueViolet;
                }
                else if (result < 29.9)
                {
                    lblResposta.Text = "Levemente acima do peso!";
                    lblResposta.ForeColor = Color.Yellow;
                }
                else if (result < 34.9)
                {
                    lblResposta.Text = "Obesidade grau I!";
                    lblResposta.ForeColor = Color.DarkRed;
                }
                else if (result < 39.9)
                {
                    lblResposta.Text = "Obesidade grau II (severa)";
                    lblResposta.ForeColor = Color.OrangeRed;
                }
                else if (result > 40)
                {
                    lblResposta.Text = "Obesidade III (mórbida)";
                    lblResposta.ForeColor = Color.IndianRed;
                }
            }
            catch
            {
                MessageBox.Show("Dados inválidos informados");
                txtResultado.Clear();
                txtPeso.Clear();
                txtAltura.Clear();
            }

        }
    }
}
