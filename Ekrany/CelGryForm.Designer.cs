
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
            this.OpisLabel = new System.Windows.Forms.Label();
            this.PowrotMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpisLabel
            // 
            this.OpisLabel.AutoSize = true;
            this.OpisLabel.Location = new System.Drawing.Point(29, 29);
            this.OpisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OpisLabel.Name = "OpisLabel";
            this.OpisLabel.Size = new System.Drawing.Size(72, 20);
            this.OpisLabel.TabIndex = 1;
            this.OpisLabel.Text = "label1";
            // 
            // PowrotMenuButton
            // 
            this.PowrotMenuButton.Location = new System.Drawing.Point(400, 660);
            this.PowrotMenuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PowrotMenuButton.Name = "PowrotMenuButton";
            this.PowrotMenuButton.Size = new System.Drawing.Size(200, 62);
            this.PowrotMenuButton.TabIndex = 2;
            this.PowrotMenuButton.Text = "Powrót do menu głównego";
            this.PowrotMenuButton.UseVisualStyleBackColor = true;
            this.PowrotMenuButton.Click += new System.EventHandler(this.PowrotMenuButton_Click);
            // 
            // CelGryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.ControlBox = false;
            this.Controls.Add(this.PowrotMenuButton);
            this.Controls.Add(this.OpisLabel);
            this.Cursor = System.Windows.Forms.Cursors.Help;
            this.Font = new System.Drawing.Font("Montserrat Subrayada", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CelGryForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cel gry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OpisLabel;
        private System.Windows.Forms.Button PowrotMenuButton;
    }
}