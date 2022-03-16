using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Kategorie
    {
        int katId;
        string bezichnung;

        public Kategorie(int katId, string bezichnung)
        {
            this.katId = katId;
            this.bezichnung = bezichnung;
        }

        public int KatId { get => katId; set => katId = value; }
        public string Bezichnung { get => bezichnung; set => bezichnung = value; }
    }

    
}
