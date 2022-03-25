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
            this.tbfrage = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbmelden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_KundenDaten
            // 
            this.btn_KundenDaten.BackColor = System.Drawing.Color.Navy;
            this.btn_KundenDaten.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KundenDaten.ForeColor = System.Drawing.Color.White;
            this.btn_KundenDaten.Location = new System.Drawing.Point(182, 89);
            this.btn_KundenDaten.Name = "btn_KundenDaten";
            this.btn_KundenDaten.Size = new System.Drawing.Size(198, 33);
            this.btn_KundenDaten.TabIndex = 0;
            this.btn_KundenDaten.Text = "Kunden Daten";
            this.btn_KundenDaten.UseVisualStyleBackColor = false;
            this.btn_KundenDaten.Click += new System.EventHandler(this.btn_KundenDaten_Click);
            // 
            // btnBestellungen
            // 
            this.btnBestellungen.BackColor = System.Drawing.Color.Navy;
            this.btnBestellungen.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestellungen.ForeColor = System.Drawing.Color.White;
            this.btnBestellungen.Location = new System.Drawing.Point(182, 140);
            this.btnBestellungen.Name = "btnBestellungen";
            this.btnBestellungen.Size = new System.Drawing.Size(198, 33);
            this.btnBestellungen.TabIndex = 1;
            this.btnBestellungen.Text = "Bestellungen";
            this.btnBestellungen.UseVisualStyleBackColor = false;
            this.btnBestellungen.Click += new System.EventHandler(this.btnBestellungen_Click);
            // 
            // btnProdukteVerwalten
            // 
            this.btnProdukteVerwalten.BackColor = System.Drawing.Color.Navy;
            this.btnProdukteVerwalten.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdukteVerwalten.ForeColor = System.Drawing.Color.White;
            this.btnProdukteVerwalten.Location = new System.Drawing.Point(182, 192);
            this.btnProdukteVerwalten.Name = "btnProdukteVerwalten";
            this.btnProdukteVerwalten.Size = new System.Drawing.Size(198, 33);
            this.btnProdukteVerwalten.TabIndex = 2;
            this.btnProdukteVerwalten.Text = "Produkte Verwalten";
            this.btnProdukteVerwalten.UseVisualStyleBackColor = false;
            this.btnProdukteVerwalten.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbfrage
            // 
            this.tbfrage.AutoSize = true;
            this.tbfrage.BackColor = System.Drawing.Color.Pink;
            this.tbfrage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbfrage.Font = new System.Drawing.Font("MingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfrage.Location = new System.Drawing.Point(115, 29);
            this.tbfrage.Name = "tbfrage";
            this.tbfrage.Size = new System.Drawing.Size(353, 23);
            this.tbfrage.TabIndex = 3;
            this.tbfrage.Text = "      Wo wollen Sie hin !      ";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Thistle;
            this.btnExit.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(182, 296);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbmelden
            // 
            this.btnAbmelden.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAbmelden.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbmelden.ForeColor = System.Drawing.Color.Black;
            this.btnAbmelden.Location = new System.Drawing.Point(12, 296);
            this.btnAbmelden.Name = "btnAbmelden";
            this.btnAbmelden.Size = new System.Drawing.Size(84, 33);
            this.btnAbmelden.TabIndex = 5;
            this.btnAbmelden.Text = "Abmelden";
            this.btnAbmelden.UseVisualStyleBackColor = false;
            this.btnAbmelden.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminStartSeite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineShop.Properties.Resources._230_2301638_lilac;
            this.ClientSize = new System.Drawing.Size(570, 341);
            this.Controls.Add(this.btnAbmelden);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbfrage);
            this.Controls.Add(this.btnProdukteVerwalten);
            this.Controls.Add(this.btnBestellungen);
            this.Controls.Add(this.btn_KundenDaten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminStartSeite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminStartSeite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_KundenDaten;
        private System.Windows.Forms.Button btnBestellungen;
        private System.Windows.Forms.Button btnProdukteVerwalten;
        private System.Windows.Forms.Label tbfrage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbmelden;
    }
}