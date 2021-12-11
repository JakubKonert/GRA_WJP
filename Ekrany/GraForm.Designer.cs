
namespace GRA_WJP.Ekrany
{
    partial class GraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TuraLabel = new System.Windows.Forms.Label();
            this.DrewnoButton = new System.Windows.Forms.Button();
            this.ZlotoButton = new System.Windows.Forms.Button();
            this.PopulacjaLabel = new System.Windows.Forms.Label();
            this.JedzenieButton = new System.Windows.Forms.Button();
            this.TartakButton = new System.Windows.Forms.Button();
            this.FarmaButton = new System.Windows.Forms.Button();
            this.DomButton = new System.Windows.Forms.Button();
            this.KopalniaButton = new System.Windows.Forms.Button();
            this.KoniecTuryButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Wheat;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.TuraLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DrewnoButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ZlotoButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.PopulacjaLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.JedzenieButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(90, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 75);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // TuraLabel
            // 
            this.TuraLabel.AutoSize = true;
            this.TuraLabel.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuraLabel.Location = new System.Drawing.Point(3, 0);
            this.TuraLabel.Name = "TuraLabel";
            this.TuraLabel.Size = new System.Drawing.Size(73, 24);
            this.TuraLabel.TabIndex = 1;
            this.TuraLabel.Text = "Tura:";
            // 
            // DrewnoButton
            // 
            this.DrewnoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DrewnoButton.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrewnoButton.Location = new System.Drawing.Point(613, 3);
            this.DrewnoButton.Name = "DrewnoButton";
            this.DrewnoButton.Size = new System.Drawing.Size(234, 69);
            this.DrewnoButton.TabIndex = 3;
            this.DrewnoButton.Text = "Drewno:";
            this.DrewnoButton.UseVisualStyleBackColor = true;
            this.DrewnoButton.Click += new System.EventHandler(this.Drewno_Click);
            // 
            // ZlotoButton
            // 
            this.ZlotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ZlotoButton.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZlotoButton.Location = new System.Drawing.Point(858, 3);
            this.ZlotoButton.Name = "ZlotoButton";
            this.ZlotoButton.Size = new System.Drawing.Size(235, 69);
            this.ZlotoButton.TabIndex = 4;
            this.ZlotoButton.Text = "Złoto:";
            this.ZlotoButton.UseVisualStyleBackColor = true;
            this.ZlotoButton.Click += new System.EventHandler(this.Zloto_Click);
            // 
            // PopulacjaLabel
            // 
            this.PopulacjaLabel.AutoSize = true;
            this.PopulacjaLabel.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopulacjaLabel.Location = new System.Drawing.Point(123, 0);
            this.PopulacjaLabel.Name = "PopulacjaLabel";
            this.PopulacjaLabel.Size = new System.Drawing.Size(143, 24);
            this.PopulacjaLabel.TabIndex = 5;
            this.PopulacjaLabel.Text = "Populacja:";
            // 
            // JedzenieButton
            // 
            this.JedzenieButton.BackColor = System.Drawing.Color.Wheat;
            this.JedzenieButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JedzenieButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JedzenieButton.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JedzenieButton.ForeColor = System.Drawing.Color.Black;
            this.JedzenieButton.Location = new System.Drawing.Point(368, 3);
            this.JedzenieButton.Name = "JedzenieButton";
            this.JedzenieButton.Size = new System.Drawing.Size(234, 69);
            this.JedzenieButton.TabIndex = 2;
            this.JedzenieButton.Text = "Jedzenie:";
            this.JedzenieButton.UseVisualStyleBackColor = false;
            this.JedzenieButton.Click += new System.EventHandler(this.Jedzenie_Click);
            // 
            // TartakButton
            // 
            this.TartakButton.BackColor = System.Drawing.Color.Transparent;
            this.TartakButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TartakButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TartakButton.Font = new System.Drawing.Font("Montserrat Subrayada", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TartakButton.ForeColor = System.Drawing.Color.Wheat;
            this.TartakButton.Location = new System.Drawing.Point(12, 233);
            this.TartakButton.Name = "TartakButton";
            this.TartakButton.Size = new System.Drawing.Size(210, 241);
            this.TartakButton.TabIndex = 1;
            this.TartakButton.Text = "Tartak";
            this.TartakButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TartakButton.UseVisualStyleBackColor = false;
            this.TartakButton.Click += new System.EventHandler(this.Tartak_Click);
            // 
            // FarmaButton
            // 
            this.FarmaButton.BackColor = System.Drawing.Color.Transparent;
            this.FarmaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FarmaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FarmaButton.Font = new System.Drawing.Font("Montserrat Subrayada", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FarmaButton.ForeColor = System.Drawing.Color.Wheat;
            this.FarmaButton.Location = new System.Drawing.Point(447, 124);
            this.FarmaButton.Name = "FarmaButton";
            this.FarmaButton.Size = new System.Drawing.Size(206, 248);
            this.FarmaButton.TabIndex = 2;
            this.FarmaButton.Text = "Farma";
            this.FarmaButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FarmaButton.UseVisualStyleBackColor = false;
            this.FarmaButton.Click += new System.EventHandler(this.Farma_Click);
            // 
            // DomButton
            // 
            this.DomButton.BackColor = System.Drawing.Color.Transparent;
            this.DomButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DomButton.Font = new System.Drawing.Font("Montserrat Subrayada", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomButton.ForeColor = System.Drawing.Color.Wheat;
            this.DomButton.Location = new System.Drawing.Point(704, 259);
            this.DomButton.Name = "DomButton";
            this.DomButton.Size = new System.Drawing.Size(251, 262);
            this.DomButton.TabIndex = 3;
            this.DomButton.Text = "Dom";
            this.DomButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DomButton.UseVisualStyleBackColor = false;
            this.DomButton.Click += new System.EventHandler(this.Dom_Click);
            // 
            // KopalniaButton
            // 
            this.KopalniaButton.BackColor = System.Drawing.Color.Transparent;
            this.KopalniaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KopalniaButton.Font = new System.Drawing.Font("Montserrat Subrayada", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KopalniaButton.ForeColor = System.Drawing.Color.Wheat;
            this.KopalniaButton.Location = new System.Drawing.Point(1017, 424);
            this.KopalniaButton.Name = "KopalniaButton";
            this.KopalniaButton.Size = new System.Drawing.Size(233, 222);
            this.KopalniaButton.TabIndex = 4;
            this.KopalniaButton.Text = "Kopalnia";
            this.KopalniaButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KopalniaButton.UseVisualStyleBackColor = false;
            this.KopalniaButton.Click += new System.EventHandler(this.Kopalnia_Click);
            // 
            // KoniecTuryButton
            // 
            this.KoniecTuryButton.BackColor = System.Drawing.Color.Wheat;
            this.KoniecTuryButton.Font = new System.Drawing.Font("Montserrat Subrayada", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KoniecTuryButton.Location = new System.Drawing.Point(1030, 740);
            this.KoniecTuryButton.Name = "KoniecTuryButton";
            this.KoniecTuryButton.Size = new System.Drawing.Size(211, 97);
            this.KoniecTuryButton.TabIndex = 5;
            this.KoniecTuryButton.Text = "Następna tura";
            this.KoniecTuryButton.UseVisualStyleBackColor = false;
            this.KoniecTuryButton.Click += new System.EventHandler(this.Koniec_tury_Click);
            // 
            // GraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.ControlBox = false;
            this.Controls.Add(this.KoniecTuryButton);
            this.Controls.Add(this.KopalniaButton);
            this.Controls.Add(this.DomButton);
            this.Controls.Add(this.FarmaButton);
            this.Controls.Add(this.TartakButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Village 1000";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GraForm_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button TartakButton;
        private System.Windows.Forms.Button FarmaButton;
        private System.Windows.Forms.Button DomButton;
        private System.Windows.Forms.Button KopalniaButton;
        private System.Windows.Forms.Label TuraLabel;
        private System.Windows.Forms.Button JedzenieButton;
        private System.Windows.Forms.Button DrewnoButton;
        private System.Windows.Forms.Button ZlotoButton;
        private System.Windows.Forms.Label PopulacjaLabel;
        public System.Windows.Forms.Button KoniecTuryButton;
    }
}