using NASACLI.Models;

namespace NASACLI
{
    internal class Program
    {
        public static List<Kuldetes> kuldetesek = new List<Kuldetes>();
        static void Main(string[] args)
        {
            Beolvasas();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
        }

        private static void Feladat6()
        {
            var legkisebbHasznosTeherKuldetes = kuldetesek.MinBy(k => k.HasznosTeher);
            Console.WriteLine($"6. feladat: A legkisebb hasznos teher: {legkisebbHasznosTeherKuldetes.HasznosTeher} ({legkisebbHasznosTeherKuldetes.Nev})");
        }

        private static void Feladat5()
        {
            Console.WriteLine("5. feladat: Küldetések kockázati szintjei:");
            var magasKockazatuKuldetesek = kuldetesek.Where(k => k.KockazatiSzint() == "Magas");
            foreach (var item in magasKockazatuKuldetesek)
            {
                Console.WriteLine($"{item.Nev}: {item.KockazatiSzint()}");
            }
            Console.WriteLine();
        }

        private static void Feladat4()
        {
 
            Kuldetes keresett = null;
            do
            {
                Console.Write($"4. feladat: Adja meg egy küldetés nevének egy részletét: ");
                string nev = Console.ReadLine();
                keresett = kuldetesek.LastOrDefault(k => k.Nev.ToUpper().Contains(nev.ToUpper()));

            }
            while (keresett == null);

            Console.WriteLine($"Talált küldetés: {keresett.Nev}, {keresett.Ev}, {keresett.Celpont}, {(keresett.Sikeres ? "Sikeres" : "Sikertelen")}");
            Console.WriteLine();

        }

        private static void Feladat3()
        {
            Console.WriteLine($"3. feladat: {kuldetesek.Count} küldetés található az állományban.");
        }

        public static void Beolvasas()
        {
            StreamReader streamReader = new StreamReader("NASAmissions.txt");
            streamReader.ReadLine();
            while (!streamReader.EndOfStream) 
            {
                Kuldetes kuldetes = new Kuldetes(streamReader.ReadLine());
                kuldetesek.Add(kuldetes);
            }
            streamReader.Close();
        }
    }
}
