
namespace GRA_WJP.Ekrany
{
    partial class CelGryForm
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
            this.powrot_Menu = new System.Windows.Forms.Button();
            this.Opis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // powrot_Menu
            // 
            this.powrot_Menu.Location = new System.Drawing.Point(525, 908);
            this.powrot_Menu.Name = "powrot_Menu";
            this.powrot_Menu.Size = new System.Drawing.Size(195, 75);
            this.powrot_Menu.TabIndex = 0;
            this.powrot_Menu.Text = "Powrót do menu głównego";
            this.powrot_Menu.UseVisualStyleBackColor = true;
            this.powrot_Menu.Click += new System.EventHandler(this.powrot_Menu_Click);
            // 
            // Opis
            // 
            this.Opis.AutoSize = true;
            this.Opis.Location = new System.Drawing.Point(522, 52);
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(46, 17);
            this.Opis.TabIndex = 1;
            this.Opis.Text = "label1";
            // 
            // CelGryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.Opis);
            this.Controls.Add(this.powrot_Menu);
            this.Cursor = System.Windows.Forms.Cursors.Help;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CelGryForm";
            this.Text = "Cel gry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powrot_Menu;
        private System.Windows.Forms.Label Opis;
    }
}