using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_EP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(NumeroTextBox.Text);


            if (numero % 2 == 0)
            {
                ResultadoTextBox.Text = Par(numero);
            }
            else if (numero > 1 && numero / numero == 1 && numero / 1 == numero)
            {
                ResultadoTextBox.Text = Primo(numero);
            }
            else if (numero % 2 != 0 && numero>=1)
            {
                ResultadoTextBox.Text = Impar(numero);
            }  
            
        }

        //Funciones
        private string Par(int numero)
        {
            string respuesta = "Es numero par";
            return respuesta;
        }

        private string Impar(int numero)
        {
            string respuesta = "Es numero impar";
            return respuesta;
           
        }

        private string Primo(int numero)
        {
            string respuesta = "Es numero primo y tambien impar";
            return respuesta;
            
        }
    }
}
