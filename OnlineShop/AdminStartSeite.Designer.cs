namespace OnlineShop
{
    partial class AdminStartSeite
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
            this.btn_KundenDaten = new System.Windows.Forms.Button();
            this.btnBestellungen = new System.Windows.Forms.Button();
            this.btnProdukteVerwalten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_KundenDaten
            // 
            this.btn_KundenDaten.Location = new System.Drawing.Point(174, 26);
            this.btn_KundenDaten.Name = "btn_KundenDaten";
            this.btn_KundenDaten.Size = new System.Drawing.Size(125, 23);
            this.btn_KundenDaten.TabIndex = 0;
            this.btn_KundenDaten.Text = "Kunden Daten";
            this.btn_KundenDaten.UseVisualStyleBackColor = true;
            this.btn_KundenDaten.Click += new System.EventHandler(this.btn_KundenDaten_Click);
            // 
            // btnBestellungen
            // 
            this.btnBestellungen.Location = new System.Drawing.Point(174, 69);
            this.btnBestellungen.Name = "btnBestellungen";
            this.btnBestellungen.Size = new System.Drawing.Size(125, 23);
            this.btnBestellungen.TabIndex = 1;
            this.btnBestellungen.Text = "Bestellungen";
            this.btnBestellungen.UseVisualStyleBackColor = true;
            this.btnBestellungen.Click += new System.EventHandler(this.btnBestellungen_Click);
            // 
            // btnProdukteVerwalten
            // 
            this.btnProdukteVerwalten.Location = new System.Drawing.Point(174, 119);
            this.btnProdukteVerwalten.Name = "btnProdukteVerwalten";
            this.btnProdukteVerwalten.Size = new System.Drawing.Size(125, 23);
            this.btnProdukteVerwalten.TabIndex = 2;
            this.btnProdukteVerwalten.Text = "Produkte Verwalten";
            this.btnProdukteVerwalten.UseVisualStyleBackColor = true;
            this.btnProdukteVerwalten.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminStartSeite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 594);
            this.Controls.Add(this.btnProdukteVerwalten);
            this.Controls.Add(this.btnBestellungen);
            this.Controls.Add(this.btn_KundenDaten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminStartSeite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminStartSeite";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_KundenDaten;
        private System.Windows.Forms.Button btnBestellungen;
        private System.Windows.Forms.Button btnProdukteVerwalten;
    }
}