namespace OnlineShop
{
    partial class Bestellungen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bestellungen));
            this.dgvBestllungen = new System.Windows.Forms.DataGridView();
            this.tbSuche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.tbBerechnen = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbzuruck = new System.Windows.Forms.PictureBox();
            this.btnAbmelden = new System.Windows.Forms.Button();
            this.btnKundenDaten = new System.Windows.Forms.Button();
            this.btnProdukteVerwalten = new System.Windows.Forms.Button();
            this.btnBestellungen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestllungen)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbzuruck)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBestllungen
            // 
            this.dgvBestllungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestllungen.Location = new System.Drawing.Point(3, 107);
            this.dgvBestllungen.Name = "dgvBestllungen";
            this.dgvBestllungen.Size = new System.Drawing.Size(1419, 436);
            this.dgvBestllungen.TabIndex = 0;
            // 
            // tbSuche
            // 
            this.tbSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuche.Location = new System.Drawing.Point(234, 62);
            this.tbSuche.Name = "tbSuche";
            this.tbSuche.Size = new System.Drawing.Size(890, 24);
            this.tbSuche.TabIndex = 1;
            this.tbSuche.TextChanged += new System.EventHandler(this.tbSuche_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Suchen";
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBerechnen.Location = new System.Drawing.Point(305, 549);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(751, 33);
            this.btnBerechnen.TabIndex = 5;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // tbBerechnen
            // 
            this.tbBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBerechnen.Location = new System.Drawing.Point(1255, 549);
            this.tbBerechnen.Name = "tbBerechnen";
            this.tbBerechnen.ReadOnly = true;
            this.tbBerechnen.Size = new System.Drawing.Size(167, 24);
            this.tbBerechnen.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.pbzuruck);
            this.panel1.Controls.Add(this.btnAbmelden);
            this.panel1.Controls.Add(this.btnKundenDaten);
            this.panel1.Controls.Add(this.btnProdukteVerwalten);
            this.panel1.Controls.Add(this.btnBestellungen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1425, 46);
            this.panel1.TabIndex = 26;
            // 
            // pbzuruck
            // 
            this.pbzuruck.Image = ((System.Drawing.Image)(resources.GetObject("pbzuruck.Image")));
            this.pbzuruck.Location = new System.Drawing.Point(3, 6);
            this.pbzuruck.Name = "pbzuruck";
            this.pbzuruck.Size = new System.Drawing.Size(40, 37);
            this.pbzuruck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbzuruck.TabIndex = 41;
            this.pbzuruck.TabStop = false;
            this.pbzuruck.Click += new System.EventHandler(this.pbzuruck_Click);
            // 
            // btnAbmelden
            // 
            this.btnAbmelden.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAbmelden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbmelden.Location = new System.Drawing.Point(1312, 7);
            this.btnAbmelden.Name = "btnAbmelden";
            this.btnAbmelden.Size = new System.Drawing.Size(101, 31);
            this.btnAbmelden.TabIndex = 24;
            this.btnAbmelden.Text = "Abmelden";
            this.btnAbmelden.UseVisualStyleBackColor = false;
            this.btnAbmelden.Click += new System.EventHandler(this.btnAbmelden_Click);
            // 
            // btnKundenDaten
            // 
            this.btnKundenDaten.BackColor = System.Drawing.Color.Navy;
            this.btnKundenDaten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKundenDaten.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btnKundenDaten.ForeColor = System.Drawing.Color.White;
            this.btnKundenDaten.Location = new System.Drawing.Point(823, 6);
            this.btnKundenDaten.Name = "btnKundenDaten";
            this.btnKundenDaten.Size = new System.Drawing.Size(216, 31);
            this.btnKundenDaten.TabIndex = 4;
            this.btnKundenDaten.Text = "Kunden Daten";
            this.btnKundenDaten.UseVisualStyleBackColor = false;
            this.btnKundenDaten.Click += new System.EventHandler(this.btnKundenDaten_Click);
            // 
            // btnProdukteVerwalten
            // 
            this.btnProdukteVerwalten.BackColor = System.Drawing.Color.Navy;
            this.btnProdukteVerwalten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdukteVerwalten.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btnProdukteVerwalten.ForeColor = System.Drawing.Color.White;
            this.btnProdukteVerwalten.Location = new System.Drawing.Point(305, 7);
            this.btnProdukteVerwalten.Name = "btnProdukteVerwalten";
            this.btnProdukteVerwalten.Size = new System.Drawing.Size(239, 31);
            this.btnProdukteVerwalten.TabIndex = 3;
            this.btnProdukteVerwalten.Text = "Produkte Verwaltung";
            this.btnProdukteVerwalten.UseVisualStyleBackColor = false;
            this.btnProdukteVerwalten.Click += new System.EventHandler(this.btnProdukteVerwalten_Click);
            // 
            // btnBestellungen
            // 
            this.btnBestellungen.BackColor = System.Drawing.Color.Navy;
            this.btnBestellungen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBestellungen.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btnBestellungen.ForeColor = System.Drawing.Color.White;
            this.btnBestellungen.Location = new System.Drawing.Point(582, 7);
            this.btnBestellungen.Name = "btnBestellungen";
            this.btnBestellungen.Size = new System.Drawing.Size(192, 31);
            this.btnBestellungen.TabIndex = 2;
            this.btnBestellungen.Text = "Bestellungen";
            this.btnBestellungen.UseVisualStyleBackColor = false;
            // 
            // Bestellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineShop.Properties.Resources._230_2301638_lilac;
            this.ClientSize = new System.Drawing.Size(1425, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.tbBerechnen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSuche);
            this.Controls.Add(this.dgvBestllungen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Bestellungen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestellungen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestllungen)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbzuruck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBestllungen;
        private System.Windows.Forms.TextBox tbSuche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.TextBox tbBerechnen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbzuruck;
        private System.Windows.Forms.Button btnAbmelden;
        private System.Windows.Forms.Button btnKundenDaten;
        private System.Windows.Forms.Button btnProdukteVerwalten;
        private System.Windows.Forms.Button btnBestellungen;
    }
}