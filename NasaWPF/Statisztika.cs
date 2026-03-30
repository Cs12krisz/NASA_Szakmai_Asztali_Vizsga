using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaWPF
{
    public class Statisztika
    {
        public string Kategoria { get; set; }
        public int Db { get; set; }
        public string AtlagTeher { get; set; }
        public string AtlagKoltseg { get; set; }

        public Statisztika(string kategoria, int db, double atlagteher, double atlagkoltseg) 
        {
            Kategoria = kategoria;
            Db = db;
            AtlagTeher = $"{atlagteher:F2} kg";
            AtlagKoltseg = $"{atlagkoltseg:F2} mrd USD$";
        }
    }
}
