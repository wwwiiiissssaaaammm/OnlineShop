namespace OnlineShop
{
    partial class produkteverwalten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produkteverwalten));
            this.dgvProdukte = new System.Windows.Forms.DataGridView();
            this.tbSuche = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAbmelden = new System.Windows.Forms.Button();
            this.btn_Datenleeren = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btn_Hochladen = new System.Windows.Forms.Button();
            this.btn_bearbeiten = new System.Windows.Forms.Button();
            this.btn_loeschen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKategorie = new System.Windows.Forms.ComboBox();
            this.tbPreis = new System.Windows.Forms.TextBox();
            this.tbBeschreibung = new System.Windows.Forms.TextBox();
            this.tb_ProduktName = new System.Windows.Forms.TextBox();
            this.btn_hinzufuegen = new System.Windows.Forms.Button();
            this.pbzuruck = new System.Windows.Forms.PictureBox();
            this.picBild = new System.Windows.Forms.PictureBox();
            this.btnKundenDaten = new System.Windows.Forms.Button();
            this.btnProdukteVerwalten = new System.Windows.Forms.Button();
            this.btnBestellungen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukte)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbzuruck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBild)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdukte
            // 
            this.dgvProdukte.AllowUserToAddRows = false;
            this.dgvProdukte.AllowUserToDeleteRows = false;
            this.dgvProdukte.AllowUserToResizeColumns = false;
            this.dgvProdukte.AllowUserToResizeRows = false;
            this.dgvProdukte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukte.Location = new System.Drawing.Point(508, 112);
            this.dgvProdukte.Name = "dgvProdukte";
            this.dgvProdukte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdukte.Size = new System.Drawing.Size(905, 470);
            this.dgvProdukte.TabIndex = 0;
            this.dgvProdukte.SelectionChanged += new System.EventHandler(this.dgvProdukte_SelectionChanged);
            // 
            // tbSuche
            // 
            this.tbSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuche.Location = new System.Drawing.Point(347, 62);
            this.tbSuche.Name = "tbSuche";
            this.tbSuche.Size = new System.Drawing.Size(650, 24);
            this.tbSuche.TabIndex = 20;
            this.tbSuche.TextChanged += new System.EventHandler(this.tbSuche_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(283, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Suchen";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnKundenDaten);
            this.panel1.Controls.Add(this.btnProdukteVerwalten);
            this.panel1.Controls.Add(this.btnBestellungen);
            this.panel1.Controls.Add(this.pbzuruck);
            this.panel1.Controls.Add(this.btnAbmelden);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1425, 46);
            this.panel1.TabIndex = 23;
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
            // btn_Datenleeren
            // 
            this.btn_Datenleeren.BackColor = System.Drawing.Color.Thistle;
            this.btn_Datenleeren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Datenleeren.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Datenleeren.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Datenleeren.Location = new System.Drawing.Point(164, 568);
            this.btn_Datenleeren.Name = "btn_Datenleeren";
            this.btn_Datenleeren.Size = new System.Drawing.Size(198, 23);
            this.btn_Datenleeren.TabIndex = 40;
            this.btn_Datenleeren.Text = "Daten Leeren";
            this.btn_Datenleeren.UseVisualStyleBackColor = false;
            this.btn_Datenleeren.Click += new System.EventHandler(this.btn_Datenleeren_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Produkt ID";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(12, 139);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(251, 24);
            this.tbID.TabIndex = 38;
            // 
            // btn_Hochladen
            // 
            this.btn_Hochladen.BackColor = System.Drawing.Color.Thistle;
            this.btn_Hochladen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hochladen.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hochladen.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Hochladen.Location = new System.Drawing.Point(331, 519);
            this.btn_Hochladen.Name = "btn_Hochladen";
            this.btn_Hochladen.Size = new System.Drawing.Size(141, 23);
            this.btn_Hochladen.TabIndex = 37;
            this.btn_Hochladen.Text = "Bild Hochladen";
            this.btn_Hochladen.UseVisualStyleBackColor = false;
            this.btn_Hochladen.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_bearbeiten
            // 
            this.btn_bearbeiten.BackColor = System.Drawing.Color.Thistle;
            this.btn_bearbeiten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bearbeiten.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btn_bearbeiten.ForeColor = System.Drawing.Color.Indigo;
            this.btn_bearbeiten.Location = new System.Drawing.Point(332, 264);
            this.btn_bearbeiten.Name = "btn_bearbeiten";
            this.btn_bearbeiten.Size = new System.Drawing.Size(161, 31);
            this.btn_bearbeiten.TabIndex = 36;
            this.btn_bearbeiten.Text = "Bearbeiten";
            this.btn_bearbeiten.UseVisualStyleBackColor = false;
            this.btn_bearbeiten.Click += new System.EventHandler(this.btn_bearbeiten_Click);
            // 
            // btn_loeschen
            // 
            this.btn_loeschen.BackColor = System.Drawing.Color.Thistle;
            this.btn_loeschen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loeschen.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btn_loeschen.ForeColor = System.Drawing.Color.Indigo;
            this.btn_loeschen.Location = new System.Drawing.Point(332, 335);
            this.btn_loeschen.Name = "btn_loeschen";
            this.btn_loeschen.Size = new System.Drawing.Size(161, 31);
            this.btn_loeschen.TabIndex = 35;
            this.btn_loeschen.Text = "Löschen";
            this.btn_loeschen.UseVisualStyleBackColor = false;
            this.btn_loeschen.Click += new System.EventHandler(this.btn_loeschen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Kategorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Preis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Beschreibung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Produkt_Name";
            // 
            // cbKategorie
            // 
            this.cbKategorie.FormattingEnabled = true;
            this.cbKategorie.Location = new System.Drawing.Point(12, 345);
            this.cbKategorie.Name = "cbKategorie";
            this.cbKategorie.Size = new System.Drawing.Size(251, 21);
            this.cbKategorie.TabIndex = 28;
            // 
            // tbPreis
            // 
            this.tbPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreis.Location = new System.Drawing.Point(12, 271);
            this.tbPreis.Name = "tbPreis";
            this.tbPreis.Size = new System.Drawing.Size(251, 24);
            this.tbPreis.TabIndex = 27;
            // 
            // tbBeschreibung
            // 
            this.tbBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeschreibung.Location = new System.Drawing.Point(12, 419);
            this.tbBeschreibung.Multiline = true;
            this.tbBeschreibung.Name = "tbBeschreibung";
            this.tbBeschreibung.Size = new System.Drawing.Size(251, 94);
            this.tbBeschreibung.TabIndex = 26;
            // 
            // tb_ProduktName
            // 
            this.tb_ProduktName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ProduktName.Location = new System.Drawing.Point(12, 205);
            this.tb_ProduktName.Name = "tb_ProduktName";
            this.tb_ProduktName.Size = new System.Drawing.Size(251, 24);
            this.tb_ProduktName.TabIndex = 25;
            // 
            // btn_hinzufuegen
            // 
            this.btn_hinzufuegen.BackColor = System.Drawing.Color.Thistle;
            this.btn_hinzufuegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hinzufuegen.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btn_hinzufuegen.ForeColor = System.Drawing.Color.Indigo;
            this.btn_hinzufuegen.Location = new System.Drawing.Point(332, 198);
            this.btn_hinzufuegen.Name = "btn_hinzufuegen";
            this.btn_hinzufuegen.Size = new System.Drawing.Size(170, 31);
            this.btn_hinzufuegen.TabIndex = 24;
            this.btn_hinzufuegen.Text = "Hinzufügen";
            this.btn_hinzufuegen.UseVisualStyleBackColor = false;
            this.btn_hinzufuegen.Click += new System.EventHandler(this.btn_hinzufuegen_Click);
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
            // picBild
            // 
            this.picBild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBild.Location = new System.Drawing.Point(312, 419);
            this.picBild.Name = "picBild";
            this.picBild.Size = new System.Drawing.Size(175, 94);
            this.picBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBild.TabIndex = 29;
            this.picBild.TabStop = false;
            // 
            // btnKundenDaten
            // 
            this.btnKundenDaten.BackColor = System.Drawing.Color.Navy;
            this.btnKundenDaten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKundenDaten.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btnKundenDaten.ForeColor = System.Drawing.Color.White;
            this.btnKundenDaten.Location = new System.Drawing.Point(822, 6);
            this.btnKundenDaten.Name = "btnKundenDaten";
            this.btnKundenDaten.Size = new System.Drawing.Size(216, 31);
            this.btnKundenDaten.TabIndex = 44;
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
            this.btnProdukteVerwalten.Location = new System.Drawing.Point(304, 7);
            this.btnProdukteVerwalten.Name = "btnProdukteVerwalten";
            this.btnProdukteVerwalten.Size = new System.Drawing.Size(239, 31);
            this.btnProdukteVerwalten.TabIndex = 43;
            this.btnProdukteVerwalten.Text = "Produkte Verwaltung";
            this.btnProdukteVerwalten.UseVisualStyleBackColor = false;
            // 
            // btnBestellungen
            // 
            this.btnBestellungen.BackColor = System.Drawing.Color.Navy;
            this.btnBestellungen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBestellungen.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btnBestellungen.ForeColor = System.Drawing.Color.White;
            this.btnBestellungen.Location = new System.Drawing.Point(581, 7);
            this.btnBestellungen.Name = "btnBestellungen";
            this.btnBestellungen.Size = new System.Drawing.Size(192, 31);
            this.btnBestellungen.TabIndex = 42;
            this.btnBestellungen.Text = "Bestellungen";
            this.btnBestellungen.UseVisualStyleBackColor = false;
            this.btnBestellungen.Click += new System.EventHandler(this.btnBestellungen_Click);
            // 
            // produkteverwalten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineShop.Properties.Resources._230_2301638_lilac;
            this.ClientSize = new System.Drawing.Size(1425, 594);
            this.Controls.Add(this.btn_Datenleeren);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btn_Hochladen);
            this.Controls.Add(this.btn_bearbeiten);
            this.Controls.Add(this.btn_loeschen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBild);
            this.Controls.Add(this.cbKategorie);
            this.Controls.Add(this.tbPreis);
            this.Controls.Add(this.tbBeschreibung);
            this.Controls.Add(this.tb_ProduktName);
            this.Controls.Add(this.btn_hinzufuegen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSuche);
            this.Controls.Add(this.dgvProdukte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "produkteverwalten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkt Verwalten";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukte)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbzuruck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdukte;
        private System.Windows.Forms.TextBox tbSuche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbzuruck;
        private System.Windows.Forms.Button btnAbmelden;
        private System.Windows.Forms.Button btn_Datenleeren;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btn_Hochladen;
        private System.Windows.Forms.Button btn_bearbeiten;
        private System.Windows.Forms.Button btn_loeschen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKategorie;
        private System.Windows.Forms.TextBox tbPreis;
        private System.Windows.Forms.TextBox tbBeschreibung;
        private System.Windows.Forms.TextBox tb_ProduktName;
        private System.Windows.Forms.Button btn_hinzufuegen;
        private System.Windows.Forms.PictureBox picBild;
        private System.Windows.Forms.Button btnKundenDaten;
        private System.Windows.Forms.Button btnProdukteVerwalten;
        private System.Windows.Forms.Button btnBestellungen;
    }
}