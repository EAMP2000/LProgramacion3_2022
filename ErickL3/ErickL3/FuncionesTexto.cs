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
    public partial class FuncionesTexto : Form
    {
        public FuncionesTexto()
        {
            InitializeComponent();
        }
        //Todo el prodecimiento se hara dentro dl evento de Boton.
        private void ProcesarButton_Click(object sender, EventArgs e)
        {
            string palabra = CadenaTextBox.Text; //se le asingna el valor de la variable a la caja de txt

            LongitudTextBox.Text= palabra.Length.ToString(); //longitud
            PrimerLetraTextBox.Text = palabra.Substring(0,1);//muestra los caracteres  que esten dentro del rango establecido. 
            UltimaLetraTextBox.Text = palabra.Substring(palabra.Length-1,1); //ultima letra.
            MayusculasTextBox.Text = palabra.ToUpper(); //ToUpper convierte todo a Mayusculas
            MinusculasTextBox.Text = palabra.ToLower(); //ToLowe  conviete todo a Minusculas
            SustituirTextBox.Text = palabra.Replace("a","x"); //Replace sustituye un caracter por otro,  en este caso sustituye las A por X

        }
    }
}
