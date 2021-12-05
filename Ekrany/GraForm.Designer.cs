
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
            this.Tura = new System.Windows.Forms.Label();
            this.Drewno = new System.Windows.Forms.Button();
            this.Zloto = new System.Windows.Forms.Button();
            this.Populacja = new System.Windows.Forms.Label();
            this.Jedzenie = new System.Windows.Forms.Button();
            this.Tartak = new System.Windows.Forms.Button();
            this.Farma = new System.Windows.Forms.Button();
            this.Dom = new System.Windows.Forms.Button();
            this.Kopalnia = new System.Windows.Forms.Button();
            this.Koniec_tury = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.Tura, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Drewno, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Zloto, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Populacja, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Jedzenie, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(90, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 75);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Tura
            // 
            this.Tura.AutoSize = true;
            this.Tura.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tura.Location = new System.Drawing.Point(3, 0);
            this.Tura.Name = "Tura";
            this.Tura.Size = new System.Drawing.Size(73, 24);
            this.Tura.TabIndex = 1;
            this.Tura.Text = "Tura:";
            // 
            // Drewno
            // 
            this.Drewno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Drewno.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drewno.Location = new System.Drawing.Point(613, 3);
            this.Drewno.Name = "Drewno";
            this.Drewno.Size = new System.Drawing.Size(234, 69);
            this.Drewno.TabIndex = 3;
            this.Drewno.Text = "Drewno:";
            this.Drewno.UseVisualStyleBackColor = true;
            this.Drewno.Click += new System.EventHandler(this.Drewno_Click);
            // 
            // Zloto
            // 
            this.Zloto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Zloto.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zloto.Location = new System.Drawing.Point(858, 3);
            this.Zloto.Name = "Zloto";
            this.Zloto.Size = new System.Drawing.Size(235, 69);
            this.Zloto.TabIndex = 4;
            this.Zloto.Text = "Złoto:";
            this.Zloto.UseVisualStyleBackColor = true;
            this.Zloto.Click += new System.EventHandler(this.Zloto_Click);
            // 
            // Populacja
            // 
            this.Populacja.AutoSize = true;
            this.Populacja.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Populacja.Location = new System.Drawing.Point(123, 0);
            this.Populacja.Name = "Populacja";
            this.Populacja.Size = new System.Drawing.Size(143, 24);
            this.Populacja.TabIndex = 5;
            this.Populacja.Text = "Populacja:";
            // 
            // Jedzenie
            // 
            this.Jedzenie.BackColor = System.Drawing.Color.Wheat;
            this.Jedzenie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Jedzenie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Jedzenie.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jedzenie.ForeColor = System.Drawing.Color.Black;
            this.Jedzenie.Location = new System.Drawing.Point(368, 3);
            this.Jedzenie.Name = "Jedzenie";
            this.Jedzenie.Size = new System.Drawing.Size(234, 69);
            this.Jedzenie.TabIndex = 2;
            this.Jedzenie.Text = "Jedzenie:";
            this.Jedzenie.UseVisualStyleBackColor = false;
            this.Jedzenie.Click += new System.EventHandler(this.Jedzenie_Click);
            // 
            // Tartak
            // 
            this.Tartak.BackColor = System.Drawing.Color.Transparent;
            this.Tartak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tartak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tartak.Font = new System.Drawing.Font("Montserrat Subrayada", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tartak.ForeColor = System.Drawing.Color.Wheat;
            this.Tartak.Location = new System.Drawing.Point(12, 233);
            this.Tartak.Name = "Tartak";
            this.Tartak.Size = new System.Drawing.Size(210, 241);
            this.Tartak.TabIndex = 1;
            this.Tartak.Text = "Tartak";
            this.Tartak.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tartak.UseVisualStyleBackColor = false;
            this.Tartak.Click += new System.EventHandler(this.Tartak_Click);
            // 
            // Farma
            // 
            this.Farma.BackColor = System.Drawing.Color.Transparent;
            this.Farma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Farma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Farma.Font = new System.Drawing.Font("Montserrat Subrayada", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Farma.ForeColor = System.Drawing.Color.Wheat;
            this.Farma.Location = new System.Drawing.Point(447, 124);
            this.Farma.Name = "Farma";
            this.Farma.Size = new System.Drawing.Size(206, 248);
            this.Farma.TabIndex = 2;
            this.Farma.Text = "Farma";
            this.Farma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Farma.UseVisualStyleBackColor = false;
            this.Farma.Click += new System.EventHandler(this.Farma_Click);
            // 
            // Dom
            // 
            this.Dom.BackColor = System.Drawing.Color.Transparent;
            this.Dom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dom.Font = new System.Drawing.Font("Montserrat Subrayada", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dom.ForeColor = System.Drawing.Color.Wheat;
            this.Dom.Location = new System.Drawing.Point(704, 259);
            this.Dom.Name = "Dom";
            this.Dom.Size = new System.Drawing.Size(251, 262);
            this.Dom.TabIndex = 3;
            this.Dom.Text = "Dom";
            this.Dom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Dom.UseVisualStyleBackColor = false;
            this.Dom.Click += new System.EventHandler(this.Dom_Click);
            // 
            // Kopalnia
            // 
            this.Kopalnia.BackColor = System.Drawing.Color.Transparent;
            this.Kopalnia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Kopalnia.Font = new System.Drawing.Font("Montserrat Subrayada", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kopalnia.ForeColor = System.Drawing.Color.Wheat;
            this.Kopalnia.Location = new System.Drawing.Point(1017, 424);
            this.Kopalnia.Name = "Kopalnia";
            this.Kopalnia.Size = new System.Drawing.Size(233, 222);
            this.Kopalnia.TabIndex = 4;
            this.Kopalnia.Text = "Kopalnia";
            this.Kopalnia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Kopalnia.UseVisualStyleBackColor = false;
            this.Kopalnia.Click += new System.EventHandler(this.Kopalnia_Click);
            // 
            // Koniec_tury
            // 
            this.Koniec_tury.BackColor = System.Drawing.Color.Wheat;
            this.Koniec_tury.Font = new System.Drawing.Font("Montserrat Subrayada", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Koniec_tury.Location = new System.Drawing.Point(1039, 672);
            this.Koniec_tury.Name = "Koniec_tury";
            this.Koniec_tury.Size = new System.Drawing.Size(211, 97);
            this.Koniec_tury.TabIndex = 5;
            this.Koniec_tury.Text = "Następna tura";
            this.Koniec_tury.UseVisualStyleBackColor = false;
            this.Koniec_tury.Click += new System.EventHandler(this.Koniec_tury_Click);
            // 
            // GraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.Koniec_tury);
            this.Controls.Add(this.Kopalnia);
            this.Controls.Add(this.Dom);
            this.Controls.Add(this.Farma);
            this.Controls.Add(this.Tartak);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Village 1000";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Tartak;
        private System.Windows.Forms.Button Farma;
        private System.Windows.Forms.Button Dom;
        private System.Windows.Forms.Button Kopalnia;
        private System.Windows.Forms.Label Tura;
        private System.Windows.Forms.Button Jedzenie;
        private System.Windows.Forms.Button Drewno;
        private System.Windows.Forms.Button Zloto;
        private System.Windows.Forms.Label Populacja;
        public System.Windows.Forms.Button Koniec_tury;
    }
}