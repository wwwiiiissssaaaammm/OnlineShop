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
            AdminForm adminForm = new AdminForm();  
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
    }
}
