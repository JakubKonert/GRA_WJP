
namespace GRA_WJP.Ekrany
{
    partial class SurowiecForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurowiecForm));
            this.SurowiecNazwaLabel = new System.Windows.Forms.Label();
            this.DostepnaPopulacjaSuwakLabel = new System.Windows.Forms.Label();
            this.PopulacjaTrackBar = new System.Windows.Forms.TrackBar();
            this.PopulacjaPrzydzielonaSuwakLabel = new System.Windows.Forms.Label();
            this.WyjscieSurowiecButton = new System.Windows.Forms.Button();
            this.Wartosc0Label = new System.Windows.Forms.Label();
            this.AnulujButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PopulacjaTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SurowiecNazwaLabel
            // 
            this.SurowiecNazwaLabel.AutoSize = true;
            this.SurowiecNazwaLabel.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurowiecNazwaLabel.Location = new System.Drawing.Point(300, 9);
            this.SurowiecNazwaLabel.Name = "SurowiecNazwaLabel";
            this.SurowiecNazwaLabel.Size = new System.Drawing.Size(82, 24);
            this.SurowiecNazwaLabel.TabIndex = 0;
            this.SurowiecNazwaLabel.Text = "label1";
            // 
            // DostepnaPopulacjaSuwakLabel
            // 
            this.DostepnaPopulacjaSuwakLabel.AutoSize = true;
            this.DostepnaPopulacjaSuwakLabel.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DostepnaPopulacjaSuwakLabel.Location = new System.Drawing.Point(630, 60);
            this.DostepnaPopulacjaSuwakLabel.Name = "DostepnaPopulacjaSuwakLabel";
            this.DostepnaPopulacjaSuwakLabel.Size = new System.Drawing.Size(86, 24);
            this.DostepnaPopulacjaSuwakLabel.TabIndex = 1;
            this.DostepnaPopulacjaSuwakLabel.Text = "label2";
            // 
            // PopulacjaTrackBar
            // 
            this.PopulacjaTrackBar.LargeChange = 10;
            this.PopulacjaTrackBar.Location = new System.Drawing.Point(101, 60);
            this.PopulacjaTrackBar.Maximum = 100;
            this.PopulacjaTrackBar.Name = "PopulacjaTrackBar";
            this.PopulacjaTrackBar.Size = new System.Drawing.Size(500, 56);
            this.PopulacjaTrackBar.TabIndex = 3;
            this.PopulacjaTrackBar.TickFrequency = 10;
            this.PopulacjaTrackBar.Scroll += new System.EventHandler(this.PopulacjaTrackBar_Scroll);
            // 
            // PopulacjaPrzydzielonaSuwakLabel
            // 
            this.PopulacjaPrzydzielonaSuwakLabel.AutoSize = true;
            this.PopulacjaPrzydzielonaSuwakLabel.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopulacjaPrzydzielonaSuwakLabel.Location = new System.Drawing.Point(343, 107);
            this.PopulacjaPrzydzielonaSuwakLabel.Name = "PopulacjaPrzydzielonaSuwakLabel";
            this.PopulacjaPrzydzielonaSuwakLabel.Size = new System.Drawing.Size(86, 24);
            this.PopulacjaPrzydzielonaSuwakLabel.TabIndex = 4;
            this.PopulacjaPrzydzielonaSuwakLabel.Text = "label3";
            // 
            // WyjscieSurowiecButton
            // 
            this.WyjscieSurowiecButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WyjscieSurowiecButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WyjscieSurowiecButton.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WyjscieSurowiecButton.Location = new System.Drawing.Point(282, 138);
            this.WyjscieSurowiecButton.Name = "WyjscieSurowiecButton";
            this.WyjscieSurowiecButton.Size = new System.Drawing.Size(148, 40);
            this.WyjscieSurowiecButton.TabIndex = 5;
            this.WyjscieSurowiecButton.Text = "Przydziel";
            this.WyjscieSurowiecButton.UseVisualStyleBackColor = true;
            this.WyjscieSurowiecButton.Click += new System.EventHandler(this.WyjscieSurowiec_Click);
            // 
            // Wartosc0Label
            // 
            this.Wartosc0Label.AutoSize = true;
            this.Wartosc0Label.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wartosc0Label.Location = new System.Drawing.Point(30, 60);
            this.Wartosc0Label.Name = "Wartosc0Label";
            this.Wartosc0Label.Size = new System.Drawing.Size(24, 24);
            this.Wartosc0Label.TabIndex = 6;
            this.Wartosc0Label.Text = "0";
            // 
            // AnulujButton
            // 
            this.AnulujButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AnulujButton.BackgroundImage")));
            this.AnulujButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnulujButton.Cursor = System.Windows.Forms.Cursors.No;
            this.AnulujButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnulujButton.Location = new System.Drawing.Point(436, 138);
            this.AnulujButton.Name = "AnulujButton";
            this.AnulujButton.Size = new System.Drawing.Size(40, 40);
            this.AnulujButton.TabIndex = 7;
            this.AnulujButton.UseVisualStyleBackColor = true;
            this.AnulujButton.Click += new System.EventHandler(this.AnulujButton_Click);
            // 
            // SurowiecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(706, 227);
            this.ControlBox = false;
            this.Controls.Add(this.AnulujButton);
            this.Controls.Add(this.Wartosc0Label);
            this.Controls.Add(this.WyjscieSurowiecButton);
            this.Controls.Add(this.PopulacjaPrzydzielonaSuwakLabel);
            this.Controls.Add(this.PopulacjaTrackBar);
            this.Controls.Add(this.DostepnaPopulacjaSuwakLabel);
            this.Controls.Add(this.SurowiecNazwaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SurowiecForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zarządzenie Surowcem";
            ((System.ComponentModel.ISupportInitialize)(this.PopulacjaTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SurowiecNazwaLabel;
        private System.Windows.Forms.Label DostepnaPopulacjaSuwakLabel;
        private System.Windows.Forms.TrackBar PopulacjaTrackBar;
        private System.Windows.Forms.Label PopulacjaPrzydzielonaSuwakLabel;
        private System.Windows.Forms.Button WyjscieSurek;
        private System.Windows.Forms.Button WyjscieSurowiecButton;
        private System.Windows.Forms.Label Wartosc0Label;
        private System.Windows.Forms.Button AnulujButton;
    }
}