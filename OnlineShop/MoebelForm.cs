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
    public partial class MoebelForm : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost; UID=root; Database=OnlineShop; PASSWORD='';");

        private int kundenid;


        public MoebelForm(int kundenid)
        {
           this.kundenid = kundenid;
        InitializeComponent();
            FillDgv(tbSuche.Text);
        }

        public void FillDgv(string suchwert)
        {
            MySqlCommand cmd = new MySqlCommand("select Produkt_id ,Bezeichnung, Beschreibung, Preis , Foto from produkte where Kategorie_id = 1 and Bezeichnung like '%"+tbSuche.Text+"%' ;", conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvMoebel.AllowUserToAddRows = false;
            dgvMoebel.DataSource = table;

            dgvMoebel.RowTemplate.Height = 100;

            DataGridViewImageColumn dgimco = new DataGridViewImageColumn();

            dgimco = (DataGridViewImageColumn)dgvMoebel.Columns[4];
            dgimco.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvMoebel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (countMenge.Value == 0)
            {
                MessageBox.Show("Bitte wählen Sie die Menge aus");
                countMenge.BackColor = Color.Red;
            }
            else if (dgvMoebel.SelectedRows.Count == 0)
            {

                MessageBox.Show("Bitte ein Produkt auswählen", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading, "help.pdf");
            }
            else
            {
                countMenge.BackColor = Color.White;
                double preis = Convert.ToDouble(dgvMoebel.SelectedRows[0].Cells[3].Value);
                int menge = Convert.ToInt32(countMenge.Value);
                tbSummePreis.Text = Convert.ToString(preis * menge);

                string insert = "INSERT INTO onlineshop.kunde_produkte(Kunde_id,Produkt_id,Menge,preis,Datum)VALUES( @Kunde_id , @Produkt_id, @Menge ,@preis , now() ); ";



                conn.Open();
                MySqlCommand cmd = new MySqlCommand(insert, conn);

                cmd.Parameters.Add("@Kunde_id", MySqlDbType.Int32, 100);
                cmd.Parameters.Add("@Produkt_id", MySqlDbType.Int32, 100);
                cmd.Parameters.Add("@Menge", MySqlDbType.Int32, 100);
                cmd.Parameters.Add("@preis", MySqlDbType.Double);

                cmd.Parameters["@Kunde_id"].Value = kundenid;
                cmd.Parameters["@Produkt_id"].Value = dgvMoebel.SelectedRows[0].Cells[0].Value;
                cmd.Parameters["@Menge"].Value = menge;
                cmd.Parameters["@preis"].Value = preis * menge;

                cmd.ExecuteNonQuery();


                countMenge.Value = 0;


                MessageBox.Show("Daten sind in Warenkorb hinzugefügt");
                conn.Close();

            }


        
    }

        private void dgvGeraete_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMoebel.CurrentCell != null)
            {
                tbProduktName.Text = dgvMoebel.CurrentRow.Cells[1].Value.ToString();
                tbBeschreibung.Text = dgvMoebel.CurrentRow.Cells[2].Value.ToString();
                tbPreis.Text = dgvMoebel.CurrentRow.Cells[3].Value.ToString();
                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (sideBar.Size.Width == 63)
            {
                sideBar.Size = new Size(234, 595);
                this.sideBar.BackColor = Color.FromArgb(105, 105, 105, 100);

                label6.Text = "Menu";
                label6.ForeColor = Color.Black;
                label6.BackColor = Color.Transparent;

                btnMeineDaten.BackColor = Color.Pink;
                btnMeineDaten.Width = 223;
                btnMeineDaten.Text = "             Meine Daten";

                tbstartseite.BackColor = Color.Pink;
                tbstartseite.Width = 223;
                tbstartseite.Text = "             Home";


                tbGeraete.BackColor = Color.Pink;
                tbGeraete.Width = 223;
                tbGeraete.Text = "             Geräte";

                tbMoebel.BackColor = Color.Pink;
                tbMoebel.Width = 223;
                tbMoebel.Text = "             Möbel";

                tbKleidung.BackColor = Color.Pink;
                tbKleidung.Width = 223;
                tbKleidung.Text = "             Kleidung";

                btnWarenkorb.BackColor = Color.Pink;
                btnWarenkorb.Width = 223;
                btnWarenkorb.Text = "             Warenkorb";

                tbBestellung.BackColor = Color.Pink;
                tbBestellung.Width = 223;
                tbBestellung.Text = "             Meine Bestellungen";

                tbAbmelden.BackColor = Color.Pink;
                tbAbmelden.Width = 223;
                tbAbmelden.Text = "             Abmelden";


                dgvMoebel.Size = new Size(881, 460);
                dgvMoebel.Location = new Point(240, 45);
                tbSuche.Size = new Size(746, 24);
                tbSuche.Location = new Point(306, 15);




            }
            else
            {

                sideBar.Size = new Size(63, 592);
                sideBar.BackColor = Color.Transparent;
                label6.Text = "";

                btnMeineDaten.BackColor = Color.Gray;
                btnMeineDaten.Text = "";
                btnMeineDaten.Width = 60;

                tbstartseite.BackColor = Color.Gray;
                tbstartseite.Text = "";
                tbstartseite.Width = 60;


                tbGeraete.BackColor = Color.Gray;
                tbGeraete.Text = "";
                tbGeraete.Width = 60;

                tbMoebel.BackColor = Color.Gray;
                tbMoebel.Width = 60;
                tbMoebel.Text = "";

                tbKleidung.BackColor = Color.Gray;
                tbKleidung.Width = 60;
                tbKleidung.Text = "";

                btnWarenkorb.BackColor = Color.Gray;
                btnWarenkorb.Width = 60;
                btnWarenkorb.Text = "";

                tbBestellung.BackColor = Color.Gray;
                tbBestellung.Width = 60;
                tbBestellung.Text = "";

                tbAbmelden.BackColor = Color.Gray;
                tbAbmelden.Width = 60;
                tbAbmelden.Text = "";

                dgvMoebel.Size = new Size(966, 460);
                dgvMoebel.Location = new Point(155, 45);
                tbSuche.Size = new Size(746, 24);
                tbSuche.Location = new Point(268, 15);


            }
        }

        

        private void btnMeineDaten_Click(object sender, EventArgs e)
        {
            this.Hide();
            KundenDatenK kundenDaten = new KundenDatenK(kundenid);
            kundenDaten.ShowDialog();
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



        private void btnDetail_Click_1(object sender, EventArgs e)
        {
            if (panel.Visible == true)
            {
                panel.Visible = false;
                btnDetail.Text = "Show more Details";
                btnDetail.Location = new Point(1147, 144);

            }
            else if (panel.Visible == false)
            {
                panel.Visible = true;
                btnDetail.Text = "Show less Details";
                btnDetail.Location = new Point(1154, 251);

            }
        }
    }
}
