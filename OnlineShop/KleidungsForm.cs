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
            dgimco.ImageLayout = DataGridViewImageCellLayout.Zoom;
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

                tbWarenkorb.BackColor = Color.Pink;
                tbWarenkorb.Width = 223;
                tbWarenkorb.Text = "             Warenkorb";

                tbBestellung.BackColor = Color.Pink;
                tbBestellung.Width = 223;
                tbBestellung.Text = "             Meine Bestellungen";

                tbAbmelden.BackColor = Color.Pink;
                tbAbmelden.Width = 223;
                tbAbmelden.Text = "             Abmelden";


                dgvKleidung.Size = new Size(881, 460);
                dgvKleidung.Location = new Point(240, 45);
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

                tbWarenkorb.BackColor = Color.Gray;
                tbWarenkorb.Width = 60;
                tbWarenkorb.Text = "";

                tbBestellung.BackColor = Color.Gray;
                tbBestellung.Width = 60;
                tbBestellung.Text = "";

                tbAbmelden.BackColor = Color.Gray;
                tbAbmelden.Width = 60;
                tbAbmelden.Text = "";

                dgvKleidung.Size = new Size(966, 460);
                dgvKleidung.Location = new Point(155, 45);
                tbSuche.Size = new Size(746, 24);
                tbSuche.Location = new Point(268, 15);


            }
        
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

        private void btnDetail_Click(object sender, EventArgs e)
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

        private void tbBestellung_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellungenK form = new BestellungenK();
            form.ShowDialog();
        }

        private void tbstartseite_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartSeiteK form = new StartSeiteK(kundenid);
            form.ShowDialog();
        }

        private void btnMeineDaten_MouseEnter(object sender, EventArgs e)
        {
            if (btnMeineDaten.Width < 70)
            {
                btnMeineDaten.BackColor = Color.Pink;
            }
            else if (btnMeineDaten.Width > 200)
            {
                btnMeineDaten.BackColor = Color.White;
            }
        }
        private void btnMeineDaten_MouseLeave(object sender, EventArgs e)
        {
            if (btnMeineDaten.Width < 70)
            {
                btnMeineDaten.BackColor = Color.Gray;
            }
            else if (btnMeineDaten.Width > 200)
            {
                btnMeineDaten.BackColor = Color.Pink;
            }

        }
        private void btnstartseite_MouseEnter(object sender, EventArgs e)
        {
            if (tbstartseite.Width < 70)
            {
                tbstartseite.BackColor = Color.Pink;
            }
            else if (tbstartseite.Width > 200)
            {
                tbstartseite.BackColor = Color.White;
            }
        }
        private void btnstartseite_MouseLeave(object sender, EventArgs e)
        {
            if (tbstartseite.Width < 70)
            {
                tbstartseite.BackColor = Color.Gray;
            }
            else if (tbstartseite.Width > 200)
            {
                tbstartseite.BackColor = Color.Pink;
            }
        }
        private void btnGeraete_MouseEnter(object sender, EventArgs e)
        {
            if (tbGeraete.Width < 70)
            {
                tbGeraete.BackColor = Color.Pink;
            }
            else if (tbGeraete.Width > 200)
            {
                tbGeraete.BackColor = Color.White;
            }
        }
        private void btnGeraete_MouseLeave(object sender, EventArgs e)
        {
            if (tbGeraete.Width < 70)
            {
                tbGeraete.BackColor = Color.Gray;
            }
            else if (tbGeraete.Width > 200)
            {
                tbGeraete.BackColor = Color.Pink;
            }
        }
        private void btnMoebel_MouseEnter(object sender, EventArgs e)
        {
            if (tbMoebel.Width < 70)
            {
                tbMoebel.BackColor = Color.Pink;
            }
            else if (tbMoebel.Width > 200)
            {
                tbMoebel.BackColor = Color.White;
            }
        }
        private void btnMoebel_MouseLeave(object sender, EventArgs e)
        {
            if (tbMoebel.Width < 70)
            {
                tbMoebel.BackColor = Color.Gray;
            }
            else if (tbMoebel.Width > 200)
            {
                tbMoebel.BackColor = Color.Pink;
            }
        }
        private void btnKleidung_MouseEnter(object sender, EventArgs e)
        {
            if (tbKleidung.Width < 70)
            {
                tbKleidung.BackColor = Color.Pink;
            }
            else if (tbKleidung.Width > 200)
            {
                tbKleidung.BackColor = Color.White;
            }
        }
        private void btnKleidung_MouseLeave(object sender, EventArgs e)
        {
            if (tbKleidung.Width < 70)
            {
                tbKleidung.BackColor = Color.Gray;
            }
            else if (tbKleidung.Width > 200)
            {
                tbKleidung.BackColor = Color.Pink;
            }
        }
        private void btnWarenkorb_MouseEnter(object sender, EventArgs e)
        {
            if (tbWarenkorb.Width < 70)
            {
                tbWarenkorb.BackColor = Color.Pink;
            }
            else if (tbWarenkorb.Width > 200)
            {
                tbWarenkorb.BackColor = Color.White;
            }
        }
        private void btnWarenkorb_MouseLeave(object sender, EventArgs e)
        {
            if (tbWarenkorb.Width < 70)
            {
                tbWarenkorb.BackColor = Color.Gray;
            }
            else if (tbWarenkorb.Width > 200)
            {
                tbWarenkorb.BackColor = Color.Pink;
            }
        }
        private void btnBestellung_MouseEnter(object sender, EventArgs e)
        {
            if (tbBestellung.Width < 70)
            {
                tbBestellung.BackColor = Color.Pink;
            }
            else if (tbBestellung.Width > 200)
            {
                tbBestellung.BackColor = Color.White;
            }
        }
        private void btnBestellung_MouseLeave(object sender, EventArgs e)
        {
            if (tbBestellung.Width < 70)
            {
                tbBestellung.BackColor = Color.Gray;
            }
            else if (tbBestellung.Width > 200)
            {
                tbBestellung.BackColor = Color.Pink;
            }
        }
        private void btnAbmelden_MouseEnter(object sender, EventArgs e)
        {
            if (tbAbmelden.Width < 70)
            {
                tbAbmelden.BackColor = Color.Red;
            }
            else if (tbAbmelden.Width > 200)
            {
                tbAbmelden.BackColor = Color.Red;
            }
        }
        private void btnAbmelden_MouseLeave(object sender, EventArgs e)
        {
            if (tbAbmelden.Width < 70)
            {
                tbAbmelden.BackColor = Color.Gray;
            }
            else if (tbAbmelden.Width > 200)
            {
                tbAbmelden.BackColor = Color.Pink;
            }
        }

        private void btnzuruck_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartSeiteK form = new StartSeiteK(kundenid);
            form.ShowDialog();
        }
    }
}
