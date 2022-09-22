
namespace _2045
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFel = new System.Windows.Forms.Button();
            this.buttonJobbra = new System.Windows.Forms.Button();
            this.buttonLe = new System.Windows.Forms.Button();
            this.buttonBalra = new System.Windows.Forms.Button();
            this.buttonValtas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Játék";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFel
            // 
            this.buttonFel.Location = new System.Drawing.Point(182, 347);
            this.buttonFel.Name = "buttonFel";
            this.buttonFel.Size = new System.Drawing.Size(75, 75);
            this.buttonFel.TabIndex = 1;
            this.buttonFel.Text = "Fel";
            this.buttonFel.UseVisualStyleBackColor = true;
            this.buttonFel.Visible = false;
            this.buttonFel.Click += new System.EventHandler(this.buttonFel_Click);
            // 
            // buttonJobbra
            // 
            this.buttonJobbra.Location = new System.Drawing.Point(263, 428);
            this.buttonJobbra.Name = "buttonJobbra";
            this.buttonJobbra.Size = new System.Drawing.Size(75, 75);
            this.buttonJobbra.TabIndex = 2;
            this.buttonJobbra.Text = "Jobbra";
            this.buttonJobbra.UseVisualStyleBackColor = true;
            this.buttonJobbra.Visible = false;
            this.buttonJobbra.Click += new System.EventHandler(this.buttonJobbra_Click);
            // 
            // buttonLe
            // 
            this.buttonLe.Location = new System.Drawing.Point(182, 509);
            this.buttonLe.Name = "buttonLe";
            this.buttonLe.Size = new System.Drawing.Size(75, 75);
            this.buttonLe.TabIndex = 3;
            this.buttonLe.Text = "Le";
            this.buttonLe.UseVisualStyleBackColor = true;
            this.buttonLe.Visible = false;
            this.buttonLe.Click += new System.EventHandler(this.buttonLe_Click);
            // 
            // buttonBalra
            // 
            this.buttonBalra.Location = new System.Drawing.Point(101, 428);
            this.buttonBalra.Name = "buttonBalra";
            this.buttonBalra.Size = new System.Drawing.Size(75, 75);
            this.buttonBalra.TabIndex = 4;
            this.buttonBalra.Text = "Balra";
            this.buttonBalra.UseVisualStyleBackColor = true;
            this.buttonBalra.Visible = false;
            this.buttonBalra.Click += new System.EventHandler(this.buttonBalra_Click);
            // 
            // buttonValtas
            // 
            this.buttonValtas.Location = new System.Drawing.Point(183, 428);
            this.buttonValtas.Name = "buttonValtas";
            this.buttonValtas.Size = new System.Drawing.Size(75, 75);
            this.buttonValtas.TabIndex = 0;
            this.buttonValtas.Text = "Váltás";
            this.buttonValtas.UseVisualStyleBackColor = true;
            this.buttonValtas.Visible = false;
            this.buttonValtas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonValtas_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 609);
            this.Controls.Add(this.buttonValtas);
            this.Controls.Add(this.buttonBalra);
            this.Controls.Add(this.buttonLe);
            this.Controls.Add(this.buttonJobbra);
            this.Controls.Add(this.buttonFel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonFel;
        private System.Windows.Forms.Button buttonJobbra;
        private System.Windows.Forms.Button buttonLe;
        private System.Windows.Forms.Button buttonBalra;
        private System.Windows.Forms.Button buttonValtas;
    }
}

