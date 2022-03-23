using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OnlineShop
{
    public partial class Bestellungen : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost; UID=root; Database=OnlineShop; PASSWORD='';");

        public Bestellungen()
        {
            InitializeComponent();
            FillDgv(tbSuche.Text);
        }

        public void FillDgv(string suchwert)
        {
            MySqlCommand cmd = new MySqlCommand(@"select bs.Bestellung_ID, k.Kunde_ID, k.vorname, k.nachname, k.email, bs.Bezeichnung,  bs.Menge, bs.preis, bs.Datum, p.Foto from bestellung bs
 join kunde k on bs.Kunde_id = k.Kunde_ID
 join produkte p on bs.Produkt_id = p.Produkt_id where Bestellung_ID like '%"+tbSuche.Text+"%' or email like '%"+tbSuche.Text+"%' ; ", conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvBestllungen.AllowUserToAddRows = false;
            dgvBestllungen.DataSource = table;

            dgvBestllungen.RowTemplate.Height = 100;

            DataGridViewImageColumn dgimco = new DataGridViewImageColumn();

            dgimco = (DataGridViewImageColumn)dgvBestllungen.Columns[9];
            dgimco.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvBestllungen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void tbSuche_TextChanged(object sender, EventArgs e)
        {
            FillDgv(tbSuche.Text);

        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            dgvBestllungen.Enabled = true;
            double sum = 0.00;
            for (int i = 0; i < dgvBestllungen.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dgvBestllungen.Rows[i].Cells[7].Value);
            }
            tbBerechnen.Text = sum.ToString();
        }

        private void tbBerechnen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
