
namespace GRA_WJP.Ekrany
{
    partial class BudynekForm
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
            this.nazwa_budynku = new System.Windows.Forms.Label();
            this.Level_budynku = new System.Windows.Forms.Label();
            this.Pojemnosc_budynku = new System.Windows.Forms.Label();
            this.Upgrade = new System.Windows.Forms.Button();
            this.Wymagania_ulepszenia = new System.Windows.Forms.Label();
            this.Wyjscie_budynek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nazwa_budynku
            // 
            this.nazwa_budynku.AutoSize = true;
            this.nazwa_budynku.Location = new System.Drawing.Point(331, 65);
            this.nazwa_budynku.Name = "nazwa_budynku";
            this.nazwa_budynku.Size = new System.Drawing.Size(46, 17);
            this.nazwa_budynku.TabIndex = 0;
            this.nazwa_budynku.Text = "label1";
            // 
            // Level_budynku
            // 
            this.Level_budynku.AutoSize = true;
            this.Level_budynku.Location = new System.Drawing.Point(331, 128);
            this.Level_budynku.Name = "Level_budynku";
            this.Level_budynku.Size = new System.Drawing.Size(46, 17);
            this.Level_budynku.TabIndex = 1;
            this.Level_budynku.Text = "label2";
            // 
            // Pojemnosc_budynku
            // 
            this.Pojemnosc_budynku.AutoSize = true;
            this.Pojemnosc_budynku.Location = new System.Drawing.Point(331, 174);
            this.Pojemnosc_budynku.Name = "Pojemnosc_budynku";
            this.Pojemnosc_budynku.Size = new System.Drawing.Size(46, 17);
            this.Pojemnosc_budynku.TabIndex = 2;
            this.Pojemnosc_budynku.Text = "label3";
            // 
            // Upgrade
            // 
            this.Upgrade.Location = new System.Drawing.Point(334, 265);
            this.Upgrade.Name = "Upgrade";
            this.Upgrade.Size = new System.Drawing.Size(75, 23);
            this.Upgrade.TabIndex = 3;
            this.Upgrade.Text = "Ulepsz";
            this.Upgrade.UseVisualStyleBackColor = true;
            this.Upgrade.Click += new System.EventHandler(this.Upgrade_Click);
            // 
            // Wymagania_ulepszenia
            // 
            this.Wymagania_ulepszenia.AutoSize = true;
            this.Wymagania_ulepszenia.Location = new System.Drawing.Point(334, 211);
            this.Wymagania_ulepszenia.Name = "Wymagania_ulepszenia";
            this.Wymagania_ulepszenia.Size = new System.Drawing.Size(45, 17);
            this.Wymagania_ulepszenia.TabIndex = 4;
            this.Wymagania_ulepszenia.Text = "Cena:";
            // 
            // Wyjscie_budynek
            // 
            this.Wyjscie_budynek.Location = new System.Drawing.Point(337, 342);
            this.Wyjscie_budynek.Name = "Wyjscie_budynek";
            this.Wyjscie_budynek.Size = new System.Drawing.Size(75, 23);
            this.Wyjscie_budynek.TabIndex = 5;
            this.Wyjscie_budynek.Text = "Wyjscie";
            this.Wyjscie_budynek.UseVisualStyleBackColor = true;
            this.Wyjscie_budynek.Click += new System.EventHandler(this.Wyjscie_budynek_Click);
            // 
            // BudynekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Wyjscie_budynek);
            this.Controls.Add(this.Wymagania_ulepszenia);
            this.Controls.Add(this.Upgrade);
            this.Controls.Add(this.Pojemnosc_budynku);
            this.Controls.Add(this.Level_budynku);
            this.Controls.Add(this.nazwa_budynku);
            this.Name = "BudynekForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zarządzanie budynkiem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazwa_budynku;
        private System.Windows.Forms.Label Level_budynku;
        private System.Windows.Forms.Label Pojemnosc_budynku;
        private System.Windows.Forms.Button Upgrade;
        private System.Windows.Forms.Label Wymagania_ulepszenia;
        private System.Windows.Forms.Button Wyjscie_budynek;
    }
}