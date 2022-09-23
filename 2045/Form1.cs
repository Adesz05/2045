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
        static int[,] matrixmasolat = new int[szorzo, szorzo];
        static bool[,] boolmatrix = new bool[szorzo, szorzo];
        static bool fel, le,jobbra, balra = false;
        static System.Windows.Forms.Label[,] matrixlabel = new System.Windows.Forms.Label[szorzo, szorzo];
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            buttonBalra.Visible = true;
            buttonFel.Visible = true;
            buttonJobbra.Visible = true;
            buttonLe.Visible = true;
            buttonValtas.Visible = true;
            MatrixFeltoltes();
            Frissit();
            RandomSzamGeneralas();
            RandomSzamGeneralas();
            button1.Visible = false;
        }

        private void RandomSzamGeneralas()
        {
            Random r = new Random();
            int rszam, rsor, roszlop;

            while (true)
            {
                rszam = r.Next(1, 3) * 128;

                rsor = r.Next(0, szorzo);
                roszlop = r.Next(0, szorzo);

                /*if (foglaltelemek > szorzo*szorzo-1)
                {
                    MessageBox.Show("Vesztettél cicus");
                    break;
                }
                else
                {
                    
                }*/
                if (matrix[rsor, roszlop] == 0)
                {
                    matrix[rsor, roszlop] = rszam;
                    //foglaltelemek++;
                    break;
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
                        matrixlabel[i, j].BackColor = Color.FromArgb(199,185,172);
                    }
                    if (matrixlabel[i, j].Text == "2")
                    {
                        matrixlabel[i, j].BackColor = Color.FromArgb(238,228,218);
                        matrixlabel[i, j].ForeColor = Color.Black;
                    }
                    if (matrixlabel[i, j].Text == "4")
                    {
                        matrixlabel[i, j].BackColor = Color.FromArgb(238, 225, 190);
                        matrixlabel[i, j].ForeColor = Color.Black;
                    }
                    if (matrixlabel[i, j].Text == "8")
                    {
                        matrixlabel[i, j].BackColor = Color.FromArgb(243, 178, 122);
                        matrixlabel[i, j].ForeColor = Color.White;
                    }
                    if (matrixlabel[i, j].Text == "16")
                    {
                        matrixlabel[i, j].BackColor = Color.FromArgb(246, 150, 100);
                        matrixlabel[i, j].ForeColor = Color.White;
                    }
                    if (matrixlabel[i, j].Text == "32")
                    {
                        matrixlabel[i, j].BackColor = Color.FromArgb(247, 124, 95);
                        matrixlabel[i, j].ForeColor = Color.White;
                    }
                    if (matrixlabel[i, j].Text == "64")
                    {
                        matrixlabel[i, j].BackColor = Color.FromArgb(247, 95, 59);
                        matrixlabel[i, j].ForeColor = Color.White;
                    }
                    if (matrixlabel[i, j].Text == "128")
                    {
                        matrixlabel[i, j].BackColor = Color.FromArgb(237, 208, 115);
                        matrixlabel[i, j].ForeColor = Color.White;
                    }
                    if (matrixlabel[i, j].Text == "256")
                    {
                        matrixlabel[i, j].BackColor = Color.FromArgb(237, 204, 99);
                        matrixlabel[i, j].ForeColor = Color.White;
                    }
                    if (matrixlabel[i, j].Text == "512")
                    {
                        matrixlabel[i, j].BackColor = Color.FromArgb(240, 196, 95);
                        matrixlabel[i, j].ForeColor = Color.White;
                    }
                    if (matrixlabel[i, j].Text == "1024")
                    {
                        matrixlabel[i, j].BackColor = Color.FromArgb(237, 197, 62);
                        matrixlabel[i, j].ForeColor = Color.White;
                    }
                    if (matrixlabel[i, j].Text == "2048")
                    {
                        matrixlabel[i, j].BackColor = Color.FromArgb(240, 196, 27);
                        matrixlabel[i, j].ForeColor = Color.White;
                        MessageBox.Show("Nyertél!");
                        Close();
                    }


                }
                
               
            }
            le = false;
            fel = false;
            jobbra = false;
            balra = false;

        }

       

        private void MatrixFeltoltes()
        {
            for (int i = 0; i < szorzo; i++)
            {
                for (int j = 0; j < szorzo; j++)
                {
                    matrix[i, j] = 0;
                    boolmatrix[i, j] = true;
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
                    label.BackColor = Color.White;
                    label.Location = new Point(100 + j*64,50+i*64);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Font = new Font("Arial", 12, FontStyle.Bold);
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
                BalraFele();
            }
            if (e.KeyCode == Keys.W)
            {
                FelFele();
            }
            if (e.KeyCode == Keys.D)
            {
                JobbraFele();
            }
            if (e.KeyCode == Keys.S)
            {
                LeFele();
            }
         
        }


        private void buttonFel_Click(object sender, EventArgs e)
        {
            FelFele();
            
        }

        private void FelFele()
        {
            for (int sor = 0; sor < szorzo; sor++)
            {
                for (int oszlop = 0; oszlop < szorzo; oszlop++)
                {
                    if (matrix[sor, oszlop] != 0)
                    {
                        for (int i = 0; i < sor; i++)
                        {
                            if (matrix[sor - i - 1, oszlop] == 0)
                            {
                                valtozas = true;
                                matrix[sor - 1 - i, oszlop] = matrix[sor - i, oszlop];
                                matrix[sor - i, oszlop] = 0;

                                boolmatrix[sor - 1 - i, oszlop] = boolmatrix[sor - i, oszlop];
                                boolmatrix[sor - i, oszlop] = true;

                                Frissit2();

                            }
                            else if (matrix[sor - i - 1, oszlop] == matrix[sor - i, oszlop] && boolmatrix[sor - i - 1, oszlop] == true && boolmatrix[sor - i, oszlop] == true)
                            {
                                matrix[sor - i - 1, oszlop] += matrix[sor - i, oszlop];
                                matrix[sor - i, oszlop] = 0;
                                boolmatrix[sor - i - 1, oszlop] = false;
                                Frissit2();
                            }
                            else
                            {
                                break;
                            }
                        }
                        Vissza();
                    }
                }
            }
            if (valtozas)
            {
                RandomSzamGeneralas();
                valtozas = false;
            }
            else
            {
                fel = true;
               Vesztettele();
                
            }
        }

        private void Vesztettele()
        {
            matrixmasolat = matrix;
            if (fel == true && le ==true&& jobbra == true && balra == true)
            {
                MessageBox.Show("Vesztettél");
            }
        }

        private void Vissza()
        {
            for (int i = 0; i < szorzo; i++)
            {
                for (int j = 0; j < szorzo; j++)
                {
                    boolmatrix[i, j] = true;
                }
            }
        }

        private void buttonJobbra_Click(object sender, EventArgs e)
        {
            JobbraFele();
        }

        private void JobbraFele()
        {
            for (int sor = szorzo - 1; sor > -1; sor--)
            {
                for (int oszlop = szorzo - 1; oszlop > -1; oszlop--)
                {
                    if (matrix[sor, oszlop] != 0)
                    {
                        for (int i = 0; i < szorzo - 1 - oszlop; i++)
                        {

                            if (matrix[sor, oszlop + i + 1] == 0)
                            {
                                matrix[sor, oszlop + 1 + i] = matrix[sor, oszlop + i];
                                matrix[sor, oszlop + i] = 0;

                                boolmatrix[sor, oszlop + 1 + i] = boolmatrix[sor, oszlop + i];
                                boolmatrix[sor, oszlop + i] = true;
                                Frissit2();
                            }
                            else if (matrix[sor, oszlop + 1 + i] == matrix[sor, oszlop + i] && boolmatrix[sor, oszlop + 1 + i] ==true && boolmatrix[sor, oszlop + i] == true)
                            {
                                matrix[sor, oszlop + 1 + i] += matrix[sor, oszlop + i];
                                matrix[sor, oszlop + i] = 0;
                                boolmatrix[sor, oszlop + 1 + i] = false;
                                Frissit2();
                            }
                            else
                            { 
                                // Ha a számok megegyeznek akk csuszas;
                                break;
                            }
                        }
                        Vissza();
                    }
                }
            }
            if (valtozas)
            {
                RandomSzamGeneralas();
                valtozas = false;
            }
            else
            {
                jobbra = true;
                Vesztettele();
            }
        }

        private void buttonLe_Click(object sender, EventArgs e)
        {
            LeFele();
        }

        private void LeFele()
        {
            for (int sor = szorzo-1; sor > -1; sor--)
            {
                for (int oszlop = szorzo-1; oszlop > -1; oszlop--)
                {
                    if (matrix[sor, oszlop] != 0)
                    {
                        for (int i = 0; i < szorzo-1 - sor; i++)
                        {

                            if (matrix[sor + i + 1, oszlop] == 0)
                            {
                                matrix[sor + 1 + i, oszlop] = matrix[sor + i, oszlop];
                                matrix[sor + i, oszlop] = 0;
                                boolmatrix[sor + 1 + i, oszlop] = boolmatrix[sor + i, oszlop];
                                boolmatrix[sor + i, oszlop] = true;
                                Frissit2();

                            }
                            else if (matrix[sor + 1 + i, oszlop] == matrix[sor + i, oszlop] && boolmatrix[sor + 1 + i, oszlop] == true && boolmatrix[sor + i, oszlop] == true)
                            {
                                matrix[sor + 1 + i, oszlop] += matrix[sor + i, oszlop];
                                matrix[sor + i, oszlop] = 0;
                                boolmatrix[sor + 1 + i, oszlop] = false;
                                Frissit2();
                            }
                            else
                            {
                                // Ha a számok megegyeznek akk csuszas;
                                break;
                            }
                        }
                        Vissza();
                    }
                }
            }
            if (valtozas)
            {
                RandomSzamGeneralas();
                valtozas = false;
            }
            else
            {
                le = true;
                Vesztettele();
            }
        }

        private void buttonBalra_Click(object sender, EventArgs e)
        {
            BalraFele();
        }
        private void BalraFele()
        {
            for (int sor = 0; sor < szorzo; sor++)
            {
                for (int oszlop = 0; oszlop < szorzo; oszlop++)
                {
                    if (matrix[sor, oszlop] != 0)
                    {
                        for (int i = 0; i < oszlop; i++)
                        {
                            if (matrix[sor, oszlop - i - 1] == 0)
                            {
                                matrix[sor, oszlop - 1 - i] = matrix[sor, oszlop - i];
                                matrix[sor, oszlop - i] = 0;
                                boolmatrix[sor, oszlop - 1 - i] = boolmatrix[sor, oszlop - i];
                                boolmatrix[sor, oszlop - i] = true;
                                Frissit2();

                            }
                            else if (matrix[sor, oszlop - 1 - i] == matrix[sor, oszlop - i] && boolmatrix[sor, oszlop - 1 - i] == true && boolmatrix[sor, oszlop - i] == true)
                            {
                                matrix[sor, oszlop - 1 - i] += matrix[sor, oszlop - i];
                                matrix[sor, oszlop - i] = 0;
                                boolmatrix[sor, oszlop - 1 - i] = false;
                                Frissit2();
                            }
                            else
                            {
                                // Ha a számok megegyeznek akk csuszas;
                                break;
                            }
                        }
                        Vissza();
                    }
                }
            }
            if (valtozas)
            {
                RandomSzamGeneralas();
                valtozas = false;
            }
            else
            {
                balra = true;
                Vesztettele();
            }
        }
    }
}
