namespace OnlineShop
{
    partial class WarenKorb
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
            this.dgvBestellungen = new System.Windows.Forms.DataGridView();
            this.btnBestellen = new System.Windows.Forms.Button();
            this.tbBerechnen = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.Produkt_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bestellung_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kunde_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnloeschen = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestellungen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBestellungen
            // 
            this.dgvBestellungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestellungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produkt_id,
            this.Bestellung_ID,
            this.Kunde_ID,
            this.Bezeichnung,
            this.Menge,
            this.preis,
            this.Datum,
            this.btnloeschen});
            this.dgvBestellungen.Location = new System.Drawing.Point(155, 12);
            this.dgvBestellungen.Name = "dgvBestellungen";
            this.dgvBestellungen.ReadOnly = true;
            this.dgvBestellungen.Size = new System.Drawing.Size(843, 276);
            this.dgvBestellungen.TabIndex = 0;
            this.dgvBestellungen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBestellungen_CellContentClick);
            // 
            // btnBestellen
            // 
            this.btnBestellen.Enabled = false;
            this.btnBestellen.Location = new System.Drawing.Point(274, 371);
            this.btnBestellen.Name = "btnBestellen";
            this.btnBestellen.Size = new System.Drawing.Size(526, 23);
            this.btnBestellen.TabIndex = 1;
            this.btnBestellen.Text = "Bestellen";
            this.btnBestellen.UseVisualStyleBackColor = true;
            this.btnBestellen.Click += new System.EventHandler(this.btnBestellen_Click);
            // 
            // tbBerechnen
            // 
            this.tbBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBerechnen.Location = new System.Drawing.Point(700, 294);
            this.tbBerechnen.Name = "tbBerechnen";
            this.tbBerechnen.ReadOnly = true;
            this.tbBerechnen.Size = new System.Drawing.Size(100, 24);
            this.tbBerechnen.TabIndex = 2;
            this.tbBerechnen.TextChanged += new System.EventHandler(this.tbBerechnen_TextChanged);
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBerechnen.Location = new System.Drawing.Point(567, 295);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(94, 23);
            this.btnBerechnen.TabIndex = 3;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Produkt_id
            // 
            this.Produkt_id.DataPropertyName = "Produkt_id";
            this.Produkt_id.HeaderText = "Produkt_id";
            this.Produkt_id.Name = "Produkt_id";
            this.Produkt_id.ReadOnly = true;
            // 
            // Bestellung_ID
            // 
            this.Bestellung_ID.DataPropertyName = "Bestellung_ID";
            this.Bestellung_ID.HeaderText = "Bestellung_ID";
            this.Bestellung_ID.Name = "Bestellung_ID";
            this.Bestellung_ID.ReadOnly = true;
            // 
            // Kunde_ID
            // 
            this.Kunde_ID.DataPropertyName = "Kunde_ID";
            this.Kunde_ID.HeaderText = "Kunde_ID";
            this.Kunde_ID.Name = "Kunde_ID";
            this.Kunde_ID.ReadOnly = true;
            // 
            // Bezeichnung
            // 
            this.Bezeichnung.DataPropertyName = "Bezeichnung";
            this.Bezeichnung.HeaderText = "Bezeichnung";
            this.Bezeichnung.Name = "Bezeichnung";
            this.Bezeichnung.ReadOnly = true;
            // 
            // Menge
            // 
            this.Menge.DataPropertyName = "Menge";
            this.Menge.HeaderText = "Menge";
            this.Menge.Name = "Menge";
            this.Menge.ReadOnly = true;
            // 
            // preis
            // 
            this.preis.DataPropertyName = "preis";
            this.preis.HeaderText = "preis";
            this.preis.Name = "preis";
            this.preis.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // btnloeschen
            // 
            this.btnloeschen.HeaderText = "";
            this.btnloeschen.Name = "btnloeschen";
            this.btnloeschen.ReadOnly = true;
            this.btnloeschen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnloeschen.Text = "löschen";
            this.btnloeschen.UseColumnTextForButtonValue = true;
            // 
            // WarenKorb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 594);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.tbBerechnen);
            this.Controls.Add(this.btnBestellen);
            this.Controls.Add(this.dgvBestellungen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WarenKorb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarenKorb";
            this.Load += new System.EventHandler(this.WarenKorb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestellungen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBestellungen;
        private System.Windows.Forms.Button btnBestellen;
        private System.Windows.Forms.TextBox tbBerechnen;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produkt_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bestellung_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kunde_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bezeichnung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menge;
        private System.Windows.Forms.DataGridViewTextBoxColumn preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewButtonColumn btnloeschen;
    }
}