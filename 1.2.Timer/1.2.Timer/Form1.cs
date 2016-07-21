using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2.Timer
{
    public partial class Form1 : Form
    {
        int Zähler;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Zähler);
            Zähler++;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
