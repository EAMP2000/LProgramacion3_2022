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
    public partial class FuncionesFecha : Form
    {
        public FuncionesFecha()
        {
            InitializeComponent();
        }

        private void ProcesarButton_Click(object sender, EventArgs e)
        {
            DateTime Fecha = DateTimePicker.Value;

            DiaTextBox.Text = Fecha.Day.ToString();
            MesTextBox.Text = Fecha.Month.ToString();
            AnioTextBox.Text= Fecha.Year.ToString();
            DiaLetrasTextBox.Text = Fecha.ToString("dddd");
            MesLetrasTextBox.Text = Fecha.ToString("MMMM");
            SumarDiasTextBox.Text = Fecha.AddDays(10).ToShortDateString(); //la funcion adddays puede agregar o restar dias.

        }
    }
}
