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
    public partial class kundenDatenA : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost; UID=root; Database=OnlineShop; PASSWORD='';");

        public kundenDatenA()
        {
            InitializeComponent();
        }

       //public void fillDgv(string suchwert)
       // {
       //     MySqlDataAdapter adapter = new MySqlDataAdapter("select Kunde_ID, vorname, nachname, email, ort, strasse, plz, Telefonnummer from kunde where vorname = '"+tbSuche.Text+"';", conn);
       //     DataTable tbl = new DataTable();
       //     adapter.Fill(tbl);
       //     dgvKundenDaten.DataSource = tbl;
       // }

        

        DataTable tbl = new DataTable();


        private void kundenDatenA_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("select  concat ('',Kunde_ID) as kid, vorname, nachname, email, ort, strasse, Hausnummer, plz, Telefonnummer from kunde where ist_Admin = 0; ", conn);
            adapter.Fill(tbl);
            dgvKundenDaten.DataSource = tbl;

        }

        private void tbSuche_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(tbl);
            if (tbSuche.Text.Length > 0)
            {
                dv.RowFilter = "vorname like '%" + tbSuche.Text + "%' or kid  like '%" + tbSuche.Text + "%' ";
            }
            dgvKundenDaten.DataSource = dv;
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            tbVorname.BackColor = Color.PowderBlue;
            tbNachname.BackColor = Color.PowderBlue;
            tbOrt.BackColor = Color.PowderBlue;
            tbPlz.BackColor = Color.PowderBlue;
            tbStr.BackColor = Color.PowderBlue;
            tbHnr.BackColor = Color.PowderBlue;
            tbTele.BackColor = Color.PowderBlue;
            tbEmail.BackColor = Color.PowderBlue;


            tbVorname.ReadOnly = false;
            tbNachname.ReadOnly = false;
            tbOrt.ReadOnly = false;
            tbPlz.ReadOnly = false;
            tbStr.ReadOnly = false;
            tbHnr.ReadOnly = false;
            tbTele.ReadOnly = false;
            tbEmail.ReadOnly = false;


            btnSpeichern.Enabled = true;
        }

        private void dgvKundenDaten_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKundenDaten.CurrentCell != null)
            {
                //tbID.Text = dgvProdukte.CurrentRow.Cells[0].Value.ToString();

                tbID.Text = dgvKundenDaten.CurrentRow.Cells[0].Value.ToString();
                tbVorname.Text = dgvKundenDaten.CurrentRow.Cells[1].Value.ToString();
                tbNachname.Text = dgvKundenDaten.CurrentRow.Cells[2].Value.ToString();
                tbEmail.Text = dgvKundenDaten.CurrentRow.Cells[3].Value.ToString();
                tbOrt.Text = dgvKundenDaten.CurrentRow.Cells[4].Value.ToString();
                tbStr.Text = dgvKundenDaten.CurrentRow.Cells[5].Value.ToString();
                tbHnr.Text = dgvKundenDaten.CurrentRow.Cells[6].Value.ToString();
                tbPlz.Text = dgvKundenDaten.CurrentRow.Cells[7].Value.ToString();
                tbTele.Text = dgvKundenDaten.CurrentRow.Cells[8].Value.ToString();
            }
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
            DialogResult dr;
            dr = MessageBox.Show("Möchten Sie wirklichihre Daten ändern", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string update;
                update = "update OnlineShop.kunde set vorname = '" + tbVorname.Text + "', nachname = '" + tbNachname.Text + "', email = '" + tbEmail.Text + "', strasse = '" + tbStr.Text + "', Hausnummer = '" + tbHnr.Text + "', plz = '" + tbPlz.Text + "', Telefonnummer = '" + tbTele.Text + "' where Kunde_ID = '" + tbID.Text + "'";
                excutequery(update);
                this.Hide();
                kundenDatenA kunden = new kundenDatenA();
                kunden.ShowDialog();
            }
        }

        private void pbzuruck_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminStartSeite adminStartSeite = new AdminStartSeite();
            adminStartSeite.ShowDialog();
        }

        private void btnBestellungen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bestellungen bestellungen = new Bestellungen();
            bestellungen.ShowDialog();
        }

        private void btnProdukteVerwalten_Click(object sender, EventArgs e)
        {
            this.Hide();
            produkteverwalten p = new produkteverwalten();
            p.ShowDialog();
        }

        private void btnAbmelden_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
