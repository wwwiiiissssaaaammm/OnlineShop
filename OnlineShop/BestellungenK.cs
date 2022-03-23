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
    public partial class BestellungenK : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost; UID=root; Database=OnlineShop; PASSWORD='';");
        private int kundenid;
        public BestellungenK(int kundenid)
        {
            this.kundenid = kundenid;
            InitializeComponent();
            FillDgv();
        }

        public void FillDgv()
        {
            MySqlCommand cmd = new MySqlCommand(@" select bs.Bestellung_ID, k.Kunde_ID, k.vorname, k.nachname, k.email, bs.Bezeichnung,  bs.Menge, bs.preis, bs.Datum, p.Foto from bestellung bs
 join kunde k on bs.Kunde_id = k.Kunde_ID
 join produkte p on bs.Produkt_id = p.Produkt_id
where k.Kunde_ID = " + kundenid+"; ", conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();
            

            adapter.Fill(table);

            dgvBestellungen.AllowUserToAddRows = false;
            dgvBestellungen.DataSource = table;

            dgvBestellungen.RowTemplate.Height = 100;

            DataGridViewImageColumn dgimco = new DataGridViewImageColumn();

            dgimco = (DataGridViewImageColumn)dgvBestellungen.Columns[9];
            dgimco.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvBestellungen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnzuruck_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartSeiteK startSeiteK = new StartSeiteK(kundenid);
            startSeiteK.ShowDialog();
        }
    }
}
