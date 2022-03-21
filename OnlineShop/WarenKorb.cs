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
    public partial class WarenKorb : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost; UID=root; Database=OnlineShop; PASSWORD='';");

        private int Kundenid;
        public WarenKorb(int kundenid)
        {
            this.Kundenid = kundenid;
            InitializeComponent();
            fillDgv();
        }

        public void fillDgv()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("select k.Kunde_ID, p.Bezeichnung, kp.Menge, kp.preis, kp.Datum from Kunde_Produkte kp left join produkte p on kp.Produkte_id = p.Produkt_id left join kunde k on kp.Kunde_id = k.Kunde_ID where kp.Kunde_id = "+Kundenid+" ; ",conn);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            dgvBestellungen.DataSource = tbl;
        }

        private void WarenKorb_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnBestellen.Enabled = true;
            double sum = 0.00;
            for (int i = 0; i < dgvBestellungen.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dgvBestellungen.Rows[i].Cells[4].Value);
            }
            tbBerechnen.Text = sum.ToString();
        }

        private void btnBestellen_Click(object sender, EventArgs e)
        {
            //MySqlCommand cmd;
            //conn.Open();

            //for (int i = 0; i < dgvBestellungen.Rows.Count - 1; i++)
            //{
            //    cmd = new MySqlCommand("insert into bestellung(Kunde_id, Produkte_id, Menge, preis, Datum) values(@Kid, @pID, @menge, @preis, @dat);", conn);

            //    cmd.Parameters.Add("@Kid", MySqlDbType.Int32).Value = dgvBestellungen.Rows[i].Cells[1].Value.ToString();
            //    cmd.Parameters.Add("@pID", MySqlDbType.Int32).Value = dgvBestellungen.Rows[i].Cells[3].Value.ToString();
            //    cmd.Parameters.Add("@menge", MySqlDbType.Int32).Value = dgvBestellungen.Rows[i].Cells[4].Value.ToString();
            //    cmd.Parameters.Add("@preis", MySqlDbType.Double).Value = dgvBestellungen.Text;
            //    cmd.Parameters.Add("@dat", MySqlDbType.Datetime).Value = dgvBestellungen.Text;




            //    cmd.ExecuteNonQuery();
            //}
        }

        private void dgvBestellungen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBestellungen.CurrentRow != null)
            {
                dgvBestellungen.Rows.RemoveAt(dgvBestellungen.CurrentCell.ColumnIndex);
            }
        }
    }
}
