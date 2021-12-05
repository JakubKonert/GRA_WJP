
namespace GRA_WJP.Ekrany
{
    partial class Podsumowanie_tury
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
            this.Następna_tura = new System.Windows.Forms.Button();
            this.koniec_tury = new System.Windows.Forms.Label();
            this.stosunek_tur = new System.Windows.Forms.Label();
            this.populacja_tura = new System.Windows.Forms.Label();
            this.jedzenie_tura = new System.Windows.Forms.Label();
            this.drewno_tura = new System.Windows.Forms.Label();
            this.zloto_tura = new System.Windows.Forms.Label();
            this.ZdarzenieLosoweLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Następna_tura
            // 
            this.Następna_tura.Location = new System.Drawing.Point(316, 369);
            this.Następna_tura.Name = "Następna_tura";
            this.Następna_tura.Size = new System.Drawing.Size(156, 38);
            this.Następna_tura.TabIndex = 0;
            this.Następna_tura.Text = "Następna tura";
            this.Następna_tura.UseVisualStyleBackColor = true;
            this.Następna_tura.Click += new System.EventHandler(this.Następna_tura_Click);
            // 
            // koniec_tury
            // 
            this.koniec_tury.AutoSize = true;
            this.koniec_tury.Location = new System.Drawing.Point(359, 31);
            this.koniec_tury.Name = "koniec_tury";
            this.koniec_tury.Size = new System.Drawing.Size(46, 17);
            this.koniec_tury.TabIndex = 1;
            this.koniec_tury.Text = "label1";
            // 
            // stosunek_tur
            // 
            this.stosunek_tur.AutoSize = true;
            this.stosunek_tur.Location = new System.Drawing.Point(359, 89);
            this.stosunek_tur.Name = "stosunek_tur";
            this.stosunek_tur.Size = new System.Drawing.Size(46, 17);
            this.stosunek_tur.TabIndex = 2;
            this.stosunek_tur.Text = "label2";
            // 
            // populacja_tura
            // 
            this.populacja_tura.AutoSize = true;
            this.populacja_tura.Location = new System.Drawing.Point(359, 127);
            this.populacja_tura.Name = "populacja_tura";
            this.populacja_tura.Size = new System.Drawing.Size(46, 17);
            this.populacja_tura.TabIndex = 3;
            this.populacja_tura.Text = "label3";
            // 
            // jedzenie_tura
            // 
            this.jedzenie_tura.AutoSize = true;
            this.jedzenie_tura.Location = new System.Drawing.Point(359, 170);
            this.jedzenie_tura.Name = "jedzenie_tura";
            this.jedzenie_tura.Size = new System.Drawing.Size(46, 17);
            this.jedzenie_tura.TabIndex = 4;
            this.jedzenie_tura.Text = "label4";
            // 
            // drewno_tura
            // 
            this.drewno_tura.AutoSize = true;
            this.drewno_tura.Location = new System.Drawing.Point(359, 212);
            this.drewno_tura.Name = "drewno_tura";
            this.drewno_tura.Size = new System.Drawing.Size(46, 17);
            this.drewno_tura.TabIndex = 5;
            this.drewno_tura.Text = "label5";
            // 
            // zloto_tura
            // 
            this.zloto_tura.AutoSize = true;
            this.zloto_tura.Location = new System.Drawing.Point(359, 277);
            this.zloto_tura.Name = "zloto_tura";
            this.zloto_tura.Size = new System.Drawing.Size(46, 17);
            this.zloto_tura.TabIndex = 6;
            this.zloto_tura.Text = "label6";
            // 
            // ZdarzenieLosoweLabel
            // 
            this.ZdarzenieLosoweLabel.AutoSize = true;
            this.ZdarzenieLosoweLabel.Location = new System.Drawing.Point(362, 316);
            this.ZdarzenieLosoweLabel.Name = "ZdarzenieLosoweLabel";
            this.ZdarzenieLosoweLabel.Size = new System.Drawing.Size(46, 17);
            this.ZdarzenieLosoweLabel.TabIndex = 7;
            this.ZdarzenieLosoweLabel.Text = "label1";
            // 
            // Podsumowanie_tury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ZdarzenieLosoweLabel);
            this.Controls.Add(this.zloto_tura);
            this.Controls.Add(this.drewno_tura);
            this.Controls.Add(this.jedzenie_tura);
            this.Controls.Add(this.populacja_tura);
            this.Controls.Add(this.stosunek_tur);
            this.Controls.Add(this.koniec_tury);
            this.Controls.Add(this.Następna_tura);
            this.Name = "Podsumowanie_tury";
            this.Text = "Podsumowanie tury";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Następna_tura;
        private System.Windows.Forms.Label koniec_tury;
        private System.Windows.Forms.Label stosunek_tur;
        private System.Windows.Forms.Label populacja_tura;
        private System.Windows.Forms.Label jedzenie_tura;
        private System.Windows.Forms.Label drewno_tura;
        private System.Windows.Forms.Label zloto_tura;
        private System.Windows.Forms.Label ZdarzenieLosoweLabel;
    }
}