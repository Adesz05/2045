using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2045
{
    

    public partial class Form1 : Form
    {
        static int szorzo = 4;
        static int[,] matrix = new int[szorzo, szorzo];
        static System.Windows.Forms.Label[,] labelmatrix = new System.Windows.Forms.Label[szorzo, szorzo];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Visible = false;
            
        }
    }
}
