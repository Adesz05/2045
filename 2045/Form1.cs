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
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            button1.Visible = false;
            MatrixFeltoltes();
            frissit();

        }

        private void MatrixFeltoltes()
        {
            for (int i = 0; i < szorzo; i++)
            {
                for (int j = 0; j < szorzo; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        private void frissit()
        {
            for (int i = 0; i < szorzo; i++)
            {
                for (int j = 0; j < szorzo; j++)
                {
                    Label label = new Label();
                    label.Size = new System.Drawing.Size(77, 21);
                    label.BackColor = Color.Red;
                    if (matrix[i,j] == 0)
                    {
                        label.Text = "";
                    }
                    else
                    {
                        label.Text = Convert.ToString(matrix[i, j]);
                    }
             
                }
            }
        }
    }
}
