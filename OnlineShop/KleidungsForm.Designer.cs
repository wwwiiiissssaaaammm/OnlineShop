namespace OnlineShop
{
    partial class KleidungsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KleidungsForm));
            this.dgvKleidung = new System.Windows.Forms.DataGridView();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbBestellung = new System.Windows.Forms.Button();
            this.tbstartseite = new System.Windows.Forms.Button();
            this.tbWarenkorb = new System.Windows.Forms.Button();
            this.btnMeineDaten = new System.Windows.Forms.Button();
            this.tbAbmelden = new System.Windows.Forms.Button();
            this.tbGeraete = new System.Windows.Forms.Button();
            this.tbMoebel = new System.Windows.Forms.Button();
            this.tbKleidung = new System.Windows.Forms.Button();
            this.tbSuche = new System.Windows.Forms.TextBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProduktName = new System.Windows.Forms.TextBox();
            this.tbBeschreibung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPreis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.tbSummePreis = new System.Windows.Forms.TextBox();
            this.countMenge = new System.Windows.Forms.NumericUpDown();
            this.btnzuruck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKleidung)).BeginInit();
            this.sideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countMenge)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKleidung
            // 
            this.dgvKleidung.AllowUserToAddRows = false;
            this.dgvKleidung.AllowUserToDeleteRows = false;
            this.dgvKleidung.AllowUserToResizeColumns = false;
            this.dgvKleidung.AllowUserToResizeRows = false;
            this.dgvKleidung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKleidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKleidung.Location = new System.Drawing.Point(155, 45);
            this.dgvKleidung.MaximumSize = new System.Drawing.Size(966, 460);
            this.dgvKleidung.MinimumSize = new System.Drawing.Size(805, 372);
            this.dgvKleidung.Name = "dgvKleidung";
            this.dgvKleidung.ReadOnly = true;
            this.dgvKleidung.Size = new System.Drawing.Size(966, 460);
            this.dgvKleidung.TabIndex = 32;
            this.dgvKleidung.SelectionChanged += new System.EventHandler(this.dgvKleidung_SelectionChanged);
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
            this.sideBar.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 78);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(69, 26);
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
            this.pictureBox2.Location = new System.Drawing.Point(3, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbBestellung);
            this.panel3.Controls.Add(this.tbstartseite);
            this.panel3.Controls.Add(this.tbWarenkorb);
            this.panel3.Controls.Add(this.btnMeineDaten);
            this.panel3.Controls.Add(this.tbAbmelden);
            this.panel3.Controls.Add(this.tbGeraete);
            this.panel3.Controls.Add(this.tbMoebel);
            this.panel3.Controls.Add(this.tbKleidung);
            this.panel3.Location = new System.Drawing.Point(0, 78);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 516);
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
            this.tbBestellung.Location = new System.Drawing.Point(3, 333);
            this.tbBestellung.Name = "tbBestellung";
            this.tbBestellung.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbBestellung.Size = new System.Drawing.Size(60, 30);
            this.tbBestellung.TabIndex = 60;
            this.tbBestellung.Text = "               Meine Bestellungen";
            this.tbBestellung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbBestellung.UseVisualStyleBackColor = false;
            this.tbBestellung.Click += new System.EventHandler(this.tbBestellung_Click);
            this.tbBestellung.MouseEnter += new System.EventHandler(this.btnBestellung_MouseEnter);
            this.tbBestellung.MouseLeave += new System.EventHandler(this.btnBestellung_MouseLeave);
            // 
            // tbstartseite
            // 
            this.tbstartseite.BackColor = System.Drawing.Color.Gray;
            this.tbstartseite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbstartseite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbstartseite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbstartseite.Image = ((System.Drawing.Image)(resources.GetObject("tbstartseite.Image")));
            this.tbstartseite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbstartseite.Location = new System.Drawing.Point(3, 105);
            this.tbstartseite.Name = "tbstartseite";
            this.tbstartseite.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbstartseite.Size = new System.Drawing.Size(60, 30);
            this.tbstartseite.TabIndex = 59;
            this.tbstartseite.Text = "               Home";
            this.tbstartseite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbstartseite.UseVisualStyleBackColor = false;
            this.tbstartseite.Click += new System.EventHandler(this.tbstartseite_Click);
            this.tbstartseite.MouseEnter += new System.EventHandler(this.btnstartseite_MouseEnter);
            this.tbstartseite.MouseLeave += new System.EventHandler(this.btnstartseite_MouseLeave);
            // 
            // tbWarenkorb
            // 
            this.tbWarenkorb.BackColor = System.Drawing.Color.Gray;
            this.tbWarenkorb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbWarenkorb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbWarenkorb.Image = ((System.Drawing.Image)(resources.GetObject("tbWarenkorb.Image")));
            this.tbWarenkorb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbWarenkorb.Location = new System.Drawing.Point(3, 297);
            this.tbWarenkorb.Name = "tbWarenkorb";
            this.tbWarenkorb.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbWarenkorb.Size = new System.Drawing.Size(60, 30);
            this.tbWarenkorb.TabIndex = 5;
            this.tbWarenkorb.Text = "               Warenkorb";
            this.tbWarenkorb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbWarenkorb.UseVisualStyleBackColor = false;
            this.tbWarenkorb.Click += new System.EventHandler(this.button4_Click);
            this.tbWarenkorb.MouseEnter += new System.EventHandler(this.btnWarenkorb_MouseEnter);
            this.tbWarenkorb.MouseLeave += new System.EventHandler(this.btnWarenkorb_MouseLeave);
            // 
            // btnMeineDaten
            // 
            this.btnMeineDaten.BackColor = System.Drawing.Color.Gray;
            this.btnMeineDaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeineDaten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMeineDaten.Image = ((System.Drawing.Image)(resources.GetObject("btnMeineDaten.Image")));
            this.btnMeineDaten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeineDaten.Location = new System.Drawing.Point(3, 22);
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
            // tbAbmelden
            // 
            this.tbAbmelden.BackColor = System.Drawing.Color.Gray;
            this.tbAbmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbAbmelden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbAbmelden.Image = ((System.Drawing.Image)(resources.GetObject("tbAbmelden.Image")));
            this.tbAbmelden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbAbmelden.Location = new System.Drawing.Point(3, 447);
            this.tbAbmelden.Name = "tbAbmelden";
            this.tbAbmelden.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbAbmelden.Size = new System.Drawing.Size(60, 30);
            this.tbAbmelden.TabIndex = 3;
            this.tbAbmelden.Text = "               Abmelden";
            this.tbAbmelden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbAbmelden.UseVisualStyleBackColor = false;
            this.tbAbmelden.Click += new System.EventHandler(this.tbAbmelden_Click);
            this.tbAbmelden.MouseEnter += new System.EventHandler(this.btnAbmelden_MouseEnter);
            this.tbAbmelden.MouseLeave += new System.EventHandler(this.btnAbmelden_MouseLeave);
            // 
            // tbGeraete
            // 
            this.tbGeraete.BackColor = System.Drawing.Color.Gray;
            this.tbGeraete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbGeraete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbGeraete.Image = ((System.Drawing.Image)(resources.GetObject("tbGeraete.Image")));
            this.tbGeraete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbGeraete.Location = new System.Drawing.Point(3, 141);
            this.tbGeraete.Name = "tbGeraete";
            this.tbGeraete.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbGeraete.Size = new System.Drawing.Size(60, 30);
            this.tbGeraete.TabIndex = 1;
            this.tbGeraete.Text = "               Geräte";
            this.tbGeraete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbGeraete.UseVisualStyleBackColor = false;
            this.tbGeraete.Click += new System.EventHandler(this.tbGeraete_Click);
            this.tbGeraete.MouseEnter += new System.EventHandler(this.btnGeraete_MouseEnter);
            this.tbGeraete.MouseLeave += new System.EventHandler(this.btnGeraete_MouseLeave);
            // 
            // tbMoebel
            // 
            this.tbMoebel.BackColor = System.Drawing.Color.Gray;
            this.tbMoebel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbMoebel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbMoebel.Image = ((System.Drawing.Image)(resources.GetObject("tbMoebel.Image")));
            this.tbMoebel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMoebel.Location = new System.Drawing.Point(3, 177);
            this.tbMoebel.Name = "tbMoebel";
            this.tbMoebel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbMoebel.Size = new System.Drawing.Size(60, 30);
            this.tbMoebel.TabIndex = 2;
            this.tbMoebel.Text = "               Möbel";
            this.tbMoebel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMoebel.UseVisualStyleBackColor = false;
            this.tbMoebel.Click += new System.EventHandler(this.tbMoebel_Click);
            this.tbMoebel.MouseEnter += new System.EventHandler(this.btnMoebel_MouseEnter);
            this.tbMoebel.MouseLeave += new System.EventHandler(this.btnMoebel_MouseLeave);
            // 
            // tbKleidung
            // 
            this.tbKleidung.BackColor = System.Drawing.Color.Gray;
            this.tbKleidung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbKleidung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbKleidung.Image = ((System.Drawing.Image)(resources.GetObject("tbKleidung.Image")));
            this.tbKleidung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbKleidung.Location = new System.Drawing.Point(3, 213);
            this.tbKleidung.Name = "tbKleidung";
            this.tbKleidung.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbKleidung.Size = new System.Drawing.Size(60, 30);
            this.tbKleidung.TabIndex = 3;
            this.tbKleidung.Text = "               Kleidung";
            this.tbKleidung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbKleidung.UseVisualStyleBackColor = false;
            this.tbKleidung.Click += new System.EventHandler(this.tbKleidung_Click);
            this.tbKleidung.MouseEnter += new System.EventHandler(this.btnKleidung_MouseEnter);
            this.tbKleidung.MouseLeave += new System.EventHandler(this.btnKleidung_MouseLeave);
            // 
            // tbSuche
            // 
            this.tbSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuche.Location = new System.Drawing.Point(268, 15);
            this.tbSuche.Name = "tbSuche";
            this.tbSuche.Size = new System.Drawing.Size(746, 24);
            this.tbSuche.TabIndex = 46;
            this.tbSuche.TextChanged += new System.EventHandler(this.tbSuche_TextChanged);
            // 
            // btnDetail
            // 
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetail.Location = new System.Drawing.Point(1140, 146);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(266, 23);
            this.btnDetail.TabIndex = 58;
            this.btnDetail.Text = "Show more Details";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
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
            this.panel.Location = new System.Drawing.Point(1127, 143);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(303, 110);
            this.panel.TabIndex = 57;
            this.panel.Visible = false;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
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
            this.label5.Location = new System.Drawing.Point(1144, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "Summe Preis";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(1195, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 29);
            this.button2.TabIndex = 56;
            this.button2.Text = "Speichern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1144, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Menge";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(1168, 320);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(230, 26);
            this.button6.TabIndex = 55;
            this.button6.Text = "Zum Warenkorb";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSummePreis
            // 
            this.tbSummePreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSummePreis.Location = new System.Drawing.Point(1268, 116);
            this.tbSummePreis.Name = "tbSummePreis";
            this.tbSummePreis.ReadOnly = true;
            this.tbSummePreis.Size = new System.Drawing.Size(145, 24);
            this.tbSummePreis.TabIndex = 53;
            this.tbSummePreis.TextChanged += new System.EventHandler(this.tbSummePreis_TextChanged);
            // 
            // countMenge
            // 
            this.countMenge.Location = new System.Drawing.Point(1268, 90);
            this.countMenge.Name = "countMenge";
            this.countMenge.Size = new System.Drawing.Size(145, 20);
            this.countMenge.TabIndex = 52;
            this.countMenge.ValueChanged += new System.EventHandler(this.countMenge_ValueChanged);
            // 
            // btnzuruck
            // 
            this.btnzuruck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnzuruck.Location = new System.Drawing.Point(527, 525);
            this.btnzuruck.Name = "btnzuruck";
            this.btnzuruck.Size = new System.Drawing.Size(177, 32);
            this.btnzuruck.TabIndex = 59;
            this.btnzuruck.Text = "Zurück zum Start Seite";
            this.btnzuruck.UseVisualStyleBackColor = true;
            this.btnzuruck.Click += new System.EventHandler(this.btnzuruck_Click);
            // 
            // KleidungsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineShop.Properties.Resources._230_2301638_lilac;
            this.ClientSize = new System.Drawing.Size(1425, 594);
            this.Controls.Add(this.btnzuruck);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tbSummePreis);
            this.Controls.Add(this.countMenge);
            this.Controls.Add(this.tbSuche);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.dgvKleidung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KleidungsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KleidungsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKleidung)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvKleidung;
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
        private System.Windows.Forms.Button tbWarenkorb;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProduktName;
        private System.Windows.Forms.TextBox tbBeschreibung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPreis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tbSummePreis;
        private System.Windows.Forms.NumericUpDown countMenge;
        private System.Windows.Forms.Button tbstartseite;
        private System.Windows.Forms.Button tbBestellung;
        private System.Windows.Forms.Button btnzuruck;
    }
}