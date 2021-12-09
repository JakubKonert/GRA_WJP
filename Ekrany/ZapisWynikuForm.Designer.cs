
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
            this.ZapisWynikuButton = new System.Windows.Forms.Button();
            this.ZapisWynikuTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ZapisWynikuButton
            // 
            this.ZapisWynikuButton.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZapisWynikuButton.Location = new System.Drawing.Point(65, 70);
            this.ZapisWynikuButton.Name = "ZapisWynikuButton";
            this.ZapisWynikuButton.Size = new System.Drawing.Size(120, 60);
            this.ZapisWynikuButton.TabIndex = 0;
            this.ZapisWynikuButton.Text = "Zapisz";
            this.ZapisWynikuButton.UseVisualStyleBackColor = true;
            this.ZapisWynikuButton.Click += new System.EventHandler(this.ZapisWyniku_Click);
            // 
            // ZapisWynikuTextBox
            // 
            this.ZapisWynikuTextBox.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZapisWynikuTextBox.Location = new System.Drawing.Point(75, 20);
            this.ZapisWynikuTextBox.Name = "ZapisWynikuTextBox";
            this.ZapisWynikuTextBox.Size = new System.Drawing.Size(100, 32);
            this.ZapisWynikuTextBox.TabIndex = 1;
            this.ZapisWynikuTextBox.Text = "Gracz";
            // 
            // ZapisWynikuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(252, 183);
            this.ControlBox = false;
            this.Controls.Add(this.ZapisWynikuTextBox);
            this.Controls.Add(this.ZapisWynikuButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ZapisWynikuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zapis Wyniku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZapisWynikuButton;
        private System.Windows.Forms.TextBox ZapisWynikuTextBox;
    }
}