using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OnlineShop
{
    public partial class produkteverwalten : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost; UID=root; Database=OnlineShop; PASSWORD='';");
        Datenbank db = new Datenbank();
        List<Kategorie> lsKategorie;
        public produkteverwalten()

        {
            InitializeComponent();
            Filldgv(tbSuche.Text);
            anzeigen();
        }

        public void anzeigen()
        {
            cbKategorie.Items.Clear();
            lsKategorie = db.kategorieHolen();
            foreach (Kategorie n in lsKategorie)
                cbKategorie.Items.Add(n.Bezichnung);
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


        private void btn_hinzufuegen_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbBeschreibung.Text))
            {
                MessageBox.Show("Bitte Füllen Sie aller Felder aus");
            }
            else if (String.IsNullOrEmpty(tbPreis.Text))
            {
                MessageBox.Show("Bitte Füllen Sie aller Felder aus");
            }
            else if (String.IsNullOrEmpty(tb_ProduktName.Text))
            {
                MessageBox.Show("Bitte Füllen Sie aller Felder aus");
            }
            else if (String.IsNullOrEmpty(cbKategorie.Text))
            {
                MessageBox.Show("Bitte Füllen Sie aller Felder aus");
            }
            else if (picBild.Image == null)
            {
                MessageBox.Show("Laden Sie Bitte ein Bild hoch");
            }
            else
            {

                MemoryStream ms = new MemoryStream();
                picBild.Image.Save(ms, picBild.Image.RawFormat);
                byte[] img = ms.ToArray();
                string insert = "insert into produkte(Kategorie_id, Bezeichnung, Beschreibung, Preis, Foto) values(@kat_ID ,@bez, @Bes, @preis, @img);";



                conn.Open();
                MySqlCommand cmd = new MySqlCommand(insert, conn);

                cmd.Parameters.Add("@kat_ID", MySqlDbType.Int32, 100);
                cmd.Parameters.Add("@bez", MySqlDbType.VarChar, 100);
                cmd.Parameters.Add("@Bes", MySqlDbType.VarChar, 100);
                cmd.Parameters.Add("@preis", MySqlDbType.Double);
                cmd.Parameters.Add("@img", MySqlDbType.Blob);

                cmd.Parameters["@kat_ID"].Value = lsKategorie [cbKategorie.SelectedIndex].KatId;
                cmd.Parameters["@bez"].Value = tb_ProduktName.Text;

                cmd.Parameters["@Bes"].Value = tbBeschreibung.Text;
                cmd.Parameters["@preis"].Value = tbPreis.Text;

                cmd.Parameters["@img"].Value = img;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Daten sind hinzugefügt");
                this.Hide();
                produkteverwalten form = new produkteverwalten();
                form.ShowDialog();

                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picBild.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void Filldgv(string suchwert)
        {


            MySqlCommand cmd = new MySqlCommand("select produkte.Produkt_id, produkte.Bezeichnung as'Produkt_Name', kategorie.Bezeichnung,  produkte.Beschreibung, produkte.Preis, produkte.Foto  from produkte left join kategorie on kategorie.Kategorie_id = produkte.Kategorie_id where produkte.Bezeichnung like '%"+tbSuche.Text+"%' ; ", conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvProdukte.AllowUserToAddRows = false;
            dgvProdukte.DataSource = table;

            dgvProdukte.RowTemplate.Height = 100;

            DataGridViewImageColumn dgimco = new DataGridViewImageColumn();

            dgimco = (DataGridViewImageColumn)dgvProdukte.Columns[5];
            dgimco.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvProdukte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void btn_loeschen_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Möchten Sie Die Aktikel " + tb_ProduktName.Text + " wirklich löschen ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {

                string delete;
                delete = "delete from produkte where Produkt_id = '" + tbID.Text + "';";
                excutequery(delete);
                this.Hide();
                produkteverwalten form = new produkteverwalten();
                form.ShowDialog();
            }
        }

        private void dgvProdukte_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProdukte.CurrentRow != null)
            {
                tbID.Text = dgvProdukte.CurrentRow.Cells[0].Value.ToString();
                tb_ProduktName.Text = dgvProdukte.CurrentRow.Cells[1].Value.ToString();
                cbKategorie.Text = dgvProdukte.CurrentRow.Cells[2].Value.ToString();
                tbBeschreibung.Text = dgvProdukte.CurrentRow.Cells[3].Value.ToString();
                tbPreis.Text = dgvProdukte.CurrentRow.Cells[4].Value.ToString();

            }
        }

        private void btn_bearbeiten_Click(object sender, EventArgs e)
        {
            //toDo picture update

            if (picBild.Image == null)
            {
                MessageBox.Show("Laden Sie bitte ein neues Bild hoch");
            }
            else{
                MemoryStream ms = new MemoryStream();
                picBild.Image.Save(ms, picBild.Image.RawFormat);
                byte[] img = ms.ToArray();
                string update = "update produkte set Kategorie_id = @kat_ID, Bezeichnung = @bez, Beschreibung = @Bes, Preis = @preis, Foto = @img where Produkt_id = " + tbID.Text + " ; ";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(update, conn);

                cmd.Parameters.Add("@kat_ID", MySqlDbType.Int32, 100);
                cmd.Parameters.Add("@bez", MySqlDbType.VarChar, 100);
                cmd.Parameters.Add("@Bes", MySqlDbType.VarChar, 100);
                cmd.Parameters.Add("@preis", MySqlDbType.Double);
                cmd.Parameters.Add("@img", MySqlDbType.Blob);

                cmd.Parameters["@kat_ID"].Value = lsKategorie[cbKategorie.SelectedIndex].KatId;
                cmd.Parameters["@bez"].Value = tb_ProduktName.Text;

                cmd.Parameters["@Bes"].Value = tbBeschreibung.Text;
                cmd.Parameters["@preis"].Value = tbPreis.Text;

                cmd.Parameters["@img"].Value = img;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Daten sind bearbeitet");
                this.Hide();
                produkteverwalten form = new produkteverwalten();
                form.ShowDialog();

                conn.Close();
            }
        }

        private void btn_Datenleeren_Click(object sender, EventArgs e)
        {
            tbBeschreibung.Text = "";
            tbID.Text = "";
            tbPreis.Text = "";
            tb_ProduktName.Text = "";
            cbKategorie.Text = "";
            picBild.Image = null;
        }

        private void tbSuche_TextChanged(object sender, EventArgs e)
        {
            Filldgv(tbSuche.Text);

        }

        private void pbzuruck_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminStartSeite adminStartSeite = new AdminStartSeite();
            adminStartSeite.ShowDialog();
        }

        private void btnKundenDaten_Click(object sender, EventArgs e)
        {
            this.Hide();
            kundenDatenA kundenDatenA = new kundenDatenA();
            kundenDatenA.ShowDialog();
        }

        private void btnBestellungen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bestellungen bestellungen = new Bestellungen();
            bestellungen.ShowDialog();
        }

        private void btnAbmelden_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
