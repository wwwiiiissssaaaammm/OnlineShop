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

    public partial class AdminStartSeite : Form
    {
        public AdminStartSeite()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            produkteverwalten adminForm = new produkteverwalten();  
            adminForm.ShowDialog();
        }

        private void btn_KundenDaten_Click(object sender, EventArgs e)
        {
            this.Hide();
            kundenDatenA kundenDaten = new kundenDatenA();
            kundenDaten.ShowDialog();
        }

        private void btnBestellungen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bestellungen bestellungen = new Bestellungen();
            bestellungen.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
