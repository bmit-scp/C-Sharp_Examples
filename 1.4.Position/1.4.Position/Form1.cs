using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._4.Position
{
    public partial class Form1 : Form
    {
        int x = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Auto.Location = new Point(x, 10);
        }

        private void Auto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (x < 400)
            {
                x = x + 20;
            }
            this.Auto.Location = new Point(x, 10);
            
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (x > 10)
            {
                x = x - 20;
            }
            this.Auto.Location = new Point(x, 10);

        }
    }
}
