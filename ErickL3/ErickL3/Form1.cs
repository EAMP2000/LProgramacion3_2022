using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErickL3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarMsj(); //llamada al mensaje en el boton
        }

        private void MostrarMsj()
        {
            MessageBox.Show("Te Amo <3"); //sirve para mostrar un mensaje en una mini ventana
        }

        private void SumarButton_Click(object sender, EventArgs e) //boton que hace la suma
        {
            int numero1 = Convert.ToInt32(Numero1textBox.Text); //convierte el texto a intero
            int numero2 = Convert.ToInt32(Numero2textBox.Text);

            ResultadotextBox.Text = sumar(numero1, numero2).ToString(); //muestra el resultado en el textbox del resultado

        }

        private int sumar(int numero1, int numero2) //metodo para solo ser llamado en el textbox
        {
            int resultado = numero1 + numero2;

            return resultado;
        }
    }
}
