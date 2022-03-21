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
    public partial class KleidungsForm : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost; UID=root; Database=OnlineShop; PASSWORD='';");
        private int kundenid;
        public KleidungsForm(int kundenid)
        {
            InitializeComponent();
            this.kundenid = kundenid;
            FillDgv(tbSuche.Text);
        }

        public void FillDgv(string suchwert)
        {
            MySqlCommand cmd = new MySqlCommand("select Produkt_id ,Bezeichnung, Beschreibung, Preis , Foto from produkte where Kategorie_id = 2 and Bezeichnung like '%"+tbSuche.Text+"%' ;", conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvKleidung.AllowUserToAddRows = false;
            dgvKleidung.DataSource = table;

            dgvKleidung.RowTemplate.Height = 100;

            DataGridViewImageColumn dgimco = new DataGridViewImageColumn();

            dgimco = (DataGridViewImageColumn)dgvKleidung.Columns[4];
            dgimco.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvKleidung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (countMenge.Value == 0)
            {
                MessageBox.Show("Bitte wählen Sie die Menge aus");
                countMenge.BackColor = Color.Red;
            }
            else if (dgvKleidung.SelectedRows.Count == 0)
            {

                MessageBox.Show("Bitte ein Produkt auswählen", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading, "help.pdf");
            }
            else
            {
                countMenge.BackColor = Color.White;
                double preis = Convert.ToDouble(dgvKleidung.SelectedRows[0].Cells[3].Value);
                int menge = Convert.ToInt32(countMenge.Value);
                tbSummePreis.Text = Convert.ToString(preis * menge);

                string insert = "INSERT INTO onlineshop.kunde_produkte(Kunde_id,Produkte_id,Menge,preis,Datum)VALUES( @Kunde_id , @Produkte_id, @Menge ,@preis , now() ); ";



                conn.Open();
                MySqlCommand cmd = new MySqlCommand(insert, conn);

                cmd.Parameters.Add("@Kunde_id", MySqlDbType.Int32, 100);
                cmd.Parameters.Add("@Produkte_id", MySqlDbType.Int32, 100);
                cmd.Parameters.Add("@Menge", MySqlDbType.Int32, 100);
                cmd.Parameters.Add("@preis", MySqlDbType.Double);

                cmd.Parameters["@Kunde_id"].Value = kundenid;
                cmd.Parameters["@Produkte_id"].Value = dgvKleidung.SelectedRows[0].Cells[0].Value;
                cmd.Parameters["@Menge"].Value = menge;
                cmd.Parameters["@preis"].Value = preis * menge;

                cmd.ExecuteNonQuery();


                countMenge.Value = 0;


                MessageBox.Show("Daten sind in Warenkorb hinzugefügt");
                conn.Close();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sideBar.Size = new Size(234, 450);
            dgvKleidung.Size = new Size(629, 363);
            dgvKleidung.Location = new Point(312, 43);
            lbSuche.Location = new Point(238, 13);
            tbSuche.Location = new Point(307, 10);
            tbSuche.Size = new Size(634, 24);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sideBar.Size = new Size(72, 450);
            dgvKleidung.Size = new Size(791, 363);
            dgvKleidung.Location = new Point(93, 43);
            lbSuche.Location = new Point(90, 13);
            tbSuche.Location = new Point(154, 10);
            tbSuche.Size = new Size(787, 24); 
        }

        private void tbGeraete_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeraetsForm geraets = new GeraetsForm(kundenid);
            geraets.ShowDialog();
        }

        private void tbMoebel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoebelForm form = new MoebelForm(kundenid);
            form.ShowDialog();
        }

        private void tbKleidung_Click(object sender, EventArgs e)
        {
            this.Hide();
            KleidungsForm form = new KleidungsForm(kundenid);
            form.ShowDialog();
        }

        private void tbAbmelden_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Möchten Sie wirklich abmelden", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                this.Hide();
                LoginForm form = new LoginForm();
                form.ShowDialog();
            }
        }

        private void btnMeineDaten_Click(object sender, EventArgs e)
        {
            this.Hide();
            KundenDatenK kundenDaten = new KundenDatenK(kundenid);
            kundenDaten.ShowDialog();
        }

        private void tbSuche_TextChanged(object sender, EventArgs e)
        {
            FillDgv(tbSuche.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WarenKorb warenKorb = new WarenKorb(kundenid);
            warenKorb.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            WarenKorb waren = new WarenKorb(kundenid);
            waren.ShowDialog();
        }

        private void dgvKleidung_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKleidung.CurrentCell != null)
            {
                tbProduktName.Text = dgvKleidung.CurrentRow.Cells[1].Value.ToString();
                tbBeschreibung.Text = dgvKleidung.CurrentRow.Cells[2].Value.ToString();
                tbPreis.Text = dgvKleidung.CurrentRow.Cells[3].Value.ToString();

            }
        }
    }
}
