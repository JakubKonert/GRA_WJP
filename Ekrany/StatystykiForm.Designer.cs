
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
            this.StatystykiTextLabel = new System.Windows.Forms.Label();
            this.PowrotMenuButton = new System.Windows.Forms.Button();
            this.StatystykiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatystykiTextLabel
            // 
            this.StatystykiTextLabel.AutoSize = true;
            this.StatystykiTextLabel.Location = new System.Drawing.Point(340, 90);
            this.StatystykiTextLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StatystykiTextLabel.Name = "StatystykiTextLabel";
            this.StatystykiTextLabel.Size = new System.Drawing.Size(0, 24);
            this.StatystykiTextLabel.TabIndex = 0;
            // 
            // PowrotMenuButton
            // 
            this.PowrotMenuButton.Location = new System.Drawing.Point(350, 650);
            this.PowrotMenuButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PowrotMenuButton.Name = "PowrotMenuButton";
            this.PowrotMenuButton.Size = new System.Drawing.Size(300, 70);
            this.PowrotMenuButton.TabIndex = 1;
            this.PowrotMenuButton.Text = "Powrót do menu głównego";
            this.PowrotMenuButton.UseVisualStyleBackColor = true;
            this.PowrotMenuButton.Click += new System.EventHandler(this.powrot_menu_Click);
            // 
            // StatystykiLabel
            // 
            this.StatystykiLabel.AutoSize = true;
            this.StatystykiLabel.Location = new System.Drawing.Point(443, 30);
            this.StatystykiLabel.Name = "StatystykiLabel";
            this.StatystykiLabel.Size = new System.Drawing.Size(86, 24);
            this.StatystykiLabel.TabIndex = 2;
            this.StatystykiLabel.Text = "Wyniki";
            // 
            // StatystykiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.ControlBox = false;
            this.Controls.Add(this.StatystykiLabel);
            this.Controls.Add(this.PowrotMenuButton);
            this.Controls.Add(this.StatystykiTextLabel);
            this.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatystykiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statystyki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatystykiTextLabel;
        private System.Windows.Forms.Button PowrotMenuButton;
        private System.Windows.Forms.Label StatystykiLabel;
    }
}