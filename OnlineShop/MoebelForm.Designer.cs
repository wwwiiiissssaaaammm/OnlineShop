namespace OnlineShop
{
    partial class MoebelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoebelForm));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvMoebel = new System.Windows.Forms.DataGridView();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbBestellung = new System.Windows.Forms.Button();
            this.tbAbmelden = new System.Windows.Forms.Button();
            this.btnMeineDaten = new System.Windows.Forms.Button();
            this.btnWarenkorb = new System.Windows.Forms.Button();
            this.tbGeraete = new System.Windows.Forms.Button();
            this.tbMoebel = new System.Windows.Forms.Button();
            this.tbKleidung = new System.Windows.Forms.Button();
            this.tbSuche = new System.Windows.Forms.TextBox();
            this.btnzuruck = new System.Windows.Forms.Button();
            this.tbstartseite = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProduktName = new System.Windows.Forms.TextBox();
            this.tbBeschreibung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPreis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSummePreis = new System.Windows.Forms.TextBox();
            this.countMenge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoebel)).BeginInit();
            this.sideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countMenge)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1200, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 27);
            this.button2.TabIndex = 31;
            this.button2.Text = "Speichern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1161, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 30);
            this.button1.TabIndex = 30;
            this.button1.Text = "Warenkorb";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvMoebel
            // 
            this.dgvMoebel.AllowUserToAddRows = false;
            this.dgvMoebel.AllowUserToDeleteRows = false;
            this.dgvMoebel.AllowUserToResizeColumns = false;
            this.dgvMoebel.AllowUserToResizeRows = false;
            this.dgvMoebel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoebel.Location = new System.Drawing.Point(155, 45);
            this.dgvMoebel.MaximumSize = new System.Drawing.Size(966, 460);
            this.dgvMoebel.MinimumSize = new System.Drawing.Size(805, 372);
            this.dgvMoebel.Name = "dgvMoebel";
            this.dgvMoebel.ReadOnly = true;
            this.dgvMoebel.Size = new System.Drawing.Size(966, 460);
            this.dgvMoebel.TabIndex = 19;
            this.dgvMoebel.SelectionChanged += new System.EventHandler(this.dgvGeraete_SelectionChanged);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.Transparent;
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(234, 595);
            this.sideBar.MinimumSize = new System.Drawing.Size(63, 592);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(63, 594);
            this.sideBar.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 99);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(78, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Menü";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbstartseite);
            this.panel3.Controls.Add(this.tbBestellung);
            this.panel3.Controls.Add(this.tbAbmelden);
            this.panel3.Controls.Add(this.btnMeineDaten);
            this.panel3.Controls.Add(this.btnWarenkorb);
            this.panel3.Controls.Add(this.tbGeraete);
            this.panel3.Controls.Add(this.tbMoebel);
            this.panel3.Controls.Add(this.tbKleidung);
            this.panel3.Location = new System.Drawing.Point(0, 99);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 502);
            this.panel3.TabIndex = 4;
            // 
            // tbBestellung
            // 
            this.tbBestellung.BackColor = System.Drawing.Color.Gray;
            this.tbBestellung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbBestellung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbBestellung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbBestellung.Image = ((System.Drawing.Image)(resources.GetObject("tbBestellung.Image")));
            this.tbBestellung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbBestellung.Location = new System.Drawing.Point(2, 346);
            this.tbBestellung.Name = "tbBestellung";
            this.tbBestellung.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbBestellung.Size = new System.Drawing.Size(60, 30);
            this.tbBestellung.TabIndex = 62;
            this.tbBestellung.Text = "               Meine Bestellungen";
            this.tbBestellung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbBestellung.UseVisualStyleBackColor = false;
            // 
            // tbAbmelden
            // 
            this.tbAbmelden.BackColor = System.Drawing.Color.Gray;
            this.tbAbmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbAbmelden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbAbmelden.Image = ((System.Drawing.Image)(resources.GetObject("tbAbmelden.Image")));
            this.tbAbmelden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbAbmelden.Location = new System.Drawing.Point(3, 427);
            this.tbAbmelden.Name = "tbAbmelden";
            this.tbAbmelden.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbAbmelden.Size = new System.Drawing.Size(60, 30);
            this.tbAbmelden.TabIndex = 3;
            this.tbAbmelden.Text = "               Abmelden";
            this.tbAbmelden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbAbmelden.UseVisualStyleBackColor = false;
            this.tbAbmelden.Click += new System.EventHandler(this.tbAbmelden_Click);
            // 
            // btnMeineDaten
            // 
            this.btnMeineDaten.BackColor = System.Drawing.Color.Gray;
            this.btnMeineDaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeineDaten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMeineDaten.Image = ((System.Drawing.Image)(resources.GetObject("btnMeineDaten.Image")));
            this.btnMeineDaten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeineDaten.Location = new System.Drawing.Point(3, 12);
            this.btnMeineDaten.Name = "btnMeineDaten";
            this.btnMeineDaten.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMeineDaten.Size = new System.Drawing.Size(60, 30);
            this.btnMeineDaten.TabIndex = 1;
            this.btnMeineDaten.Text = "               Meine Daten";
            this.btnMeineDaten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeineDaten.UseVisualStyleBackColor = false;
            this.btnMeineDaten.Click += new System.EventHandler(this.btnMeineDaten_Click);
            // 
            // btnWarenkorb
            // 
            this.btnWarenkorb.BackColor = System.Drawing.Color.Gray;
            this.btnWarenkorb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarenkorb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWarenkorb.Image = ((System.Drawing.Image)(resources.GetObject("btnWarenkorb.Image")));
            this.btnWarenkorb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWarenkorb.Location = new System.Drawing.Point(2, 310);
            this.btnWarenkorb.Name = "btnWarenkorb";
            this.btnWarenkorb.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnWarenkorb.Size = new System.Drawing.Size(60, 30);
            this.btnWarenkorb.TabIndex = 5;
            this.btnWarenkorb.Text = "               Warenkorb";
            this.btnWarenkorb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWarenkorb.UseVisualStyleBackColor = false;
            this.btnWarenkorb.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbGeraete
            // 
            this.tbGeraete.BackColor = System.Drawing.Color.Gray;
            this.tbGeraete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbGeraete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbGeraete.Image = ((System.Drawing.Image)(resources.GetObject("tbGeraete.Image")));
            this.tbGeraete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbGeraete.Location = new System.Drawing.Point(3, 139);
            this.tbGeraete.Name = "tbGeraete";
            this.tbGeraete.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbGeraete.Size = new System.Drawing.Size(60, 30);
            this.tbGeraete.TabIndex = 1;
            this.tbGeraete.Text = "               Geräte";
            this.tbGeraete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbGeraete.UseVisualStyleBackColor = false;
            this.tbGeraete.Click += new System.EventHandler(this.tbGeraete_Click);
            // 
            // tbMoebel
            // 
            this.tbMoebel.BackColor = System.Drawing.Color.Gray;
            this.tbMoebel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbMoebel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbMoebel.Image = ((System.Drawing.Image)(resources.GetObject("tbMoebel.Image")));
            this.tbMoebel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMoebel.Location = new System.Drawing.Point(3, 180);
            this.tbMoebel.Name = "tbMoebel";
            this.tbMoebel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbMoebel.Size = new System.Drawing.Size(60, 30);
            this.tbMoebel.TabIndex = 2;
            this.tbMoebel.Text = "               Möbel";
            this.tbMoebel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMoebel.UseVisualStyleBackColor = false;
            this.tbMoebel.Click += new System.EventHandler(this.tbMoebel_Click);
            // 
            // tbKleidung
            // 
            this.tbKleidung.BackColor = System.Drawing.Color.Gray;
            this.tbKleidung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbKleidung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbKleidung.Image = ((System.Drawing.Image)(resources.GetObject("tbKleidung.Image")));
            this.tbKleidung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbKleidung.Location = new System.Drawing.Point(3, 221);
            this.tbKleidung.Name = "tbKleidung";
            this.tbKleidung.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbKleidung.Size = new System.Drawing.Size(60, 30);
            this.tbKleidung.TabIndex = 3;
            this.tbKleidung.Text = "               Kleidung";
            this.tbKleidung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbKleidung.UseVisualStyleBackColor = false;
            this.tbKleidung.Click += new System.EventHandler(this.tbKleidung_Click);
            // 
            // tbSuche
            // 
            this.tbSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuche.Location = new System.Drawing.Point(279, 12);
            this.tbSuche.Name = "tbSuche";
            this.tbSuche.Size = new System.Drawing.Size(750, 24);
            this.tbSuche.TabIndex = 47;
            this.tbSuche.TextChanged += new System.EventHandler(this.tbSuche_TextChanged);
            // 
            // btnzuruck
            // 
            this.btnzuruck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnzuruck.Location = new System.Drawing.Point(557, 524);
            this.btnzuruck.Name = "btnzuruck";
            this.btnzuruck.Size = new System.Drawing.Size(177, 32);
            this.btnzuruck.TabIndex = 60;
            this.btnzuruck.Text = "Zurück zum Start Seite";
            this.btnzuruck.UseVisualStyleBackColor = true;
            // 
            // tbstartseite
            // 
            this.tbstartseite.BackColor = System.Drawing.Color.Gray;
            this.tbstartseite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbstartseite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbstartseite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbstartseite.Image = ((System.Drawing.Image)(resources.GetObject("tbstartseite.Image")));
            this.tbstartseite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbstartseite.Location = new System.Drawing.Point(3, 103);
            this.tbstartseite.Name = "tbstartseite";
            this.tbstartseite.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbstartseite.Size = new System.Drawing.Size(60, 30);
            this.tbstartseite.TabIndex = 66;
            this.tbstartseite.Text = "               Home";
            this.tbstartseite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbstartseite.UseVisualStyleBackColor = false;
            // 
            // btnDetail
            // 
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetail.Location = new System.Drawing.Point(1137, 145);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(266, 23);
            this.btnDetail.TabIndex = 66;
            this.btnDetail.Text = "Show more Details";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click_1);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.tbProduktName);
            this.panel.Controls.Add(this.tbBeschreibung);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.tbPreis);
            this.panel.Controls.Add(this.label4);
            this.panel.Location = new System.Drawing.Point(1124, 142);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(303, 110);
            this.panel.TabIndex = 65;
            this.panel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produkt Name";
            // 
            // tbProduktName
            // 
            this.tbProduktName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProduktName.Location = new System.Drawing.Point(141, 3);
            this.tbProduktName.Name = "tbProduktName";
            this.tbProduktName.ReadOnly = true;
            this.tbProduktName.Size = new System.Drawing.Size(145, 24);
            this.tbProduktName.TabIndex = 1;
            // 
            // tbBeschreibung
            // 
            this.tbBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeschreibung.Location = new System.Drawing.Point(141, 33);
            this.tbBeschreibung.Multiline = true;
            this.tbBeschreibung.Name = "tbBeschreibung";
            this.tbBeschreibung.ReadOnly = true;
            this.tbBeschreibung.Size = new System.Drawing.Size(145, 21);
            this.tbBeschreibung.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Beschreibung";
            // 
            // tbPreis
            // 
            this.tbPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreis.Location = new System.Drawing.Point(141, 60);
            this.tbPreis.Name = "tbPreis";
            this.tbPreis.ReadOnly = true;
            this.tbPreis.Size = new System.Drawing.Size(145, 24);
            this.tbPreis.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Preis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1141, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 64;
            this.label5.Text = "Summe Preis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1141, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "Menge";
            // 
            // tbSummePreis
            // 
            this.tbSummePreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSummePreis.Location = new System.Drawing.Point(1265, 115);
            this.tbSummePreis.Name = "tbSummePreis";
            this.tbSummePreis.ReadOnly = true;
            this.tbSummePreis.Size = new System.Drawing.Size(145, 24);
            this.tbSummePreis.TabIndex = 63;
            // 
            // countMenge
            // 
            this.countMenge.Location = new System.Drawing.Point(1265, 89);
            this.countMenge.Name = "countMenge";
            this.countMenge.Size = new System.Drawing.Size(145, 20);
            this.countMenge.TabIndex = 62;
            // 
            // MoebelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineShop.Properties.Resources._230_2301638_lilac;
            this.ClientSize = new System.Drawing.Size(1425, 594);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSummePreis);
            this.Controls.Add(this.countMenge);
            this.Controls.Add(this.btnzuruck);
            this.Controls.Add(this.tbSuche);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvMoebel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MoebelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoebelForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoebel)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countMenge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvMoebel;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMeineDaten;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button tbGeraete;
        private System.Windows.Forms.Button tbMoebel;
        private System.Windows.Forms.Button tbKleidung;
        private System.Windows.Forms.Button tbAbmelden;
        private System.Windows.Forms.TextBox tbSuche;
        private System.Windows.Forms.Button btnWarenkorb;
        private System.Windows.Forms.Button tbBestellung;
        private System.Windows.Forms.Button btnzuruck;
        private System.Windows.Forms.Button tbstartseite;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProduktName;
        private System.Windows.Forms.TextBox tbBeschreibung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPreis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSummePreis;
        private System.Windows.Forms.NumericUpDown countMenge;
    }
}