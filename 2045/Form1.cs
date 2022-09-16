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
       public  static int foglaltelemek = 0;
        static int szorzo = 4;
        static int[,] matrix = new int[szorzo, szorzo];
        static System.Windows.Forms.Label[,] matrixlabel = new System.Windows.Forms.Label[szorzo, szorzo];
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
            Frissit();
            RandomSzamGeneralas();
            button1.Visible = false;
           

        }

        private void RandomSzamGeneralas()
        {
            Random r = new Random();
            int rszam, rsor, roszlop;

            while (true)
            {
                rszam = r.Next(1, 3) * 2;

                rsor = r.Next(0, 4);
                roszlop = r.Next(0, 4);

                if (foglaltelemek > 15)
                {
                    MessageBox.Show("Vesztettél");
                    break;
                }
                else
                {
                    if (matrix[rsor, roszlop] == 0)
                    {
                        matrix[rsor, roszlop] = rszam;
                        foglaltelemek++;
                        break;
                    }
                    
                }
            }
           
           
            Frissit2();
        }

        private void Frissit2()
        {
            for (int i = 0; i < szorzo; i++)
            {
                for (int j = 0; j < szorzo; j++)
                {
                    if (matrix[i,j]!=0)
                    {
                    matrixlabel[i, j].Text = matrix[i, j].ToString();

                    }
                    else
                    {
                        matrixlabel[i, j].Text = "";
                    }
                }
            }
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
                    matrixlabel[i, j] = label;
                    this.Controls.Add(label);
                }
            }
        }

        private void buttonValtas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                RandomSzamGeneralas();
                //MessageBox.Show("cica");
            }
        }

        private void buttonValtas_Click(object sender, EventArgs e)
        {

        }
    }
}
