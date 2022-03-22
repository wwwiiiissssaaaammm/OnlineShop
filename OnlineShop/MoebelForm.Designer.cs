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
            this.label5 = new System.Windows.Forms.Label();
            this.tbSummePreis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countMenge = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPreis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBeschreibung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProduktName = new System.Windows.Forms.TextBox();
            this.dgvMoebel = new System.Windows.Forms.DataGridView();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMeineDaten = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.tbGeraete = new System.Windows.Forms.Button();
            this.tbMoebel = new System.Windows.Forms.Button();
            this.tbKleidung = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbAbmelden = new System.Windows.Forms.Button();
            this.tbSuche = new System.Windows.Forms.TextBox();
            this.lbSuche = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countMenge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoebel)).BeginInit();
            this.sideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1269, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Speichern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1269, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Warenkorb";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1179, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Summe Preis";
            // 
            // tbSummePreis
            // 
            this.tbSummePreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSummePreis.Location = new System.Drawing.Point(1180, 277);
            this.tbSummePreis.Name = "tbSummePreis";
            this.tbSummePreis.ReadOnly = true;
            this.tbSummePreis.Size = new System.Drawing.Size(233, 24);
            this.tbSummePreis.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1179, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Preis";
            // 
            // countMenge
            // 
            this.countMenge.Location = new System.Drawing.Point(1182, 236);
            this.countMenge.Name = "countMenge";
            this.countMenge.Size = new System.Drawing.Size(231, 20);
            this.countMenge.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1179, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Menge";
            // 
            // tbPreis
            // 
            this.tbPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreis.Location = new System.Drawing.Point(1182, 182);
            this.tbPreis.Name = "tbPreis";
            this.tbPreis.ReadOnly = true;
            this.tbPreis.Size = new System.Drawing.Size(231, 24);
            this.tbPreis.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1177, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Beschreibung";
            // 
            // tbBeschreibung
            // 
            this.tbBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeschreibung.Location = new System.Drawing.Point(1180, 89);
            this.tbBeschreibung.Multiline = true;
            this.tbBeschreibung.Name = "tbBeschreibung";
            this.tbBeschreibung.ReadOnly = true;
            this.tbBeschreibung.Size = new System.Drawing.Size(233, 62);
            this.tbBeschreibung.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1280, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Produkt Name";
            // 
            // tbProduktName
            // 
            this.tbProduktName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProduktName.Location = new System.Drawing.Point(1182, 41);
            this.tbProduktName.Name = "tbProduktName";
            this.tbProduktName.ReadOnly = true;
            this.tbProduktName.Size = new System.Drawing.Size(231, 24);
            this.tbProduktName.TabIndex = 20;
            // 
            // dgvMoebel
            // 
            this.dgvMoebel.AllowUserToAddRows = false;
            this.dgvMoebel.AllowUserToDeleteRows = false;
            this.dgvMoebel.AllowUserToResizeColumns = false;
            this.dgvMoebel.AllowUserToResizeRows = false;
            this.dgvMoebel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoebel.Location = new System.Drawing.Point(243, 59);
            this.dgvMoebel.MaximumSize = new System.Drawing.Size(814, 363);
            this.dgvMoebel.MinimumSize = new System.Drawing.Size(651, 363);
            this.dgvMoebel.Name = "dgvMoebel";
            this.dgvMoebel.ReadOnly = true;
            this.dgvMoebel.Size = new System.Drawing.Size(814, 363);
            this.dgvMoebel.TabIndex = 19;
            this.dgvMoebel.SelectionChanged += new System.EventHandler(this.dgvGeraete_SelectionChanged);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Controls.Add(this.btnMeineDaten);
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.Controls.Add(this.panel4);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(234, 601);
            this.sideBar.MinimumSize = new System.Drawing.Size(72, 601);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(234, 601);
            this.sideBar.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 99);
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
            this.pictureBox2.Location = new System.Drawing.Point(3, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnMeineDaten
            // 
            this.btnMeineDaten.BackColor = System.Drawing.Color.Silver;
            this.btnMeineDaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeineDaten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMeineDaten.Image = ((System.Drawing.Image)(resources.GetObject("btnMeineDaten.Image")));
            this.btnMeineDaten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeineDaten.Location = new System.Drawing.Point(3, 108);
            this.btnMeineDaten.Name = "btnMeineDaten";
            this.btnMeineDaten.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMeineDaten.Size = new System.Drawing.Size(229, 35);
            this.btnMeineDaten.TabIndex = 1;
            this.btnMeineDaten.Text = "               Meine Daten";
            this.btnMeineDaten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeineDaten.UseVisualStyleBackColor = false;
            this.btnMeineDaten.Click += new System.EventHandler(this.btnMeineDaten_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.tbGeraete);
            this.panel3.Controls.Add(this.tbMoebel);
            this.panel3.Controls.Add(this.tbKleidung);
            this.panel3.Location = new System.Drawing.Point(3, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 186);
            this.panel3.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 22);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(229, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "               Warenkorb";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbGeraete
            // 
            this.tbGeraete.BackColor = System.Drawing.Color.LightGray;
            this.tbGeraete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbGeraete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbGeraete.Image = ((System.Drawing.Image)(resources.GetObject("tbGeraete.Image")));
            this.tbGeraete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbGeraete.Location = new System.Drawing.Point(0, 66);
            this.tbGeraete.Name = "tbGeraete";
            this.tbGeraete.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbGeraete.Size = new System.Drawing.Size(229, 35);
            this.tbGeraete.TabIndex = 1;
            this.tbGeraete.Text = "               Geräte";
            this.tbGeraete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbGeraete.UseVisualStyleBackColor = false;
            this.tbGeraete.Click += new System.EventHandler(this.tbGeraete_Click);
            // 
            // tbMoebel
            // 
            this.tbMoebel.BackColor = System.Drawing.Color.LightGray;
            this.tbMoebel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbMoebel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbMoebel.Image = ((System.Drawing.Image)(resources.GetObject("tbMoebel.Image")));
            this.tbMoebel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMoebel.Location = new System.Drawing.Point(0, 107);
            this.tbMoebel.Name = "tbMoebel";
            this.tbMoebel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbMoebel.Size = new System.Drawing.Size(229, 35);
            this.tbMoebel.TabIndex = 2;
            this.tbMoebel.Text = "               Möbel";
            this.tbMoebel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMoebel.UseVisualStyleBackColor = false;
            this.tbMoebel.Click += new System.EventHandler(this.tbMoebel_Click);
            // 
            // tbKleidung
            // 
            this.tbKleidung.BackColor = System.Drawing.Color.LightGray;
            this.tbKleidung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbKleidung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbKleidung.Image = ((System.Drawing.Image)(resources.GetObject("tbKleidung.Image")));
            this.tbKleidung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbKleidung.Location = new System.Drawing.Point(0, 148);
            this.tbKleidung.Name = "tbKleidung";
            this.tbKleidung.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbKleidung.Size = new System.Drawing.Size(229, 35);
            this.tbKleidung.TabIndex = 3;
            this.tbKleidung.Text = "               Kleidung";
            this.tbKleidung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbKleidung.UseVisualStyleBackColor = false;
            this.tbKleidung.Click += new System.EventHandler(this.tbKleidung_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbAbmelden);
            this.panel4.Location = new System.Drawing.Point(3, 341);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 109);
            this.panel4.TabIndex = 5;
            // 
            // tbAbmelden
            // 
            this.tbAbmelden.BackColor = System.Drawing.Color.LightGray;
            this.tbAbmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbAbmelden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbAbmelden.Image = ((System.Drawing.Image)(resources.GetObject("tbAbmelden.Image")));
            this.tbAbmelden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbAbmelden.Location = new System.Drawing.Point(0, 71);
            this.tbAbmelden.Name = "tbAbmelden";
            this.tbAbmelden.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbAbmelden.Size = new System.Drawing.Size(229, 35);
            this.tbAbmelden.TabIndex = 3;
            this.tbAbmelden.Text = "               Abmelden";
            this.tbAbmelden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbAbmelden.UseVisualStyleBackColor = false;
            this.tbAbmelden.Click += new System.EventHandler(this.tbAbmelden_Click);
            // 
            // tbSuche
            // 
            this.tbSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuche.Location = new System.Drawing.Point(304, 12);
            this.tbSuche.Name = "tbSuche";
            this.tbSuche.Size = new System.Drawing.Size(750, 24);
            this.tbSuche.TabIndex = 47;
            this.tbSuche.TextChanged += new System.EventHandler(this.tbSuche_TextChanged);
            // 
            // lbSuche
            // 
            this.lbSuche.AutoSize = true;
            this.lbSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuche.Location = new System.Drawing.Point(240, 15);
            this.lbSuche.Name = "lbSuche";
            this.lbSuche.Size = new System.Drawing.Size(58, 18);
            this.lbSuche.TabIndex = 48;
            this.lbSuche.Text = "Suchen";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(188, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MoebelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 594);
            this.Controls.Add(this.lbSuche);
            this.Controls.Add(this.tbSuche);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSummePreis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.countMenge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPreis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBeschreibung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProduktName);
            this.Controls.Add(this.dgvMoebel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MoebelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoebelForm";
            ((System.ComponentModel.ISupportInitialize)(this.countMenge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoebel)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSummePreis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown countMenge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPreis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBeschreibung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProduktName;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button tbAbmelden;
        private System.Windows.Forms.TextBox tbSuche;
        private System.Windows.Forms.Label lbSuche;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}