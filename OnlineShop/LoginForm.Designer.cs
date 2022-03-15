namespace OnlineShop
{
    partial class LoginForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginPan = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbAnzeigen = new System.Windows.Forms.CheckBox();
            this.btnErstellen = new System.Windows.Forms.Button();
            this.btnAnmelden = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPasswort = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tberror = new System.Windows.Forms.Label();
            this.loginPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPan
            // 
            this.loginPan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPan.Controls.Add(this.tberror);
            this.loginPan.Controls.Add(this.pictureBox1);
            this.loginPan.Controls.Add(this.cbAnzeigen);
            this.loginPan.Controls.Add(this.btnErstellen);
            this.loginPan.Controls.Add(this.btnAnmelden);
            this.loginPan.Controls.Add(this.label2);
            this.loginPan.Controls.Add(this.label1);
            this.loginPan.Controls.Add(this.tbPasswort);
            this.loginPan.Controls.Add(this.tbemail);
            this.loginPan.Location = new System.Drawing.Point(94, -4);
            this.loginPan.Name = "loginPan";
            this.loginPan.Size = new System.Drawing.Size(612, 458);
            this.loginPan.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cbAnzeigen
            // 
            this.cbAnzeigen.AutoSize = true;
            this.cbAnzeigen.Location = new System.Drawing.Point(239, 326);
            this.cbAnzeigen.Name = "cbAnzeigen";
            this.cbAnzeigen.Size = new System.Drawing.Size(116, 17);
            this.cbAnzeigen.TabIndex = 6;
            this.cbAnzeigen.Text = "Passwort Anzeigen";
            this.cbAnzeigen.UseVisualStyleBackColor = true;
            this.cbAnzeigen.CheckedChanged += new System.EventHandler(this.cbAnzeigen_CheckedChanged);
            // 
            // btnErstellen
            // 
            this.btnErstellen.Location = new System.Drawing.Point(30, 375);
            this.btnErstellen.Name = "btnErstellen";
            this.btnErstellen.Size = new System.Drawing.Size(203, 23);
            this.btnErstellen.TabIndex = 5;
            this.btnErstellen.Text = "Neues Konto erstellen";
            this.btnErstellen.UseVisualStyleBackColor = true;
            this.btnErstellen.Click += new System.EventHandler(this.btnErstellen_Click);
            // 
            // btnAnmelden
            // 
            this.btnAnmelden.Location = new System.Drawing.Point(30, 326);
            this.btnAnmelden.Name = "btnAnmelden";
            this.btnAnmelden.Size = new System.Drawing.Size(75, 23);
            this.btnAnmelden.TabIndex = 4;
            this.btnAnmelden.Text = "Anmelden";
            this.btnAnmelden.UseVisualStyleBackColor = true;
            this.btnAnmelden.Click += new System.EventHandler(this.btnAnmelden_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Passwort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-Mail";
            // 
            // tbPasswort
            // 
            this.tbPasswort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswort.Location = new System.Drawing.Point(117, 250);
            this.tbPasswort.Name = "tbPasswort";
            this.tbPasswort.Size = new System.Drawing.Size(203, 24);
            this.tbPasswort.TabIndex = 1;
            this.tbPasswort.UseSystemPasswordChar = true;
            // 
            // tbemail
            // 
            this.tbemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemail.Location = new System.Drawing.Point(117, 195);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(203, 24);
            this.tbemail.TabIndex = 0;
            // 
            // tberror
            // 
            this.tberror.AutoSize = true;
            this.tberror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tberror.ForeColor = System.Drawing.Color.Red;
            this.tberror.Location = new System.Drawing.Point(27, 294);
            this.tberror.Name = "tberror";
            this.tberror.Size = new System.Drawing.Size(252, 15);
            this.tberror.TabIndex = 13;
            this.tberror.Text = "Name oder Passwort sind flasch eingegeben";
            this.tberror.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginPan);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.loginPan.ResumeLayout(false);
            this.loginPan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbAnzeigen;
        private System.Windows.Forms.Button btnErstellen;
        private System.Windows.Forms.Button btnAnmelden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPasswort;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label tberror;
    }
}

