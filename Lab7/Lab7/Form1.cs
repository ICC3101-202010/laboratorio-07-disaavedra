using Lab7.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Calculadora : Form
    {
        double primerNumero = 0;
        double segundoNumero = 0;
        string operador;
        double var;

        Suma objetoSumar = new Suma();
        Resta objetoRestar = new Resta();
        Multiplicacion objetoMultiplicar = new Multiplicacion();
        Division objetoDividir = new Division();

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        //Pantalla

        private void Pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        //Numeros

        private void cero_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void uno_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void dos_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void siete_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        //Operaciones

        private void suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            if(Pantalla.Text == "")
            {
                Pantalla.Text = "Syntax Error";
            }

            else if (Pantalla.Text == "Syntax Error" || Pantalla.Text == "Math Error")
            {
                Pantalla.Clear();
            }
            else
            {
                primerNumero = double.Parse(Pantalla.Text);
                Pantalla.Clear();
            }   
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            if (Pantalla.Text == "")
            {
                Pantalla.Text = "Syntax Error";
            }

            else if (Pantalla.Text == "Syntax Error" || Pantalla.Text == "Math Error")
            {
                Pantalla.Clear();
            }
            else
            {
                primerNumero = double.Parse(Pantalla.Text);
                Pantalla.Clear();
            }
            
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {

            operador = "*";
            if (Pantalla.Text == "")
            {
                Pantalla.Text = "Syntax Error";
            }

            else if (Pantalla.Text == "Syntax Error" || Pantalla.Text == "Math Error")
            {
                Pantalla.Clear();
            }
            else
            {
                primerNumero = double.Parse(Pantalla.Text);
                Pantalla.Clear();
            }
            
        }

        private void division_Click(object sender, EventArgs e)
        {
            operador = "/";
            if (Pantalla.Text == "")
            {
                Pantalla.Text = "Syntax Error";
            }

            else if (Pantalla.Text == "Syntax Error" || Pantalla.Text == "Math Error")
            {
                Pantalla.Clear();
            }
            else
            {
                primerNumero = double.Parse(Pantalla.Text);
                Pantalla.Clear();
            }
        }

        //Botones

        private void ac_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length == 1)
                Pantalla.Text = "";
            else
                 if (Pantalla.Text.Length >= 1) 
                {
                Pantalla.Text = Pantalla.Text.Substring(0, Pantalla.Text.Count() - 1);
                }
        }

        private void ans_Click(object sender, EventArgs e)
        {
            Pantalla.Text = var.ToString();
            primerNumero = var;
        }

        private void igual_Click(object sender, EventArgs e)
        {
            double suma, resta, multiplicacion, division;
                
            if(Pantalla.Text == "")
            {
                Pantalla.Clear();
            }
                
            else
            {
                segundoNumero = double.Parse(Pantalla.Text);

                switch (operador)
                {
                    case "+":
                        suma = objetoSumar.SumaCalculadora(primerNumero, segundoNumero);
                        Pantalla.Text = suma.ToString();
                        var = suma;
                        break;
                    case "-":
                        resta = objetoRestar.RestaCalculadora(primerNumero, segundoNumero);
                        Pantalla.Text = resta.ToString();
                        var = resta;
                        break;
                    case "*":
                        multiplicacion = objetoMultiplicar.MultCalculadora(primerNumero, segundoNumero);
                        Pantalla.Text = multiplicacion.ToString();
                        var = multiplicacion;
                        break;
                    case "/":
                        division = objetoDividir.DiviCalculadora(primerNumero, segundoNumero);
                        Pantalla.Text = division.ToString();
                        var = division;
                        if (segundoNumero == 0)
                        {
                            Pantalla.Text = "Math Error";
                        }
                        break;
                }
            }
             
        }

        //Puntos

        private void punto_Click(object sender, EventArgs e)
        {
            if (!Pantalla.Text.Contains(",")) 
            {
                if (Pantalla.Text.Length < 1) 
                {
                    Pantalla.Text += "0,";
                }
                else
                {
                    Pantalla.Text += ",";
                }

            }
        }
    }
}
