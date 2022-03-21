namespace OnlineShop
{
    partial class kundenDatenA
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
            this.dgvKundenDaten = new System.Windows.Forms.DataGridView();
            this.tbSuche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNachname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOrt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStr = new System.Windows.Forms.TextBox();
            this.tbHnr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPlz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTele = new System.Windows.Forms.TextBox();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKundenDaten)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKundenDaten
            // 
            this.dgvKundenDaten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKundenDaten.Location = new System.Drawing.Point(12, 41);
            this.dgvKundenDaten.Name = "dgvKundenDaten";
            this.dgvKundenDaten.Size = new System.Drawing.Size(1015, 196);
            this.dgvKundenDaten.TabIndex = 0;
            this.dgvKundenDaten.SelectionChanged += new System.EventHandler(this.dgvKundenDaten_SelectionChanged);
            // 
            // tbSuche
            // 
            this.tbSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuche.Location = new System.Drawing.Point(76, 15);
            this.tbSuche.Name = "tbSuche";
            this.tbSuche.Size = new System.Drawing.Size(950, 24);
            this.tbSuche.TabIndex = 1;
            this.tbSuche.TextChanged += new System.EventHandler(this.tbSuche_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Suchen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vorname";
            // 
            // tbVorname
            // 
            this.tbVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVorname.Location = new System.Drawing.Point(176, 292);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.ReadOnly = true;
            this.tbVorname.Size = new System.Drawing.Size(172, 24);
            this.tbVorname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nachname";
            // 
            // tbNachname
            // 
            this.tbNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNachname.Location = new System.Drawing.Point(176, 322);
            this.tbNachname.Name = "tbNachname";
            this.tbNachname.ReadOnly = true;
            this.tbNachname.Size = new System.Drawing.Size(172, 24);
            this.tbNachname.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "E-Mail";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(176, 352);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(172, 24);
            this.tbEmail.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ort";
            // 
            // tbOrt
            // 
            this.tbOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrt.Location = new System.Drawing.Point(176, 382);
            this.tbOrt.Name = "tbOrt";
            this.tbOrt.ReadOnly = true;
            this.tbOrt.Size = new System.Drawing.Size(172, 24);
            this.tbOrt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(403, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Straße und Hausnummer";
            // 
            // tbStr
            // 
            this.tbStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStr.Location = new System.Drawing.Point(583, 268);
            this.tbStr.Name = "tbStr";
            this.tbStr.ReadOnly = true;
            this.tbStr.Size = new System.Drawing.Size(172, 24);
            this.tbStr.TabIndex = 13;
            // 
            // tbHnr
            // 
            this.tbHnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHnr.Location = new System.Drawing.Point(783, 268);
            this.tbHnr.Name = "tbHnr";
            this.tbHnr.ReadOnly = true;
            this.tbHnr.Size = new System.Drawing.Size(65, 24);
            this.tbHnr.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(495, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "PLZ";
            // 
            // tbPlz
            // 
            this.tbPlz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlz.Location = new System.Drawing.Point(583, 299);
            this.tbPlz.Name = "tbPlz";
            this.tbPlz.ReadOnly = true;
            this.tbPlz.Size = new System.Drawing.Size(172, 24);
            this.tbPlz.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(176, 261);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(172, 24);
            this.tbID.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(465, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Telefonnummer";
            // 
            // tbTele
            // 
            this.tbTele.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTele.Location = new System.Drawing.Point(583, 339);
            this.tbTele.Name = "tbTele";
            this.tbTele.ReadOnly = true;
            this.tbTele.Size = new System.Drawing.Size(172, 24);
            this.tbTele.TabIndex = 21;
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.Location = new System.Drawing.Point(774, 384);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(124, 23);
            this.btnBearbeiten.TabIndex = 23;
            this.btnBearbeiten.Text = "Bearbeiten";
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            this.btnBearbeiten.Click += new System.EventHandler(this.btnBearbeiten_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Enabled = false;
            this.btnSpeichern.Location = new System.Drawing.Point(15, 432);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(1051, 23);
            this.btnSpeichern.TabIndex = 24;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // kundenDatenA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 594);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPlz);
            this.Controls.Add(this.tbHnr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbStr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbOrt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNachname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbVorname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSuche);
            this.Controls.Add(this.dgvKundenDaten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "kundenDatenA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kundenDatenA";
            this.Load += new System.EventHandler(this.kundenDatenA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKundenDaten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKundenDaten;
        private System.Windows.Forms.TextBox tbSuche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNachname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOrt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbStr;
        private System.Windows.Forms.TextBox tbHnr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPlz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTele;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Button btnSpeichern;
    }
}