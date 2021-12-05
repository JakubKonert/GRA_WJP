
namespace GRA_WJP.Ekrany
{
    partial class ZapisWynikuForm
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
            this.ZapisWyniku = new System.Windows.Forms.Button();
            this.zapisWynikuTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ZapisWyniku
            // 
            this.ZapisWyniku.Location = new System.Drawing.Point(364, 360);
            this.ZapisWyniku.Name = "ZapisWyniku";
            this.ZapisWyniku.Size = new System.Drawing.Size(75, 23);
            this.ZapisWyniku.TabIndex = 0;
            this.ZapisWyniku.Text = "Zapisz";
            this.ZapisWyniku.UseVisualStyleBackColor = true;
            this.ZapisWyniku.Click += new System.EventHandler(this.ZapisWyniku_Click);
            // 
            // zapisWynikuTextBox
            // 
            this.zapisWynikuTextBox.Location = new System.Drawing.Point(364, 111);
            this.zapisWynikuTextBox.Name = "zapisWynikuTextBox";
            this.zapisWynikuTextBox.Size = new System.Drawing.Size(100, 22);
            this.zapisWynikuTextBox.TabIndex = 1;
            // 
            // ZapisWynikuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zapisWynikuTextBox);
            this.Controls.Add(this.ZapisWyniku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZapisWynikuForm";
            this.Text = "ZapisWynikuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZapisWyniku;
        private System.Windows.Forms.TextBox zapisWynikuTextBox;
    }
}