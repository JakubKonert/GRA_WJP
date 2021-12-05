
namespace GRA_WJP.Ekrany
{
    partial class StatystykiForm
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
            this.Statystyki_text = new System.Windows.Forms.Label();
            this.powrot_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Statystyki_text
            // 
            this.Statystyki_text.AutoSize = true;
            this.Statystyki_text.Location = new System.Drawing.Point(448, 86);
            this.Statystyki_text.Name = "Statystyki_text";
            this.Statystyki_text.Size = new System.Drawing.Size(0, 17);
            this.Statystyki_text.TabIndex = 0;
            // 
            // powrot_menu
            // 
            this.powrot_menu.Location = new System.Drawing.Point(418, 535);
            this.powrot_menu.Name = "powrot_menu";
            this.powrot_menu.Size = new System.Drawing.Size(234, 93);
            this.powrot_menu.TabIndex = 1;
            this.powrot_menu.Text = "Powrót do menu głównego";
            this.powrot_menu.UseVisualStyleBackColor = true;
            this.powrot_menu.Click += new System.EventHandler(this.powrot_menu_Click);
            // 
            // StatystykiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.ControlBox = false;
            this.Controls.Add(this.powrot_menu);
            this.Controls.Add(this.Statystyki_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatystykiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statystyki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Statystyki_text;
        private System.Windows.Forms.Button powrot_menu;
    }
}