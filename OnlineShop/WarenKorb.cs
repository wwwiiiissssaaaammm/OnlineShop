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
            MySqlDataAdapter adapter = new MySqlDataAdapter(" select kp.Bestellung_ID, k.Kunde_ID, p.Bezeichnung, kp.Menge, kp.preis, kp.Datum from Kunde_Produkte kp left join produkte p on kp.Produkte_id = p.Produkt_id left join kunde k on kp.Kunde_id = k.Kunde_ID where kp.Kunde_id = "+Kundenid+" ; ",conn);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            dgvBestellungen.DataSource = tbl;
        }

        private void WarenKorb_Load(object sender, EventArgs e)
        {

        }

        public void excutequery(string query)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {

                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            btnBestellen.Enabled = true;
            double sum = 0.00;
            for (int i = 0; i < dgvBestellungen.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dgvBestellungen.Rows[i].Cells["preis"].Value);
            }
            tbBerechnen.Text = sum.ToString();
        }

        private void btnBestellen_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            conn.Open();

            for (int i = 0; i < dgvBestellungen.Rows.Count - 1; i++)
            {
                cmd = new MySqlCommand("insert into OnlineShop.bestellung (Kunde_id, Bezeichnung, Menge, preis, Datum) values(" + Kundenid + ",@bez,@menge,@preis, now())", conn);
                cmd.Parameters.AddWithValue("bez", dgvBestellungen.Rows[i].Cells["Bezeichnung"].Value.ToString());
                cmd.Parameters.AddWithValue("menge", dgvBestellungen.Rows[i].Cells["Menge"].Value.ToString());
                cmd.Parameters.AddWithValue("preis", dgvBestellungen.Rows[i].Cells["preis"].Value.ToString());
                //cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Vielen Dank für ihre Bestellung die Produkte sind bestellt");
            conn.Close();

            string delete;
            delete = " delete from kunde_produkte where Kunde_id = '" + Kundenid + "'";
            excutequery(delete);
            this.Hide();
            StartSeiteK startSeiteK = new StartSeiteK(Kundenid);
            startSeiteK.ShowDialog();


        }

        private void dgvBestellungen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBestellungen.CurrentRow != null)
            {
                dgvBestellungen.Rows.RemoveAt(dgvBestellungen.CurrentCell.ColumnIndex);
            }
        }

        private void tbBerechnen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
