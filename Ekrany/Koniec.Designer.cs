
namespace GRA_WJP.Ekrany
{
    partial class Koniec
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
            this.Statystyki_koniec = new System.Windows.Forms.Button();
            this.Powrot_koniec = new System.Windows.Forms.Button();
            this.Wyjscie_koniec = new System.Windows.Forms.Button();
            this.WygranaPrzegrana = new System.Windows.Forms.Label();
            this.TuraKonca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Statystyki_koniec
            // 
            this.Statystyki_koniec.Location = new System.Drawing.Point(287, 143);
            this.Statystyki_koniec.Name = "Statystyki_koniec";
            this.Statystyki_koniec.Size = new System.Drawing.Size(133, 63);
            this.Statystyki_koniec.TabIndex = 0;
            this.Statystyki_koniec.Text = "Zapisz swój wynik";
            this.Statystyki_koniec.UseVisualStyleBackColor = true;
            this.Statystyki_koniec.Click += new System.EventHandler(this.Statystyki_koniec_Click);
            // 
            // Powrot_koniec
            // 
            this.Powrot_koniec.Location = new System.Drawing.Point(287, 212);
            this.Powrot_koniec.Name = "Powrot_koniec";
            this.Powrot_koniec.Size = new System.Drawing.Size(127, 50);
            this.Powrot_koniec.TabIndex = 1;
            this.Powrot_koniec.Text = "Powrót do menu";
            this.Powrot_koniec.UseVisualStyleBackColor = true;
            this.Powrot_koniec.Click += new System.EventHandler(this.Powrot_koniec_Click);
            // 
            // Wyjscie_koniec
            // 
            this.Wyjscie_koniec.Location = new System.Drawing.Point(287, 268);
            this.Wyjscie_koniec.Name = "Wyjscie_koniec";
            this.Wyjscie_koniec.Size = new System.Drawing.Size(133, 40);
            this.Wyjscie_koniec.TabIndex = 2;
            this.Wyjscie_koniec.Text = "Wyjście";
            this.Wyjscie_koniec.UseVisualStyleBackColor = true;
            this.Wyjscie_koniec.Click += new System.EventHandler(this.Wyjscie_koniec_Click);
            // 
            // WygranaPrzegrana
            // 
            this.WygranaPrzegrana.AutoSize = true;
            this.WygranaPrzegrana.Location = new System.Drawing.Point(313, 28);
            this.WygranaPrzegrana.Name = "WygranaPrzegrana";
            this.WygranaPrzegrana.Size = new System.Drawing.Size(46, 17);
            this.WygranaPrzegrana.TabIndex = 3;
            this.WygranaPrzegrana.Text = "label1";
            // 
            // TuraKonca
            // 
            this.TuraKonca.AutoSize = true;
            this.TuraKonca.Location = new System.Drawing.Point(313, 70);
            this.TuraKonca.Name = "TuraKonca";
            this.TuraKonca.Size = new System.Drawing.Size(46, 17);
            this.TuraKonca.TabIndex = 4;
            this.TuraKonca.Text = "label2";
            // 
            // Koniec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TuraKonca);
            this.Controls.Add(this.WygranaPrzegrana);
            this.Controls.Add(this.Wyjscie_koniec);
            this.Controls.Add(this.Powrot_koniec);
            this.Controls.Add(this.Statystyki_koniec);
            this.Name = "Koniec";
            this.Text = "Koniec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Statystyki_koniec;
        private System.Windows.Forms.Button Powrot_koniec;
        private System.Windows.Forms.Button Wyjscie_koniec;
        private System.Windows.Forms.Label WygranaPrzegrana;
        private System.Windows.Forms.Label TuraKonca;
    }
}