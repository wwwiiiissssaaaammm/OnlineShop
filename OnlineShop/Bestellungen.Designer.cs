namespace OnlineShop
{
    partial class Bestellungen
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
            this.dgvBestllungen = new System.Windows.Forms.DataGridView();
            this.tbSuche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.tbBerechnen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestllungen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBestllungen
            // 
            this.dgvBestllungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestllungen.Location = new System.Drawing.Point(12, 51);
            this.dgvBestllungen.Name = "dgvBestllungen";
            this.dgvBestllungen.Size = new System.Drawing.Size(1391, 408);
            this.dgvBestllungen.TabIndex = 0;
            // 
            // tbSuche
            // 
            this.tbSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuche.Location = new System.Drawing.Point(85, 22);
            this.tbSuche.Name = "tbSuche";
            this.tbSuche.Size = new System.Drawing.Size(1318, 24);
            this.tbSuche.TabIndex = 1;
            this.tbSuche.TextChanged += new System.EventHandler(this.tbSuche_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Suchen";
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBerechnen.Location = new System.Drawing.Point(609, 475);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(94, 23);
            this.btnBerechnen.TabIndex = 5;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // tbBerechnen
            // 
            this.tbBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBerechnen.Location = new System.Drawing.Point(742, 474);
            this.tbBerechnen.Name = "tbBerechnen";
            this.tbBerechnen.ReadOnly = true;
            this.tbBerechnen.Size = new System.Drawing.Size(100, 24);
            this.tbBerechnen.TabIndex = 4;
            this.tbBerechnen.TextChanged += new System.EventHandler(this.tbBerechnen_TextChanged);
            // 
            // Bestellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 594);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.tbBerechnen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSuche);
            this.Controls.Add(this.dgvBestllungen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Bestellungen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestellungen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestllungen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBestllungen;
        private System.Windows.Forms.TextBox tbSuche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.TextBox tbBerechnen;
    }
}