
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
            this.NazwaBudynkuLabel = new System.Windows.Forms.Label();
            this.LevelBudynkuButton = new System.Windows.Forms.Label();
            this.PojemnoscBudynkuLabel = new System.Windows.Forms.Label();
            this.UpgradeButton = new System.Windows.Forms.Button();
            this.WymaganiaUlepszeniaButton = new System.Windows.Forms.Label();
            this.WyjscieBudynekButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NazwaBudynkuLabel
            // 
            this.NazwaBudynkuLabel.AutoSize = true;
            this.NazwaBudynkuLabel.Location = new System.Drawing.Point(250, 50);
            this.NazwaBudynkuLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NazwaBudynkuLabel.Name = "NazwaBudynkuLabel";
            this.NazwaBudynkuLabel.Size = new System.Drawing.Size(82, 24);
            this.NazwaBudynkuLabel.TabIndex = 0;
            this.NazwaBudynkuLabel.Text = "label1";
            // 
            // LevelBudynkuButton
            // 
            this.LevelBudynkuButton.AutoSize = true;
            this.LevelBudynkuButton.Location = new System.Drawing.Point(250, 150);
            this.LevelBudynkuButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LevelBudynkuButton.Name = "LevelBudynkuButton";
            this.LevelBudynkuButton.Size = new System.Drawing.Size(86, 24);
            this.LevelBudynkuButton.TabIndex = 1;
            this.LevelBudynkuButton.Text = "label2";
            // 
            // PojemnoscBudynkuLabel
            // 
            this.PojemnoscBudynkuLabel.AutoSize = true;
            this.PojemnoscBudynkuLabel.Location = new System.Drawing.Point(250, 230);
            this.PojemnoscBudynkuLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PojemnoscBudynkuLabel.Name = "PojemnoscBudynkuLabel";
            this.PojemnoscBudynkuLabel.Size = new System.Drawing.Size(86, 24);
            this.PojemnoscBudynkuLabel.TabIndex = 2;
            this.PojemnoscBudynkuLabel.Text = "label3";
            // 
            // UpgradeButton
            // 
            this.UpgradeButton.Location = new System.Drawing.Point(280, 350);
            this.UpgradeButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UpgradeButton.Name = "UpgradeButton";
            this.UpgradeButton.Size = new System.Drawing.Size(131, 34);
            this.UpgradeButton.TabIndex = 3;
            this.UpgradeButton.Text = "Ulepsz";
            this.UpgradeButton.UseVisualStyleBackColor = true;
            this.UpgradeButton.Click += new System.EventHandler(this.Upgrade_Click);
            // 
            // WymaganiaUlepszeniaButton
            // 
            this.WymaganiaUlepszeniaButton.AutoSize = true;
            this.WymaganiaUlepszeniaButton.Location = new System.Drawing.Point(250, 300);
            this.WymaganiaUlepszeniaButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.WymaganiaUlepszeniaButton.Name = "WymaganiaUlepszeniaButton";
            this.WymaganiaUlepszeniaButton.Size = new System.Drawing.Size(75, 24);
            this.WymaganiaUlepszeniaButton.TabIndex = 4;
            this.WymaganiaUlepszeniaButton.Text = "Cena:";
            // 
            // WyjscieBudynekButton
            // 
            this.WyjscieBudynekButton.Location = new System.Drawing.Point(280, 500);
            this.WyjscieBudynekButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.WyjscieBudynekButton.Name = "WyjscieBudynekButton";
            this.WyjscieBudynekButton.Size = new System.Drawing.Size(130, 35);
            this.WyjscieBudynekButton.TabIndex = 5;
            this.WyjscieBudynekButton.Text = "Wyjscie";
            this.WyjscieBudynekButton.UseVisualStyleBackColor = true;
            this.WyjscieBudynekButton.Click += new System.EventHandler(this.Wyjscie_budynek_Click);
            // 
            // BudynekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 549);
            this.ControlBox = false;
            this.Controls.Add(this.WyjscieBudynekButton);
            this.Controls.Add(this.WymaganiaUlepszeniaButton);
            this.Controls.Add(this.UpgradeButton);
            this.Controls.Add(this.PojemnoscBudynkuLabel);
            this.Controls.Add(this.LevelBudynkuButton);
            this.Controls.Add(this.NazwaBudynkuLabel);
            this.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "BudynekForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zarządzanie budynkiem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NazwaBudynkuLabel;
        private System.Windows.Forms.Label LevelBudynkuButton;
        private System.Windows.Forms.Label PojemnoscBudynkuLabel;
        private System.Windows.Forms.Button UpgradeButton;
        private System.Windows.Forms.Label WymaganiaUlepszeniaButton;
        private System.Windows.Forms.Button WyjscieBudynekButton;
    }
}