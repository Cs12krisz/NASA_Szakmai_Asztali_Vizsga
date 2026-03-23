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
        }

        private static void Feladat4()
        {
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
        }
    }
}
