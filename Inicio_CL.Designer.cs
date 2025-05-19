
namespace NumeroAletorio_CL
{
    partial class Inicio_CL
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNumero = new System.Windows.Forms.Button();
            this.btnJuego = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Juegos";
            // 
            // btnNumero
            // 
            this.btnNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(240)))));
            this.btnNumero.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero.Location = new System.Drawing.Point(97, 151);
            this.btnNumero.Name = "btnNumero";
            this.btnNumero.Size = new System.Drawing.Size(367, 46);
            this.btnNumero.TabIndex = 1;
            this.btnNumero.Text = "Adivina el Número Aleatorio";
            this.btnNumero.UseVisualStyleBackColor = false;
            this.btnNumero.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnJuego
            // 
            this.btnJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(240)))));
            this.btnJuego.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuego.Location = new System.Drawing.Point(97, 219);
            this.btnJuego.Name = "btnJuego";
            this.btnJuego.Size = new System.Drawing.Size(367, 46);
            this.btnJuego.TabIndex = 1;
            this.btnJuego.Text = "Piedra, papel y tijera";
            this.btnJuego.UseVisualStyleBackColor = false;
            this.btnJuego.Click += new System.EventHandler(this.button2_Click);
            // 
            // Inicio_CL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(568, 350);
            this.Controls.Add(this.btnJuego);
            this.Controls.Add(this.btnNumero);
            this.Controls.Add(this.label1);
            this.Name = "Inicio_CL";
            this.Text = "Inicio_CL";
            this.Load += new System.EventHandler(this.Inicio_CL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNumero;
        private System.Windows.Forms.Button btnJuego;
    }
}