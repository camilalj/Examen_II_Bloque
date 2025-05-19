
namespace NumeroAletorio_CL
{
    partial class piedra_papel_tijera
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
            this.btnPiedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTijera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(107, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Escoge una opción!";
            // 
            // btnPiedra
            // 
            this.btnPiedra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPiedra.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPiedra.Location = new System.Drawing.Point(93, 130);
            this.btnPiedra.Name = "btnPiedra";
            this.btnPiedra.Size = new System.Drawing.Size(281, 56);
            this.btnPiedra.TabIndex = 1;
            this.btnPiedra.Text = "Piedra";
            this.btnPiedra.UseVisualStyleBackColor = false;
            this.btnPiedra.Click += new System.EventHandler(this.btnPiedra_Click_1);
            // 
            // btnPapel
            // 
            this.btnPapel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPapel.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapel.Location = new System.Drawing.Point(93, 207);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(281, 56);
            this.btnPapel.TabIndex = 1;
            this.btnPapel.Text = "Papel";
            this.btnPapel.UseVisualStyleBackColor = false;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnTijera
            // 
            this.btnTijera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTijera.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTijera.Location = new System.Drawing.Point(93, 286);
            this.btnTijera.Name = "btnTijera";
            this.btnTijera.Size = new System.Drawing.Size(281, 56);
            this.btnTijera.TabIndex = 1;
            this.btnTijera.Text = "Tijera";
            this.btnTijera.UseVisualStyleBackColor = false;
            this.btnTijera.Click += new System.EventHandler(this.btnTijera_Click);
            // 
            // piedra_papel_tijera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(476, 391);
            this.Controls.Add(this.btnTijera);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPiedra);
            this.Controls.Add(this.label1);
            this.Name = "piedra_papel_tijera";
            this.Text = "piedra_papel_tijera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPiedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTijera;
    }
}