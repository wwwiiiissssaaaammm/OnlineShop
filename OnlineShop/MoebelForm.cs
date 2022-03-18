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
            FillDgv();
        }

        public void FillDgv()
        {
            MySqlCommand cmd = new MySqlCommand("select Produkt_id ,Bezeichnung, Beschreibung, Preis , Foto from produkte where Kategorie_id = 1 ;", conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvMoebel.AllowUserToAddRows = false;
            dgvMoebel.DataSource = table;

            dgvMoebel.RowTemplate.Height = 100;

            DataGridViewImageColumn dgimco = new DataGridViewImageColumn();

            dgimco = (DataGridViewImageColumn)dgvMoebel.Columns[4];
            dgimco.ImageLayout = DataGridViewImageCellLayout.Stretch;
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

                MessageBox.Show("Bitte ein Produkt auswählen");
            }
            else
            {
                countMenge.BackColor = Color.White;
                double preis = Convert.ToDouble(dgvMoebel.SelectedRows[0].Cells[3].Value);
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
                cmd.Parameters["@Produkte_id"].Value = dgvMoebel.SelectedRows[0].Cells[0].Value;
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
    }
}
