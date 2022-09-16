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
       public  static int lepesek = 0;
        static int szorzo = 4;
        static int[,] matrix = new int[szorzo, szorzo];
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonBalra.Visible = true;
            buttonFel.Visible = true;
            buttonJobbra.Visible = true;
            buttonLe.Visible = true;
            buttonValtas.Visible = true;
            MatrixFeltoltes();
            Random();
            Frissit();
            button1.Visible = false;
           

        }

        private void Random()
        {
            Random r = new Random();
            int rszam = 0;
            int rsor = 0;
            int roszlop = 0;

            rszam = r.Next(1, 3)*2;

            rsor = r.Next(0, 3);
            roszlop = r.Next(0, 3);

          
            matrix[rsor, roszlop] = rszam;
            Frissit();
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

        private void Frissit()
        {
            for (int i = 0; i < szorzo; i++)
            {
                for (int j = 0; j < szorzo; j++)
                {
                    Label label = new Label();
                    label.Size = new Size(50, 50);
                    label.BackColor = Color.Red;
                    label.Location = new Point(250 + i*64,j*64);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    if (matrix[i,j] == 0)
                    {
                        label.Text = "";
                    }
                    else
                    {
                        label.Text = Convert.ToString(matrix[i, j]);
                    }
                    this.Controls.Add(label);
                }
            }
        }

        

        

        
    }
}
