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

    public partial class GeraetsForm : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost; UID=root; Database=OnlineShop; PASSWORD='';");

        private int kundenid;
        

        public GeraetsForm(int kundenid)
        {
            this.kundenid = kundenid;
            InitializeComponent();
            FillDgv(tbSuche.Text);
        }

        public void FillDgv(string suchwert)
        {
            MySqlCommand cmd = new MySqlCommand("select Produkt_id ,Bezeichnung, Beschreibung, Preis , Foto from produkte where Kategorie_id = 3 and Bezeichnung like '%"+tbSuche.Text+"%' ;", conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvGeraete.AllowUserToAddRows = false;
            dgvGeraete.DataSource = table;

            dgvGeraete.RowTemplate.Height = 100;

            DataGridViewImageColumn dgimco = new DataGridViewImageColumn();

            dgimco = (DataGridViewImageColumn)dgvGeraete.Columns[4];
            dgimco.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvGeraete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WarenKorb warenKorb = new WarenKorb(kundenid);
            warenKorb.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvGeraete_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvGeraete.CurrentCell != null)
            {
                //tbID.Text = dgvProdukte.CurrentRow.Cells[0].Value.ToString();
                tbProduktName.Text = dgvGeraete.CurrentRow.Cells[1].Value.ToString();
                tbBeschreibung.Text = dgvGeraete.CurrentRow.Cells[2].Value.ToString();
                tbPreis.Text = dgvGeraete.CurrentRow.Cells[3].Value.ToString();

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

                btnstartseite.BackColor = Color.Pink;
                btnstartseite.Width = 223;
                btnstartseite.Text = "             Home";


                btnGeraete.BackColor = Color.Pink;
                btnGeraete.Width = 223;
                btnGeraete.Text = "             Geräte";

                btnMoebel.BackColor = Color.Pink;
                btnMoebel.Width = 223;
                btnMoebel.Text = "             Möbel";

                btnKleidung.BackColor = Color.Pink;
                btnKleidung.Width = 223;
                btnKleidung.Text = "             Kleidung";

                btnWarenkorb.BackColor = Color.Pink;
                btnWarenkorb.Width = 223;
                btnWarenkorb.Text = "             Warenkorb";

                btnBestellung.BackColor = Color.Pink;
                btnBestellung.Width = 223;
                btnBestellung.Text = "             Meine Bestellungen";

                btnAbmelden.BackColor = Color.Pink;
                btnAbmelden.Width = 223;
                btnAbmelden.Text = "             Abmelden";


                dgvGeraete.Size = new Size(881, 460);
                dgvGeraete.Location = new Point(240, 45);
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

                btnstartseite.BackColor = Color.Gray;
                btnstartseite.Text = "";
                btnstartseite.Width = 60;


                btnGeraete.BackColor = Color.Gray;
                btnGeraete.Text = "";
                btnGeraete.Width = 60;

                btnMoebel.BackColor = Color.Gray;
                btnMoebel.Width = 60;
                btnMoebel.Text = "";

                btnKleidung.BackColor = Color.Gray;
                btnKleidung.Width = 60;
                btnKleidung.Text = "";

                btnWarenkorb.BackColor = Color.Gray;
                btnWarenkorb.Width = 60;
                btnWarenkorb.Text = "";

                btnBestellung.BackColor = Color.Gray;
                btnBestellung.Width = 60;
                btnBestellung.Text = "";

                btnAbmelden.BackColor = Color.Gray;
                btnAbmelden.Width = 60;
                btnAbmelden.Text = "";

                dgvGeraete.Size = new Size(966, 460);
                dgvGeraete.Location = new Point(155, 45);
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

        private void tbsuche_TextChanged(object sender, EventArgs e)
        {
            FillDgv(tbSuche.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            WarenKorb waren = new WarenKorb(kundenid);
            waren.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if(panel.Visible == true) {      
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

        private void btnstartseite_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartSeiteK form = new StartSeiteK(kundenid);
            form.ShowDialog();
        }

        private void btnzuruck_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartSeiteK form = new StartSeiteK(kundenid);
            form.ShowDialog();
        }

        private void btnBestellung_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellungenK form = new BestellungenK(kundenid);
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
            if (btnstartseite.Width < 70)
            {
                btnstartseite.BackColor = Color.Pink;
            }
            else if (btnstartseite.Width > 200)
            {
                btnstartseite.BackColor = Color.White;
            }
        }
        private void btnstartseite_MouseLeave(object sender, EventArgs e)
        {
            if (btnstartseite.Width < 70)
            {
                btnstartseite.BackColor = Color.Gray;
            }
            else if (btnstartseite.Width > 200)
            {
                btnstartseite.BackColor = Color.Pink;
            }
        }
        private void btnGeraete_MouseEnter(object sender, EventArgs e)
        {
            if (btnGeraete.Width < 70)
            {
                btnGeraete.BackColor = Color.Pink;
            }
            else if (btnGeraete.Width > 200)
            {
                btnGeraete.BackColor = Color.White;
            }
        }
        private void btnGeraete_MouseLeave(object sender, EventArgs e)
        {
            if (btnGeraete.Width < 70)
            {
                btnGeraete.BackColor = Color.Gray;
            }
            else if (btnGeraete.Width > 200)
            {
                btnGeraete.BackColor = Color.Pink;
            }
        }
        private void btnMoebel_MouseEnter(object sender, EventArgs e)
        {
            if (btnMoebel.Width < 70)
            {
                btnMoebel.BackColor = Color.Pink;
            }
            else if (btnMoebel.Width > 200)
            {
                btnMoebel.BackColor = Color.White;
            }
        }
        private void btnMoebel_MouseLeave(object sender, EventArgs e)
        {
            if (btnMoebel.Width < 70)
            {
                btnMoebel.BackColor = Color.Gray;
            }
            else if (btnMoebel.Width > 200)
            {
                btnMoebel.BackColor = Color.Pink;
            }
        }
        private void btnKleidung_MouseEnter(object sender, EventArgs e)
        {
            if (btnKleidung.Width < 70)
            {
                btnKleidung.BackColor = Color.Pink;
            }
            else if (btnKleidung.Width > 200)
            {
                btnKleidung.BackColor = Color.White;
            }
        }
        private void btnKleidung_MouseLeave(object sender, EventArgs e)
        {
            if (btnKleidung.Width < 70)
            {
                btnKleidung.BackColor = Color.Gray;
            }
            else if (btnKleidung.Width > 200)
            {
                btnKleidung.BackColor = Color.Pink;
            }
        }
        private void btnWarenkorb_MouseEnter(object sender, EventArgs e)
        {
            if (btnWarenkorb.Width < 70)
            {
                btnWarenkorb.BackColor = Color.Pink;
            }
            else if (btnWarenkorb.Width > 200)
            {
                btnWarenkorb.BackColor = Color.White;
            }
        }
        private void btnWarenkorb_MouseLeave(object sender, EventArgs e)
        {
            if (btnWarenkorb.Width < 70)
            {
                btnWarenkorb.BackColor = Color.Gray;
            }
            else if (btnWarenkorb.Width > 200)
            {
                btnWarenkorb.BackColor = Color.Pink;
            }
        }
        private void btnBestellung_MouseEnter(object sender, EventArgs e)
        {
            if (btnBestellung.Width < 70)
            {
                btnBestellung.BackColor = Color.Pink;
            }
            else if (btnBestellung.Width > 200)
            {
                btnBestellung.BackColor = Color.White;
            }
        }
        private void btnBestellung_MouseLeave(object sender, EventArgs e)
        {
            if (btnBestellung.Width < 70)
            {
                btnBestellung.BackColor = Color.Gray;
            }
            else if (btnBestellung.Width > 200)
            {
                btnBestellung.BackColor = Color.Pink;
            }
        }
        private void btnAbmelden_MouseEnter(object sender, EventArgs e)
        {
            if (btnAbmelden.Width < 70)
            {
                btnAbmelden.BackColor = Color.Red;
            }
            else if (btnAbmelden.Width > 200)
            {
                btnAbmelden.BackColor = Color.Red;
            }
        }
        private void btnAbmelden_MouseLeave(object sender, EventArgs e)
        {
            if (btnAbmelden.Width < 70)
            {
                btnAbmelden.BackColor = Color.Gray;
            }
            else if (btnAbmelden.Width > 200)
            {
                btnAbmelden.BackColor = Color.Pink;
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (countMenge.Value == 0)
            {
                MessageBox.Show("Bitte wählen Sie die Menge aus");
                countMenge.BackColor = Color.Red;
            }
            else if (dgvGeraete.SelectedRows.Count == 0)
            {

                MessageBox.Show("Bitte ein Produkt auswählen", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading, "help.pdf");
            }
            else
            {
                countMenge.BackColor = Color.White;
                double preis = Convert.ToDouble(dgvGeraete.SelectedRows[0].Cells[3].Value);
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
                cmd.Parameters["@Produkt_id"].Value = dgvGeraete.SelectedRows[0].Cells[0].Value;
                cmd.Parameters["@Menge"].Value = menge;
                cmd.Parameters["@preis"].Value = preis * menge;

                cmd.ExecuteNonQuery();


                countMenge.Value = 0;


                MessageBox.Show("Daten sind in Warenkorb hinzugefügt");
                conn.Close();

            }
        }
    }
}
