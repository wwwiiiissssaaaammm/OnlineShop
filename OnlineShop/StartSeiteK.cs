using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class StartSeiteK : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost; UID=root; Database=OnlineShop; PASSWORD='';");

        private int kundenid;


        public StartSeiteK(int kundenid)
        {
            this.kundenid = kundenid;
            InitializeComponent();
            FillDgv(tbSuche.Text);
        }
        //Sidebar Design ------------------------------------------
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // {-------------------------------DESIGN SIDEBAR-------------------------------------}
            
            if (sideBar.Size.Width == 63)
            {
                sideBar.Size = new Size(234, 595);
                this.sideBar.BackColor = Color.FromArgb(105, 105, 105, 100);
                label2.Text = "Menu";
                label2.ForeColor = Color.Black;
                label2.BackColor = Color.Transparent;

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

                dgvAlleProdukte.Size = new Size(1173, 487);
                dgvAlleProdukte.Location = new Point(240, 83);

                tbSuche.Size = new Size(1173, 24);
                tbSuche.Location = new Point(240, 53);
            }
            else
            {           
                sideBar.Size = new Size(63, 592);
                sideBar.BackColor = Color.Transparent;
                label2.Text = "";

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

                dgvAlleProdukte.Size = new Size(1335, 487);
                dgvAlleProdukte.Location = new Point(78, 83);

                tbSuche.Size = new Size(1335, 24);
                tbSuche.Location = new Point(78, 53);
            }
            
        } 

        

        private void tbGeraete_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeraetsForm geraetsForm = new GeraetsForm(kundenid);
            geraetsForm.ShowDialog();
        }

        private void tbMoebel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoebelForm moebelForm = new MoebelForm(kundenid);
            moebelForm.ShowDialog();
        }

        private void tbKleidung_Click(object sender, EventArgs e)
        {
            this.Hide();
            KleidungsForm kleidungsForm = new KleidungsForm(kundenid);
            kleidungsForm.ShowDialog();
        }

        private void btnMeineDaten_Click(object sender, EventArgs e)
        {
            this.Hide();
            KundenDatenK kundenDaten = new KundenDatenK(kundenid);
            kundenDaten.ShowDialog();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            WarenKorb waren = new WarenKorb(kundenid);
            waren.ShowDialog();
        }

        // Mouse Enter And Leave Event /////////////////////////////////////
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
        //////////////////////////////////////////////////////////////////////////
        ///
        public void FillDgv(string suchwert)
        {
            MySqlCommand cmd = new MySqlCommand("select Kategorie_id, Bezeichnung, Beschreibung, Preis, Foto from OnlineShop.produkte where Bezeichnung like '%"+tbSuche.Text+"%'", conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvAlleProdukte.AllowUserToAddRows = false;
            dgvAlleProdukte.DataSource = table;

            dgvAlleProdukte.RowTemplate.Height = 100;

            DataGridViewImageColumn dgimco = new DataGridViewImageColumn();

            dgimco = (DataGridViewImageColumn)dgvAlleProdukte.Columns[4];
            dgimco.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvAlleProdukte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void tbSuche_TextChanged(object sender, EventArgs e)
        {
            FillDgv(tbSuche.Text);
        }

        private void btnstartseite_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBestellung_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellungenK form = new BestellungenK(kundenid);
            form.ShowDialog();
        }
    }



}
