using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._1.CopyButton
{
    public partial class Form1 : Form
    {
        //Hier wird einen String für die Eingabe erstellt

        string Eingabe;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //Hier wird der Text, der vom User eingegeben wurde in den Labeltextbereich kopiert

            lblPaste.Text = boxCopy.Text;

            //Hier wird die Eingabe in den String "Eingabe" kopiert

            Eingabe = lblPaste.Text;

        }
    }
}
