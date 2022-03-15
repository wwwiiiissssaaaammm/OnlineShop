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
    public partial class NeuesKontoForm : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost; UID=root; PASSWORD='';");

        public NeuesKontoForm()
        {
            InitializeComponent();
        }
        // {------------ Open Connection Method ------------}
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
            finally
            {
                conn.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // {------------ Program Close By Click ------------}
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // {------------ Back To Login site Button ------------}
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // {------------ Check if Textbox empty ------------}
            if (String.IsNullOrEmpty(tbVorname.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus");
            }
            else if (String.IsNullOrEmpty(tbNachname.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus");
            }
            else if (String.IsNullOrEmpty(tbemail.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus");
            }
            else if (String.IsNullOrEmpty(tbHnr.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus");
            }
            else if (String.IsNullOrEmpty(tbOrt.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus");
            }
            else if (String.IsNullOrEmpty(tbPlz.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus");
            }
            else if (String.IsNullOrEmpty(tbpw1.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus");
            }
            else if (String.IsNullOrEmpty(tbpw2.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus");
            }
            else if (String.IsNullOrEmpty(tbTel.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus");
            }
            else if (String.IsNullOrEmpty(tbStr.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus");
            }
            else if (tbpw1.Text != tbpw2.Text)
            {
                // {------------ Check if  both Password same   ------------}
                MessageBox.Show("Die Passwörter sind ungleich");
                tbpw1.Focus();
                tbpw1.BackColor = Color.Red;
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("select email from OnlineShop.kunde where email = '" + tbemail.Text + "'", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Email ist bereits vorhanden");
                }
                else
                {
                    string insert;
                    insert = "insert into OnlineShop.kunde(vorname, nachname, email, ort, strasse, Hausnummer, plz, Telefonnummer, Passwort, ist_Admin) values('" + tbVorname.Text + "', '" + tbNachname.Text + "', '" + tbemail.Text + "', '" + tbOrt.Text + "', '" + tbStr.Text + "', '" + tbHnr.Text + "', '" + tbPlz.Text + "', '" + tbTel.Text + "', md5('" + tbpw1.Text + "'), false)";
                    excutequery(insert);
                    DialogResult dr;
                    dr = MessageBox.Show("Daten sind eingetragen Möchten Sie sich wieder einlogin", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    
                    if (dr == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                }
            }       
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAnzeigen.Checked)
            {
                tbpw1.UseSystemPasswordChar = false;
            }
            else
            {
                tbpw1.UseSystemPasswordChar = true;
            }

            if (cbAnzeigen.Checked)
            {
                tbpw2.UseSystemPasswordChar = false;
            }
            else
            {
                tbpw2.UseSystemPasswordChar = true;
            }

        }

        private void NeuesKontoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
