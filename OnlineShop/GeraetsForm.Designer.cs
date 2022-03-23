namespace OnlineShop
{
    partial class GeraetsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeraetsForm));
            this.dgvGeraete = new System.Windows.Forms.DataGridView();
            this.tbProduktName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBeschreibung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPreis = new System.Windows.Forms.TextBox();
            this.countMenge = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSummePreis = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.tbSuche = new System.Windows.Forms.TextBox();
            this.btnAbmelden = new System.Windows.Forms.Button();
            this.btnBestellung = new System.Windows.Forms.Button();
            this.btnWarenkorb = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMeineDaten = new System.Windows.Forms.Button();
            this.btnstartseite = new System.Windows.Forms.Button();
            this.btnGeraete = new System.Windows.Forms.Button();
            this.btnMoebel = new System.Windows.Forms.Button();
            this.btnKleidung = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel = new System.Windows.Forms.Panel();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnzuruck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeraete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMenge)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.sideBar.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGeraete
            // 
            this.dgvGeraete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeraete.Location = new System.Drawing.Point(159, 45);
            this.dgvGeraete.MaximumSize = new System.Drawing.Size(966, 460);
            this.dgvGeraete.MinimumSize = new System.Drawing.Size(805, 372);
            this.dgvGeraete.Name = "dgvGeraete";
            this.dgvGeraete.Size = new System.Drawing.Size(962, 460);
            this.dgvGeraete.TabIndex = 0;
            this.dgvGeraete.SelectionChanged += new System.EventHandler(this.dgvGeraete_SelectionChanged);
            // 
            // tbProduktName
            // 
            this.tbProduktName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProduktName.Location = new System.Drawing.Point(148, 3);
            this.tbProduktName.Name = "tbProduktName";
            this.tbProduktName.ReadOnly = true;
            this.tbProduktName.Size = new System.Drawing.Size(145, 24);
            this.tbProduktName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produkt Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Beschreibung";
            // 
            // tbBeschreibung
            // 
            this.tbBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeschreibung.Location = new System.Drawing.Point(148, 39);
            this.tbBeschreibung.Multiline = true;
            this.tbBeschreibung.Name = "tbBeschreibung";
            this.tbBeschreibung.ReadOnly = true;
            this.tbBeschreibung.Size = new System.Drawing.Size(145, 21);
            this.tbBeschreibung.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1153, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Menge";
            // 
            // tbPreis
            // 
            this.tbPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreis.Location = new System.Drawing.Point(148, 71);
            this.tbPreis.Name = "tbPreis";
            this.tbPreis.ReadOnly = true;
            this.tbPreis.Size = new System.Drawing.Size(145, 24);
            this.tbPreis.TabIndex = 5;
            // 
            // countMenge
            // 
            this.countMenge.Location = new System.Drawing.Point(1277, 86);
            this.countMenge.Name = "countMenge";
            this.countMenge.Size = new System.Drawing.Size(145, 20);
            this.countMenge.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 77);
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
            this.label5.Location = new System.Drawing.Point(1153, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Summe Preis";
            // 
            // tbSummePreis
            // 
            this.tbSummePreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSummePreis.Location = new System.Drawing.Point(1277, 112);
            this.tbSummePreis.Name = "tbSummePreis";
            this.tbSummePreis.ReadOnly = true;
            this.tbSummePreis.Size = new System.Drawing.Size(145, 24);
            this.tbSummePreis.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(1168, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 26);
            this.button1.TabIndex = 17;
            this.button1.Text = "Zum Warenkorb";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpeichern.Location = new System.Drawing.Point(1198, 352);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(179, 29);
            this.btnSpeichern.TabIndex = 18;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // tbSuche
            // 
            this.tbSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuche.Location = new System.Drawing.Point(268, 15);
            this.tbSuche.Name = "tbSuche";
            this.tbSuche.Size = new System.Drawing.Size(746, 24);
            this.tbSuche.TabIndex = 48;
            this.tbSuche.TextChanged += new System.EventHandler(this.tbsuche_TextChanged);
            // 
            // btnAbmelden
            // 
            this.btnAbmelden.BackColor = System.Drawing.Color.Gray;
            this.btnAbmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbmelden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAbmelden.Image = ((System.Drawing.Image)(resources.GetObject("btnAbmelden.Image")));
            this.btnAbmelden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbmelden.Location = new System.Drawing.Point(3, 425);
            this.btnAbmelden.Name = "btnAbmelden";
            this.btnAbmelden.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAbmelden.Size = new System.Drawing.Size(60, 30);
            this.btnAbmelden.TabIndex = 3;
            this.btnAbmelden.Text = "               Abmelden";
            this.btnAbmelden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbmelden.UseVisualStyleBackColor = false;
            this.btnAbmelden.Click += new System.EventHandler(this.tbAbmelden_Click);
            this.btnAbmelden.MouseEnter += new System.EventHandler(this.btnAbmelden_MouseEnter);
            this.btnAbmelden.MouseLeave += new System.EventHandler(this.btnAbmelden_MouseLeave);
            // 
            // btnBestellung
            // 
            this.btnBestellung.BackColor = System.Drawing.Color.Gray;
            this.btnBestellung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBestellung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestellung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBestellung.Image = ((System.Drawing.Image)(resources.GetObject("btnBestellung.Image")));
            this.btnBestellung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBestellung.Location = new System.Drawing.Point(3, 320);
            this.btnBestellung.Name = "btnBestellung";
            this.btnBestellung.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBestellung.Size = new System.Drawing.Size(60, 30);
            this.btnBestellung.TabIndex = 9;
            this.btnBestellung.Text = "               Meine Bestellungen";
            this.btnBestellung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBestellung.UseVisualStyleBackColor = false;
            this.btnBestellung.Click += new System.EventHandler(this.btnBestellung_Click);
            this.btnBestellung.MouseEnter += new System.EventHandler(this.btnBestellung_MouseEnter);
            this.btnBestellung.MouseLeave += new System.EventHandler(this.btnBestellung_MouseLeave);
            // 
            // btnWarenkorb
            // 
            this.btnWarenkorb.BackColor = System.Drawing.Color.Gray;
            this.btnWarenkorb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarenkorb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWarenkorb.Image = ((System.Drawing.Image)(resources.GetObject("btnWarenkorb.Image")));
            this.btnWarenkorb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWarenkorb.Location = new System.Drawing.Point(3, 284);
            this.btnWarenkorb.Name = "btnWarenkorb";
            this.btnWarenkorb.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnWarenkorb.Size = new System.Drawing.Size(60, 30);
            this.btnWarenkorb.TabIndex = 4;
            this.btnWarenkorb.Text = "               Warenkorb";
            this.btnWarenkorb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWarenkorb.UseVisualStyleBackColor = false;
            this.btnWarenkorb.Click += new System.EventHandler(this.button4_Click);
            this.btnWarenkorb.MouseEnter += new System.EventHandler(this.btnWarenkorb_MouseEnter);
            this.btnWarenkorb.MouseLeave += new System.EventHandler(this.btnWarenkorb_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnWarenkorb);
            this.panel3.Controls.Add(this.btnMeineDaten);
            this.panel3.Controls.Add(this.btnstartseite);
            this.panel3.Controls.Add(this.btnBestellung);
            this.panel3.Controls.Add(this.btnGeraete);
            this.panel3.Controls.Add(this.btnMoebel);
            this.panel3.Controls.Add(this.btnAbmelden);
            this.panel3.Controls.Add(this.btnKleidung);
            this.panel3.Location = new System.Drawing.Point(0, 86);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 506);
            this.panel3.TabIndex = 4;
            // 
            // btnMeineDaten
            // 
            this.btnMeineDaten.BackColor = System.Drawing.Color.Gray;
            this.btnMeineDaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeineDaten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMeineDaten.Image = ((System.Drawing.Image)(resources.GetObject("btnMeineDaten.Image")));
            this.btnMeineDaten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeineDaten.Location = new System.Drawing.Point(3, 14);
            this.btnMeineDaten.Name = "btnMeineDaten";
            this.btnMeineDaten.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMeineDaten.Size = new System.Drawing.Size(60, 30);
            this.btnMeineDaten.TabIndex = 1;
            this.btnMeineDaten.Text = "               Meine Daten";
            this.btnMeineDaten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeineDaten.UseVisualStyleBackColor = false;
            this.btnMeineDaten.Click += new System.EventHandler(this.btnMeineDaten_Click);
            this.btnMeineDaten.MouseEnter += new System.EventHandler(this.btnMeineDaten_MouseEnter);
            this.btnMeineDaten.MouseLeave += new System.EventHandler(this.btnMeineDaten_MouseLeave);
            // 
            // btnstartseite
            // 
            this.btnstartseite.BackColor = System.Drawing.Color.Gray;
            this.btnstartseite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstartseite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstartseite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnstartseite.Image = ((System.Drawing.Image)(resources.GetObject("btnstartseite.Image")));
            this.btnstartseite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstartseite.Location = new System.Drawing.Point(3, 91);
            this.btnstartseite.Name = "btnstartseite";
            this.btnstartseite.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnstartseite.Size = new System.Drawing.Size(60, 30);
            this.btnstartseite.TabIndex = 9;
            this.btnstartseite.Text = "               Home";
            this.btnstartseite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstartseite.UseVisualStyleBackColor = false;
            this.btnstartseite.Click += new System.EventHandler(this.btnstartseite_Click);
            this.btnstartseite.MouseEnter += new System.EventHandler(this.btnstartseite_MouseEnter);
            this.btnstartseite.MouseLeave += new System.EventHandler(this.btnstartseite_MouseLeave);
            // 
            // btnGeraete
            // 
            this.btnGeraete.BackColor = System.Drawing.Color.Gray;
            this.btnGeraete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeraete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGeraete.Image = ((System.Drawing.Image)(resources.GetObject("btnGeraete.Image")));
            this.btnGeraete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeraete.Location = new System.Drawing.Point(3, 127);
            this.btnGeraete.Name = "btnGeraete";
            this.btnGeraete.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGeraete.Size = new System.Drawing.Size(60, 30);
            this.btnGeraete.TabIndex = 1;
            this.btnGeraete.Text = "               Geräte";
            this.btnGeraete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeraete.UseVisualStyleBackColor = false;
            this.btnGeraete.Click += new System.EventHandler(this.tbGeraete_Click);
            this.btnGeraete.MouseEnter += new System.EventHandler(this.btnGeraete_MouseEnter);
            this.btnGeraete.MouseLeave += new System.EventHandler(this.btnGeraete_MouseLeave);
            // 
            // btnMoebel
            // 
            this.btnMoebel.BackColor = System.Drawing.Color.Gray;
            this.btnMoebel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoebel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMoebel.Image = ((System.Drawing.Image)(resources.GetObject("btnMoebel.Image")));
            this.btnMoebel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoebel.Location = new System.Drawing.Point(3, 163);
            this.btnMoebel.Name = "btnMoebel";
            this.btnMoebel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMoebel.Size = new System.Drawing.Size(60, 30);
            this.btnMoebel.TabIndex = 2;
            this.btnMoebel.Text = "               Möbel";
            this.btnMoebel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoebel.UseVisualStyleBackColor = false;
            this.btnMoebel.Click += new System.EventHandler(this.tbMoebel_Click);
            this.btnMoebel.MouseEnter += new System.EventHandler(this.btnMoebel_MouseEnter);
            this.btnMoebel.MouseLeave += new System.EventHandler(this.btnMoebel_MouseLeave);
            // 
            // btnKleidung
            // 
            this.btnKleidung.BackColor = System.Drawing.Color.Gray;
            this.btnKleidung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKleidung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKleidung.Image = ((System.Drawing.Image)(resources.GetObject("btnKleidung.Image")));
            this.btnKleidung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKleidung.Location = new System.Drawing.Point(3, 199);
            this.btnKleidung.Name = "btnKleidung";
            this.btnKleidung.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnKleidung.Size = new System.Drawing.Size(60, 30);
            this.btnKleidung.TabIndex = 3;
            this.btnKleidung.Text = "               Kleidung";
            this.btnKleidung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKleidung.UseVisualStyleBackColor = false;
            this.btnKleidung.Click += new System.EventHandler(this.tbKleidung_Click);
            this.btnKleidung.MouseEnter += new System.EventHandler(this.btnKleidung_MouseEnter);
            this.btnKleidung.MouseLeave += new System.EventHandler(this.btnKleidung_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 86);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(69, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.Transparent;
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(234, 592);
            this.sideBar.MinimumSize = new System.Drawing.Size(63, 592);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(63, 592);
            this.sideBar.TabIndex = 47;
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
            this.panel.Location = new System.Drawing.Point(1129, 142);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(309, 101);
            this.panel.TabIndex = 49;
            this.panel.Visible = false;
            // 
            // btnDetail
            // 
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetail.Location = new System.Drawing.Point(1149, 142);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(266, 23);
            this.btnDetail.TabIndex = 50;
            this.btnDetail.Text = "Show more Details";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnzuruck
            // 
            this.btnzuruck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnzuruck.Location = new System.Drawing.Point(547, 523);
            this.btnzuruck.Name = "btnzuruck";
            this.btnzuruck.Size = new System.Drawing.Size(177, 32);
            this.btnzuruck.TabIndex = 51;
            this.btnzuruck.Text = "Zurück zum Start Seite";
            this.btnzuruck.UseVisualStyleBackColor = true;
            this.btnzuruck.Click += new System.EventHandler(this.btnzuruck_Click);
            // 
            // GeraetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineShop.Properties.Resources._230_2301638_lilac;
            this.ClientSize = new System.Drawing.Size(1425, 594);
            this.Controls.Add(this.btnzuruck);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tbSuche);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSummePreis);
            this.Controls.Add(this.countMenge);
            this.Controls.Add(this.dgvGeraete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GeraetsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeraetsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeraete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMenge)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGeraete;
        private System.Windows.Forms.TextBox tbProduktName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBeschreibung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPreis;
        private System.Windows.Forms.NumericUpDown countMenge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSummePreis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.TextBox tbSuche;
        private System.Windows.Forms.Button btnWarenkorb;
        private System.Windows.Forms.Button btnBestellung;
        private System.Windows.Forms.Button btnAbmelden;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnstartseite;
        private System.Windows.Forms.Button btnGeraete;
        private System.Windows.Forms.Button btnMoebel;
        private System.Windows.Forms.Button btnKleidung;
        private System.Windows.Forms.Button btnMeineDaten;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnzuruck;
    }
}