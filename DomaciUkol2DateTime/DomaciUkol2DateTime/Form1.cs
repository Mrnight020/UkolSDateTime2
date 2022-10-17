using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomaciUkol2DateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        DateTime ted = new DateTime();
        DateTime ted2 = new DateTime();

        private void button1_Click(object sender, EventArgs e)
        {
            ted = DateTime.Now;

            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ted2 = DateTime.Now;
            TimeSpan kolikubehlo = ted2 - ted;
            MessageBox.Show("Uběhlo : " + kolikubehlo.Minutes + " minut " + kolikubehlo.Seconds + " sekund");
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            timer2.Start();
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
            timer2.Stop();
            timer1.Start();
        }
    }
}
