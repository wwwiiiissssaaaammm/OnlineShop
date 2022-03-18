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
            FillDgv();
        }

        public void FillDgv()
        {
            MySqlCommand cmd = new MySqlCommand("select Produkt_id ,Bezeichnung, Beschreibung, Preis , Foto from produkte where Kategorie_id = 3 ;", conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvGeraete.AllowUserToAddRows = false;
            dgvGeraete.DataSource = table;

            dgvGeraete.RowTemplate.Height = 100;

            DataGridViewImageColumn dgimco = new DataGridViewImageColumn();

            dgimco = (DataGridViewImageColumn)dgvGeraete.Columns[4];
            dgimco.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvGeraete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (countMenge.Value == 0)
            {
                MessageBox.Show("Bitte wählen Sie die Menge aus");
                countMenge.BackColor = Color.Red;
            }
            else if(dgvGeraete.SelectedRows.Count == 0){

                MessageBox.Show("Bitte ein Produkt auswählen");
            }
            else
            {
                countMenge.BackColor = Color.White;
                double preis = Convert.ToDouble(dgvGeraete.SelectedRows[0].Cells[3].Value) ;
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
                cmd.Parameters["@Produkte_id"].Value = dgvGeraete.SelectedRows[0].Cells[0].Value;
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
            if(dgvGeraete.CurrentCell != null)
            {
                //tbID.Text = dgvProdukte.CurrentRow.Cells[0].Value.ToString();
                tbProduktName.Text = dgvGeraete.CurrentRow.Cells[1].Value.ToString();
                tbBeschreibung.Text = dgvGeraete.CurrentRow.Cells[2].Value.ToString();
                tbPreis.Text = dgvGeraete.CurrentRow.Cells[3].Value.ToString();

            }
        }
    }
}
