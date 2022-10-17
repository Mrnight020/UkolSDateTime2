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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime vybrano = dateTimePicker1.Value;
            string den = vybrano.DayOfWeek.ToString();
            switch (den)
            {
                case "Monday":
                    {
                        MessageBox.Show(den + "= Prvni Pracovni den");
                        break;
                    }
                case "Tuesday":
                    {
                        MessageBox.Show(den + "= Pracovni den");
                        break;
                    }
                case "Wednesday":
                    {
                        MessageBox.Show(den + "= Pracovni den");
                        break;
                    }
                case "Thursday":
                    {
                        MessageBox.Show(den + "= Pracovni den");
                        break;
                    }
                case "Friday":
                    {
                        MessageBox.Show(den + "= Pracovni den");
                        break;
                    }
                case "Saturday":
                    {
                        MessageBox.Show(den + "= víkend");
                        break;
                    }
                case "Sunday":
                    {
                        MessageBox.Show(den + "= víkend");
                        break;
                    }
            }

            MessageBox.Show("" + den);
        }
    }
}
