namespace PrvaAplikacija
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Očisti sve korištene resurse.
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
            this.gumbKlikni = new System.Windows.Forms.Button();
            this.labelaPoruka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gumbKlikni
            // 
            this.gumbKlikni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gumbKlikni.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumbKlikni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gumbKlikni.Location = new System.Drawing.Point(254, 169);
            this.gumbKlikni.Name = "gumbKlikni";
            this.gumbKlikni.Size = new System.Drawing.Size(269, 68);
            this.gumbKlikni.TabIndex = 0;
            this.gumbKlikni.Text = "KLIKNI ME!";
            this.gumbKlikni.UseVisualStyleBackColor = false;
            this.gumbKlikni.Click += new System.EventHandler(this.gumbKlikni_Click);
            // 
            // labelaPoruka
            // 
            this.labelaPoruka.AutoSize = true;
            this.labelaPoruka.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaPoruka.Location = new System.Drawing.Point(268, 251);
            this.labelaPoruka.Name = "labelaPoruka";
            this.labelaPoruka.Size = new System.Drawing.Size(255, 41);
            this.labelaPoruka.TabIndex = 1;
            this.labelaPoruka.Text = "Kliknite gornji gumb!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelaPoruka);
            this.Controls.Add(this.gumbKlikni);
            this.Name = "Form1";
            this.Text = "Moja prva forma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbKlikni;
        private System.Windows.Forms.Label labelaPoruka;
    }
}

