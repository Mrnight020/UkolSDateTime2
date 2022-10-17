using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime17._11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int PocetDni(DateTime datum,int x)
        {
            DateTime dneska = DateTime.Now;
            datum = datum.AddYears(x);
            TimeSpan rozdil = dneska - datum;
            return rozdil.Days;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Pocet dni co mi je 18 " + PocetDni(dateTimePicker1.Value, 18));
            MessageBox.Show("Pocet dni od narozeni: " + PocetDni(dateTimePicker1.Value, 0));
            MessageBox.Show("pocet dni do duchodu " + PocetDni(dateTimePicker1.Value, 65));
        }
    }
}
