namespace OnlineShop
{
    partial class BestellungenK
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
            this.dgvBestellungen = new System.Windows.Forms.DataGridView();
            this.btnzuruck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestellungen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBestellungen
            // 
            this.dgvBestellungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestellungen.Location = new System.Drawing.Point(13, 13);
            this.dgvBestellungen.Name = "dgvBestellungen";
            this.dgvBestellungen.ReadOnly = true;
            this.dgvBestellungen.Size = new System.Drawing.Size(1062, 452);
            this.dgvBestellungen.TabIndex = 0;
            // 
            // btnzuruck
            // 
            this.btnzuruck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnzuruck.Location = new System.Drawing.Point(13, 484);
            this.btnzuruck.Name = "btnzuruck";
            this.btnzuruck.Size = new System.Drawing.Size(177, 32);
            this.btnzuruck.TabIndex = 52;
            this.btnzuruck.Text = "Zurück zum Start Seite";
            this.btnzuruck.UseVisualStyleBackColor = true;
            this.btnzuruck.Click += new System.EventHandler(this.btnzuruck_Click);
            // 
            // BestellungenK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 594);
            this.Controls.Add(this.btnzuruck);
            this.Controls.Add(this.dgvBestellungen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BestellungenK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BestellungenK";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestellungen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBestellungen;
        private System.Windows.Forms.Button btnzuruck;
    }
}