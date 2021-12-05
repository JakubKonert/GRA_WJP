
namespace GRA_WJP.Ekrany
{
    partial class Start_menu
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
            this.Start_gry = new System.Windows.Forms.Button();
            this.Cel_gry = new System.Windows.Forms.Button();
            this.Statystyki_start = new System.Windows.Forms.Button();
            this.Wyjscie_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start_gry
            // 
            this.Start_gry.Location = new System.Drawing.Point(364, 92);
            this.Start_gry.Name = "Start_gry";
            this.Start_gry.Size = new System.Drawing.Size(75, 23);
            this.Start_gry.TabIndex = 0;
            this.Start_gry.Text = "Start Gry";
            this.Start_gry.UseVisualStyleBackColor = true;
            this.Start_gry.Click += new System.EventHandler(this.Start_gry_Click);
            // 
            // Cel_gry
            // 
            this.Cel_gry.Location = new System.Drawing.Point(364, 188);
            this.Cel_gry.Name = "Cel_gry";
            this.Cel_gry.Size = new System.Drawing.Size(75, 23);
            this.Cel_gry.TabIndex = 1;
            this.Cel_gry.Text = "Cel gry";
            this.Cel_gry.UseVisualStyleBackColor = true;
            this.Cel_gry.Click += new System.EventHandler(this.Cel_gry_Click);
            // 
            // Statystyki_start
            // 
            this.Statystyki_start.Location = new System.Drawing.Point(364, 291);
            this.Statystyki_start.Name = "Statystyki_start";
            this.Statystyki_start.Size = new System.Drawing.Size(75, 23);
            this.Statystyki_start.TabIndex = 2;
            this.Statystyki_start.Text = "Statystyki";
            this.Statystyki_start.UseVisualStyleBackColor = true;
            this.Statystyki_start.Click += new System.EventHandler(this.Statystyki_start_Click);
            // 
            // Wyjscie_start
            // 
            this.Wyjscie_start.Location = new System.Drawing.Point(364, 365);
            this.Wyjscie_start.Name = "Wyjscie_start";
            this.Wyjscie_start.Size = new System.Drawing.Size(75, 23);
            this.Wyjscie_start.TabIndex = 3;
            this.Wyjscie_start.Text = "Wyjście";
            this.Wyjscie_start.UseVisualStyleBackColor = true;
            this.Wyjscie_start.Click += new System.EventHandler(this.Wyjscie_Click);
            // 
            // Start_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Wyjscie_start);
            this.Controls.Add(this.Statystyki_start);
            this.Controls.Add(this.Cel_gry);
            this.Controls.Add(this.Start_gry);
            this.Name = "Start_menu";
            this.Text = "Start_menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_gry;
        private System.Windows.Forms.Button Cel_gry;
        private System.Windows.Forms.Button Statystyki_start;
        private System.Windows.Forms.Button Wyjscie_start;
    }
}