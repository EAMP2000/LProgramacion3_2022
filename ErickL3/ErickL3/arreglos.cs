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
    public partial class arreglos : Form
    {
        public arreglos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            string[] Nombres = { "Luis", "Marcela", "Mauricio", "Juan", "Victoria" };
            int[] Edades = { 22, 25, 28, 21, 23 };


            for (int i = 0; i < Dias.Length; i++)
            {
                DiasListBox.Items.Add(Dias[i]); //almacena el arreglo en el listbox
            }

            foreach (string item in Nombres)
            {
                NombresListBox.Items.Add(item);
            }

            foreach (var item in Edades) //var reconoce el tipo de dato del arreglo.
            {
                EdadesListBox.Items.Add(item);
            }
        }
    }
}
