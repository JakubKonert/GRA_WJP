
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
            this.SurowiecNazwa = new System.Windows.Forms.Label();
            this.DostepnaPopulacjaSuwak = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PopulacjaTrackBar = new System.Windows.Forms.TrackBar();
            this.PopulacjaPrzydzielonaSuwak = new System.Windows.Forms.Label();
            this.WyjscieSurowiec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PopulacjaTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SurowiecNazwa
            // 
            this.SurowiecNazwa.AutoSize = true;
            this.SurowiecNazwa.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurowiecNazwa.Location = new System.Drawing.Point(375, 25);
            this.SurowiecNazwa.Name = "SurowiecNazwa";
            this.SurowiecNazwa.Size = new System.Drawing.Size(82, 24);
            this.SurowiecNazwa.TabIndex = 0;
            this.SurowiecNazwa.Text = "label1";
            // 
            // DostepnaPopulacjaSuwak
            // 
            this.DostepnaPopulacjaSuwak.AutoSize = true;
            this.DostepnaPopulacjaSuwak.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DostepnaPopulacjaSuwak.Location = new System.Drawing.Point(650, 66);
            this.DostepnaPopulacjaSuwak.Name = "DostepnaPopulacjaSuwak";
            this.DostepnaPopulacjaSuwak.Size = new System.Drawing.Size(86, 24);
            this.DostepnaPopulacjaSuwak.TabIndex = 1;
            this.DostepnaPopulacjaSuwak.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PopulacjaTrackBar
            // 
            this.PopulacjaTrackBar.LargeChange = 10;
            this.PopulacjaTrackBar.Location = new System.Drawing.Point(125, 60);
            this.PopulacjaTrackBar.Maximum = 100;
            this.PopulacjaTrackBar.Name = "PopulacjaTrackBar";
            this.PopulacjaTrackBar.Size = new System.Drawing.Size(500, 56);
            this.PopulacjaTrackBar.TabIndex = 3;
            this.PopulacjaTrackBar.TickFrequency = 10;
            this.PopulacjaTrackBar.Scroll += new System.EventHandler(this.PopulacjaTrackBar_Scroll);
            // 
            // PopulacjaPrzydzielonaSuwak
            // 
            this.PopulacjaPrzydzielonaSuwak.AutoSize = true;
            this.PopulacjaPrzydzielonaSuwak.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopulacjaPrzydzielonaSuwak.Location = new System.Drawing.Point(30, 66);
            this.PopulacjaPrzydzielonaSuwak.Name = "PopulacjaPrzydzielonaSuwak";
            this.PopulacjaPrzydzielonaSuwak.Size = new System.Drawing.Size(86, 24);
            this.PopulacjaPrzydzielonaSuwak.TabIndex = 4;
            this.PopulacjaPrzydzielonaSuwak.Text = "label3";
            // 
            // WyjscieSurowiec
            // 
            this.WyjscieSurowiec.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WyjscieSurowiec.Location = new System.Drawing.Point(361, 152);
            this.WyjscieSurowiec.Name = "WyjscieSurowiec";
            this.WyjscieSurowiec.Size = new System.Drawing.Size(153, 41);
            this.WyjscieSurowiec.TabIndex = 5;
            this.WyjscieSurowiec.Text = "Przydziel";
            this.WyjscieSurowiec.UseVisualStyleBackColor = true;
            this.WyjscieSurowiec.Click += new System.EventHandler(this.WyjscieSurowiec_Click);
            // 
            // SurowiecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 249);
            this.ControlBox = false;
            this.Controls.Add(this.WyjscieSurowiec);
            this.Controls.Add(this.PopulacjaPrzydzielonaSuwak);
            this.Controls.Add(this.PopulacjaTrackBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DostepnaPopulacjaSuwak);
            this.Controls.Add(this.SurowiecNazwa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SurowiecForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Zarządzenie Surowcem";
            ((System.ComponentModel.ISupportInitialize)(this.PopulacjaTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SurowiecNazwa;
        private System.Windows.Forms.Label DostepnaPopulacjaSuwak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar PopulacjaTrackBar;
        private System.Windows.Forms.Label PopulacjaPrzydzielonaSuwak;
        private System.Windows.Forms.Button WyjscieSurek;
        private System.Windows.Forms.Button WyjscieSurowiec;
    }
}