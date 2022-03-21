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
            this.button2 = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMeineDaten = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbGeraete = new System.Windows.Forms.Button();
            this.tbMoebel = new System.Windows.Forms.Button();
            this.tbKleidung = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbAbmelden = new System.Windows.Forms.Button();
            this.tbsuche = new System.Windows.Forms.TextBox();
            this.lbSuche = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeraete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMenge)).BeginInit();
            this.sideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGeraete
            // 
            this.dgvGeraete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeraete.Location = new System.Drawing.Point(78, 42);
            this.dgvGeraete.MaximumSize = new System.Drawing.Size(812, 363);
            this.dgvGeraete.MinimumSize = new System.Drawing.Size(651, 363);
            this.dgvGeraete.Name = "dgvGeraete";
            this.dgvGeraete.Size = new System.Drawing.Size(811, 363);
            this.dgvGeraete.TabIndex = 0;
            this.dgvGeraete.SelectionChanged += new System.EventHandler(this.dgvGeraete_SelectionChanged);
            // 
            // tbProduktName
            // 
            this.tbProduktName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProduktName.Location = new System.Drawing.Point(1072, 29);
            this.tbProduktName.Name = "tbProduktName";
            this.tbProduktName.ReadOnly = true;
            this.tbProduktName.Size = new System.Drawing.Size(144, 24);
            this.tbProduktName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(895, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produkt Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(895, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Beschreibung";
            // 
            // tbBeschreibung
            // 
            this.tbBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeschreibung.Location = new System.Drawing.Point(999, 85);
            this.tbBeschreibung.Multiline = true;
            this.tbBeschreibung.Name = "tbBeschreibung";
            this.tbBeschreibung.ReadOnly = true;
            this.tbBeschreibung.Size = new System.Drawing.Size(233, 127);
            this.tbBeschreibung.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(895, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Menge";
            // 
            // tbPreis
            // 
            this.tbPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreis.Location = new System.Drawing.Point(1072, 271);
            this.tbPreis.Name = "tbPreis";
            this.tbPreis.ReadOnly = true;
            this.tbPreis.Size = new System.Drawing.Size(144, 24);
            this.tbPreis.TabIndex = 5;
            // 
            // countMenge
            // 
            this.countMenge.Location = new System.Drawing.Point(1072, 329);
            this.countMenge.Name = "countMenge";
            this.countMenge.Size = new System.Drawing.Size(144, 20);
            this.countMenge.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(895, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Preis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(895, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Summe Preis";
            // 
            // tbSummePreis
            // 
            this.tbSummePreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSummePreis.Location = new System.Drawing.Point(1072, 381);
            this.tbSummePreis.Name = "tbSummePreis";
            this.tbSummePreis.ReadOnly = true;
            this.tbSummePreis.Size = new System.Drawing.Size(144, 24);
            this.tbSummePreis.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Warenkorb";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(794, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Speichern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.sideBar.MaximumSize = new System.Drawing.Size(234, 450);
            this.sideBar.MinimumSize = new System.Drawing.Size(72, 450);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(72, 450);
            this.sideBar.TabIndex = 47;
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
            this.btnMeineDaten.BackColor = System.Drawing.Color.LightGray;
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
            this.panel3.Controls.Add(this.tbGeraete);
            this.panel3.Controls.Add(this.tbMoebel);
            this.panel3.Controls.Add(this.tbKleidung);
            this.panel3.Location = new System.Drawing.Point(3, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 186);
            this.panel3.TabIndex = 4;
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
            // tbsuche
            // 
            this.tbsuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsuche.Location = new System.Drawing.Point(146, 12);
            this.tbsuche.Name = "tbsuche";
            this.tbsuche.Size = new System.Drawing.Size(744, 24);
            this.tbsuche.TabIndex = 48;
            this.tbsuche.TextChanged += new System.EventHandler(this.tbsuche_TextChanged);
            // 
            // lbSuche
            // 
            this.lbSuche.AutoSize = true;
            this.lbSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuche.Location = new System.Drawing.Point(84, 15);
            this.lbSuche.Name = "lbSuche";
            this.lbSuche.Size = new System.Drawing.Size(56, 18);
            this.lbSuche.TabIndex = 49;
            this.lbSuche.Text = "suchen";
            // 
            // GeraetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 594);
            this.Controls.Add(this.lbSuche);
            this.Controls.Add(this.tbsuche);
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
            this.Controls.Add(this.dgvGeraete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GeraetsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeraetsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeraete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMenge)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMeineDaten;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button tbGeraete;
        private System.Windows.Forms.Button tbMoebel;
        private System.Windows.Forms.Button tbKleidung;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button tbAbmelden;
        private System.Windows.Forms.TextBox tbsuche;
        private System.Windows.Forms.Label lbSuche;
    }
}