using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASACLI.Models
{
    public class Kuldetes
    {
        public string Nev { get; private set; }
        public int Ev { get; private set; }
        public string Celpont { get; private set; }
        public int Legenyseg { get; private set; }
        public bool Sikeres { get; private set; }
        public string Leiras { get; private set; }
        public double Koltseg { get; private set; }
        public double HasznosTeher { get; private set; }

        public Kuldetes(string sor) 
        {
            string[] s = sor.Split(';');
            Nev = s[0];
            Ev = int.Parse(s[1]);
            Celpont = s[2];
            Legenyseg = int.Parse(s[3]);
            Sikeres = s[4] == "Igen" ? true : false;
            Leiras = s[5];
            Koltseg = double.Parse(s[6]);
            HasznosTeher = double.Parse(s[7]);
        }
    }
}
