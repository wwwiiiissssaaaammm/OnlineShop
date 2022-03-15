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
    public partial class LoginForm : Form

    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost; UID=root; PASSWORD='';");
        int i;
        int j;

        public LoginForm()

        {
            InitializeComponent();
        }

        private void btnAnmelden_Click(object sender, EventArgs e)
        {
            i = 0;
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from OnlineShop.kunde where email = '" +tbemail.Text+"' and Passwort = md5('"+tbPasswort.Text+"') and ist_Admin = false;";
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dataTable);
            i = Convert.ToInt32(dataTable.Rows.Count.ToString());
            if (i == 0)
            {
                tberror.Visible = true;
            }
            else
            {
                this.Hide();
                StartSeiteK form = new StartSeiteK();
                form.ShowDialog();
            }
            conn.Close();
            ///////////////////////////////////////////////////////////////////////////////////////

            j = 0;
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from OnlineShop.kunde where email = '" +tbemail.Text+"' and Passwort = md5('"+tbPasswort.Text+"') and ist_Admin = true;";
            command.ExecuteNonQuery();
            DataTable tbl = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(tbl);
            j = Convert.ToInt32(tbl.Rows.Count.ToString());
            if (j == 0)
            {
                tberror.Visible = true;
            }
            else
            {
                this.Hide();
                AdminForm form = new AdminForm();
                form.ShowDialog();
            }

            conn.Close();
        }

        private void btnErstellen_Click(object sender, EventArgs e)
        {
            this.Hide();
            NeuesKontoForm form = new NeuesKontoForm();
            form.ShowDialog();
        }

        private void cbAnzeigen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAnzeigen.Checked)
            {
                tbPasswort.UseSystemPasswordChar = false;
            }
            else
            {
                tbPasswort.UseSystemPasswordChar = true;
            }
        }
    }
}
