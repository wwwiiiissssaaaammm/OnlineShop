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
            this.label2 = new System.Windows.Forms.Label();
            this.tberror = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAnzeigen = new System.Windows.Forms.CheckBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbPasswort = new System.Windows.Forms.TextBox();
            this.btnErstellen = new System.Windows.Forms.Button();
            this.btnAnmelden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPan
            // 
            this.loginPan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPan.BackColor = System.Drawing.Color.Transparent;
            this.loginPan.Controls.Add(this.label2);
            this.loginPan.Controls.Add(this.tberror);
            this.loginPan.Controls.Add(this.label4);
            this.loginPan.Controls.Add(this.label3);
            this.loginPan.Controls.Add(this.cbAnzeigen);
            this.loginPan.Controls.Add(this.tbemail);
            this.loginPan.Controls.Add(this.tbPasswort);
            this.loginPan.Controls.Add(this.btnErstellen);
            this.loginPan.Controls.Add(this.btnAnmelden);
            this.loginPan.Controls.Add(this.label1);
            this.loginPan.Location = new System.Drawing.Point(12, 12);
            this.loginPan.Name = "loginPan";
            this.loginPan.Size = new System.Drawing.Size(409, 436);
            this.loginPan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(122, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Noch Kein Konto ?";
            // 
            // tberror
            // 
            this.tberror.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tberror.BackColor = System.Drawing.Color.Silver;
            this.tberror.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tberror.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tberror.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tberror.ForeColor = System.Drawing.Color.Red;
            this.tberror.Location = new System.Drawing.Point(44, 369);
            this.tberror.Name = "tberror";
            this.tberror.Size = new System.Drawing.Size(292, 55);
            this.tberror.TabIndex = 13;
            this.tberror.Text = "E-mail Adresse oder Passwort sind flasch eingegeben";
            this.tberror.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tberror.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(42, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Erstellen Sie ein neues Konto. wir freuen uns auf Sie!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Passwort";
            // 
            // cbAnzeigen
            // 
            this.cbAnzeigen.AutoSize = true;
            this.cbAnzeigen.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAnzeigen.Location = new System.Drawing.Point(209, 138);
            this.cbAnzeigen.Name = "cbAnzeigen";
            this.cbAnzeigen.Size = new System.Drawing.Size(134, 18);
            this.cbAnzeigen.TabIndex = 6;
            this.cbAnzeigen.Text = "Passwort Anzeigen";
            this.cbAnzeigen.UseVisualStyleBackColor = true;
            this.cbAnzeigen.CheckedChanged += new System.EventHandler(this.cbAnzeigen_CheckedChanged);
            // 
            // tbemail
            // 
            this.tbemail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemail.Location = new System.Drawing.Point(45, 47);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(298, 22);
            this.tbemail.TabIndex = 0;
            // 
            // tbPasswort
            // 
            this.tbPasswort.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswort.Location = new System.Drawing.Point(45, 110);
            this.tbPasswort.Name = "tbPasswort";
            this.tbPasswort.Size = new System.Drawing.Size(298, 22);
            this.tbPasswort.TabIndex = 1;
            this.tbPasswort.UseSystemPasswordChar = true;
            // 
            // btnErstellen
            // 
            this.btnErstellen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnErstellen.BackgroundImage")));
            this.btnErstellen.Location = new System.Drawing.Point(0, 277);
            this.btnErstellen.Name = "btnErstellen";
            this.btnErstellen.Size = new System.Drawing.Size(373, 28);
            this.btnErstellen.TabIndex = 5;
            this.btnErstellen.Text = "Neues Konto erstellen";
            this.btnErstellen.UseVisualStyleBackColor = true;
            this.btnErstellen.Click += new System.EventHandler(this.btnErstellen_Click);
            // 
            // btnAnmelden
            // 
            this.btnAnmelden.BackColor = System.Drawing.Color.LightCyan;
            this.btnAnmelden.Location = new System.Drawing.Point(95, 175);
            this.btnAnmelden.Name = "btnAnmelden";
            this.btnAnmelden.Size = new System.Drawing.Size(188, 27);
            this.btnAnmelden.TabIndex = 4;
            this.btnAnmelden.Text = "Anmelden";
            this.btnAnmelden.UseVisualStyleBackColor = false;
            this.btnAnmelden.Click += new System.EventHandler(this.btnAnmelden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 14.25F);
            this.label1.Location = new System.Drawing.Point(117, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-Mail Adresse";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.loginPan.ResumeLayout(false);
            this.loginPan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPan;
        private System.Windows.Forms.CheckBox cbAnzeigen;
        private System.Windows.Forms.Button btnErstellen;
        private System.Windows.Forms.Button btnAnmelden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPasswort;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label tberror;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

