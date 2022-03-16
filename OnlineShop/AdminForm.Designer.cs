namespace OnlineShop
{
    partial class AdminForm
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
            this.dgvProdukte = new System.Windows.Forms.DataGridView();
            this.btn_hinzufuegen = new System.Windows.Forms.Button();
            this.tb_ProduktName = new System.Windows.Forms.TextBox();
            this.tbBeschreibung = new System.Windows.Forms.TextBox();
            this.tbPreis = new System.Windows.Forms.TextBox();
            this.cbKategorie = new System.Windows.Forms.ComboBox();
            this.picBild = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_loeschen = new System.Windows.Forms.Button();
            this.btn_bearbeiten = new System.Windows.Forms.Button();
            this.btn_Hochladen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btn_Datenleeren = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBild)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdukte
            // 
            this.dgvProdukte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukte.Location = new System.Drawing.Point(12, 20);
            this.dgvProdukte.Name = "dgvProdukte";
            this.dgvProdukte.Size = new System.Drawing.Size(711, 328);
            this.dgvProdukte.TabIndex = 0;
            this.dgvProdukte.SelectionChanged += new System.EventHandler(this.dgvProdukte_SelectionChanged);
            // 
            // btn_hinzufuegen
            // 
            this.btn_hinzufuegen.Location = new System.Drawing.Point(976, 310);
            this.btn_hinzufuegen.Name = "btn_hinzufuegen";
            this.btn_hinzufuegen.Size = new System.Drawing.Size(100, 23);
            this.btn_hinzufuegen.TabIndex = 1;
            this.btn_hinzufuegen.Text = "Hinzufügen";
            this.btn_hinzufuegen.UseVisualStyleBackColor = true;
            this.btn_hinzufuegen.Click += new System.EventHandler(this.btn_hinzufuegen_Click);
            // 
            // tb_ProduktName
            // 
            this.tb_ProduktName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ProduktName.Location = new System.Drawing.Point(918, 50);
            this.tb_ProduktName.Name = "tb_ProduktName";
            this.tb_ProduktName.Size = new System.Drawing.Size(158, 24);
            this.tb_ProduktName.TabIndex = 2;
            // 
            // tbBeschreibung
            // 
            this.tbBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeschreibung.Location = new System.Drawing.Point(918, 80);
            this.tbBeschreibung.Name = "tbBeschreibung";
            this.tbBeschreibung.Size = new System.Drawing.Size(158, 24);
            this.tbBeschreibung.TabIndex = 3;
            // 
            // tbPreis
            // 
            this.tbPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreis.Location = new System.Drawing.Point(918, 110);
            this.tbPreis.Name = "tbPreis";
            this.tbPreis.Size = new System.Drawing.Size(158, 24);
            this.tbPreis.TabIndex = 4;
            // 
            // cbKategorie
            // 
            this.cbKategorie.FormattingEnabled = true;
            this.cbKategorie.Location = new System.Drawing.Point(918, 149);
            this.cbKategorie.Name = "cbKategorie";
            this.cbKategorie.Size = new System.Drawing.Size(158, 21);
            this.cbKategorie.TabIndex = 5;
            // 
            // picBild
            // 
            this.picBild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBild.Location = new System.Drawing.Point(976, 195);
            this.picBild.Name = "picBild";
            this.picBild.Size = new System.Drawing.Size(100, 50);
            this.picBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBild.TabIndex = 6;
            this.picBild.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(804, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Produkt_Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(804, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Beschreibung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(804, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Preis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(804, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kategorie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(804, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bild";
            // 
            // btn_loeschen
            // 
            this.btn_loeschen.Location = new System.Drawing.Point(847, 310);
            this.btn_loeschen.Name = "btn_loeschen";
            this.btn_loeschen.Size = new System.Drawing.Size(100, 23);
            this.btn_loeschen.TabIndex = 14;
            this.btn_loeschen.Text = "Löschen";
            this.btn_loeschen.UseVisualStyleBackColor = true;
            this.btn_loeschen.Click += new System.EventHandler(this.btn_loeschen_Click);
            // 
            // btn_bearbeiten
            // 
            this.btn_bearbeiten.Location = new System.Drawing.Point(976, 368);
            this.btn_bearbeiten.Name = "btn_bearbeiten";
            this.btn_bearbeiten.Size = new System.Drawing.Size(100, 23);
            this.btn_bearbeiten.TabIndex = 15;
            this.btn_bearbeiten.Text = "Bearbeiten";
            this.btn_bearbeiten.UseVisualStyleBackColor = true;
            this.btn_bearbeiten.Click += new System.EventHandler(this.btn_bearbeiten_Click);
            // 
            // btn_Hochladen
            // 
            this.btn_Hochladen.Location = new System.Drawing.Point(847, 368);
            this.btn_Hochladen.Name = "btn_Hochladen";
            this.btn_Hochladen.Size = new System.Drawing.Size(100, 23);
            this.btn_Hochladen.TabIndex = 16;
            this.btn_Hochladen.Text = "Bild Hochladen";
            this.btn_Hochladen.UseVisualStyleBackColor = true;
            this.btn_Hochladen.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(804, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(918, 20);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(158, 24);
            this.tbID.TabIndex = 17;
            // 
            // btn_Datenleeren
            // 
            this.btn_Datenleeren.Location = new System.Drawing.Point(976, 424);
            this.btn_Datenleeren.Name = "btn_Datenleeren";
            this.btn_Datenleeren.Size = new System.Drawing.Size(100, 23);
            this.btn_Datenleeren.TabIndex = 19;
            this.btn_Datenleeren.Text = "Daten Leeren";
            this.btn_Datenleeren.UseVisualStyleBackColor = true;
            this.btn_Datenleeren.Click += new System.EventHandler(this.btn_Datenleeren_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 518);
            this.Controls.Add(this.btn_Datenleeren);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btn_Hochladen);
            this.Controls.Add(this.btn_bearbeiten);
            this.Controls.Add(this.btn_loeschen);
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.dgvProdukte);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdukte;
        private System.Windows.Forms.Button btn_hinzufuegen;
        private System.Windows.Forms.TextBox tb_ProduktName;
        private System.Windows.Forms.TextBox tbBeschreibung;
        private System.Windows.Forms.TextBox tbPreis;
        private System.Windows.Forms.ComboBox cbKategorie;
        private System.Windows.Forms.PictureBox picBild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_loeschen;
        private System.Windows.Forms.Button btn_bearbeiten;
        private System.Windows.Forms.Button btn_Hochladen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btn_Datenleeren;
    }
}