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
        static bool  valtozas = false;
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
            valtozas = true;
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
                    label.Location = new Point(250 + j*64,i*64);
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


        private void buttonFel_Click(object sender, EventArgs e)
        {
            for (int sor = 0; sor < szorzo; sor++)
            {
                for (int oszlop = 0; oszlop < szorzo; oszlop++)
                {
                    if (matrix[sor, oszlop] != 0)
                    {
                        for (int i = 0; i < sor; i++)
                        {
                            if (matrix[sor-i-1,oszlop] == 0)
                            {
                                valtozas = true;
                                matrix[sor - 1 - i, oszlop] = matrix[sor - i, oszlop];
                                matrix[sor-i, oszlop] = 0;
                                Frissit2();
                               
                            }
                            else
                            {
                                // Ha a számok megegyeznek akk csuszas;
                                break;
                            }
                        }
                    }
                }
            }
            if (valtozas)
            {
                RandomSzamGeneralas();
                valtozas = false;
            }
            
        }

        private void buttonJobbra_Click(object sender, EventArgs e)
        {
            for (int sor = 3; sor > -1; sor--)
            {
                for (int oszlop = 3; oszlop > -1; oszlop--)
                {
                    if (matrix[sor, oszlop] != 0)
                    {
                        for (int i = 0; i < 3 - oszlop; i++)
                        {

                            if (matrix[sor , oszlop + i + 1] == 0)
                            {
                                matrix[sor, oszlop + 1 + i] = matrix[sor , oszlop + i];
                                matrix[sor , oszlop + i] = 0;
                                Frissit2();
                            }
                            else
                            {
                            
                                // Ha a számok megegyeznek akk csuszas;
                                break;
                            }
                        }
                    }
                }
            }
            if (valtozas)
            {
                RandomSzamGeneralas();
                valtozas = false;
            }
        }

        private void buttonLe_Click(object sender, EventArgs e)
        {
                for (int sor = 3; sor > -1; sor--)
                {
                    for (int oszlop = 3; oszlop > -1 ; oszlop--)
                    {
                        if (matrix[sor, oszlop] != 0)
                        {
                            for (int i = 0; i < 3 - sor; i++)
                            {

                                if (matrix[sor + i + 1, oszlop] == 0)
                                {
                                    matrix[sor + 1 + i, oszlop] = matrix[sor + i, oszlop];
                                    matrix[sor + i, oszlop] = 0;
                                    Frissit2();
                                
                            }
                                else
                                {
                                    // Ha a számok megegyeznek akk csuszas;
                                    break;
                                }
                            }
                        }
                    }
                }
            if (valtozas)
            {
                RandomSzamGeneralas();
                valtozas = false;
            }
        }
           
        

        private void buttonBalra_Click(object sender, EventArgs e)
        {
            for (int sor = 0; sor < szorzo; sor++)
            {
                for (int oszlop = 0; oszlop < szorzo; oszlop++)
                {
                    if (matrix[sor, oszlop] != 0)
                    {
                        for (int i = 0; i < oszlop; i++)
                        {
                            if (matrix[sor , oszlop - i - 1] == 0)
                            {
                                matrix[sor , oszlop - 1 - i] = matrix[sor , oszlop - i];
                                matrix[sor, oszlop - i] = 0;
                                Frissit2();
                                
                            }
                            else
                            {
                                // Ha a számok megegyeznek akk csuszas;
                                break;
                            }
                        }
                    }
                }
            }
            if (valtozas)
            {
                RandomSzamGeneralas();
                valtozas = false;
            }
        }


    }
}
