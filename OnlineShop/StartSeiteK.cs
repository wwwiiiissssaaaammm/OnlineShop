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
        private int kundenid;


        public StartSeiteK(int kundenid)
        {
            this.kundenid = kundenid;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sideBar.Size = new Size(234, 450);
            dgvAlleProdukte.Size = new Size(550, 293);
            dgvAlleProdukte.Location = new Point(241, 42);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sideBar.Size = new Size(72, 450);
            dgvAlleProdukte.Size = new Size(710, 293);
            dgvAlleProdukte.Location = new Point(76, 42);
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
    }
}
