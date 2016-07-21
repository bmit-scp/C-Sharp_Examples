using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._3.Zufall
{
    public partial class Form1 : Form
    {

        Random r = new Random();
        int ran1 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ran1 = r.Next(1, 10);
            label1.Text = Convert.ToString(ran1);
        }
    }
}
