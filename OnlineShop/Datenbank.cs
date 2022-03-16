using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineShop
{
    
    internal class Datenbank
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost; UID=root; PASSWORD='';");

        public void oeffnen()
        {
            conn.Open();
        }

        public void schliessen()
        {
            conn.Close();
        }

        public List<Kategorie> kategorieHolen()
        {
            List<Kategorie> lister = new List<Kategorie>();
            int katId;
            string bez;

            oeffnen();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select Kategorie_id , Bezeichnung from onlineshop.kategorie;";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                katId = reader.GetInt32("Kategorie_id");
                bez = reader.IsDBNull(1) ? "" : reader.GetString("Bezeichnung");
                Kategorie prd = new Kategorie(katId, bez);
                lister.Add(prd);

            }
            reader.Close();
            schliessen();
            return lister;
            
        }
    }
}

