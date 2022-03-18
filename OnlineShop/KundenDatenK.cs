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
    public partial class KundenDatenK : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost; UID=root; Database=OnlineShop; PASSWORD='';");

        private int kundenid;

        public KundenDatenK(int kundenid)
        {
            this.kundenid = kundenid;
            InitializeComponent();
            FillDgv();
        }
        public void FillDgv()
        {
            {
                MySqlCommand cmd = new MySqlCommand("select Kunde_ID,vorname ,nachname, email, ort, strasse, Hausnummer, plz, Telefonnummer from OnlineShop.kunde where Kunde_ID = " + kundenid + " ; ", conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();

                adapter.Fill(table);
                dgvKundenDatenK.DataSource = table;

            }

        }


        private void dgvKundenDatenK_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKundenDatenK.CurrentCell != null)
            {
                //tbID.Text = dgvProdukte.CurrentRow.Cells[0].Value.ToString();

                tbId.Text = dgvKundenDatenK.CurrentRow.Cells[0].Value.ToString();
                tbVorname.Text = dgvKundenDatenK.CurrentRow.Cells[1].Value.ToString();
                tbNachname.Text = dgvKundenDatenK.CurrentRow.Cells[2].Value.ToString();
                tbEmail.Text = dgvKundenDatenK.CurrentRow.Cells[3].Value.ToString();
                tbOrt.Text = dgvKundenDatenK.CurrentRow.Cells[4].Value.ToString();
                tbStr.Text = dgvKundenDatenK.CurrentRow.Cells[5].Value.ToString();
                tbHnr.Text = dgvKundenDatenK.CurrentRow.Cells[6].Value.ToString();
                tbPlz.Text = dgvKundenDatenK.CurrentRow.Cells[7].Value.ToString();
                tbTel.Text = dgvKundenDatenK.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbVorname.BackColor = Color.PowderBlue;
            tbNachname.BackColor = Color.PowderBlue;
            tbOrt.BackColor = Color.PowderBlue;
            tbPlz.BackColor = Color.PowderBlue;
            tbStr.BackColor = Color.PowderBlue;
            tbHnr.BackColor = Color.PowderBlue;
            tbTel.BackColor = Color.PowderBlue;


            tbVorname.ReadOnly = false;
            tbNachname.ReadOnly = false;
            tbOrt.ReadOnly = false;
            tbPlz.ReadOnly = false;
            tbStr.ReadOnly = false;
            tbHnr.ReadOnly = false;
            tbTel.ReadOnly = false;


            tbNachname.ReadOnly = false;

            btnSpeichern.Enabled = true;
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

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            string update;
            update = "update OnlineShop.kunde set vorname = '" + tbVorname.Text + "', nachname = '" + tbNachname.Text + "', email = '" + tbEmail.Text + "', strasse = '" + tbStr.Text + "', Hausnummer = '" + tbHnr.Text + "', plz = '" + tbPlz.Text + "', Telefonnummer = '" + tbTel.Text + "' where Kunde_ID = '" + tbId.Text + "'";
            excutequery(update);
          
        }
    }
}
