using NASACLI;
using NASACLI.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NasaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnMindenAdat_Click(object sender, RoutedEventArgs e)
        {
            Program.Beolvasas();
            dtgKuldetesek.ItemsSource = Program.kuldetesek;
        }

        private void dtgKuldetesek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pgbHasznosTeher.Value = (dtgKuldetesek.SelectedItem as Kuldetes).HasznosTeher;
            lbKivalasztott.Content = (dtgKuldetesek.SelectedItem as Kuldetes).Nev;
        }

        private void btnStatisztika_Click(object sender, RoutedEventArgs e)
        {
            Kuldetes[] nemEmberesKuldetesek = Program.kuldetesek.Where(k => k.Legenyseg == 0).ToArray();
            int nemEmberesKuldetesekSzama = nemEmberesKuldetesek.Length;
            double nemEmberesKuldetesekAtlagTeher = nemEmberesKuldetesek.Average(k => k.HasznosTeher);
            double nemEmberesKuldetesekAtlagKoltseg = nemEmberesKuldetesek.Average(k => k.Koltseg);
            var nemEmberesRekord = new
            {
                Kategoria = "Nem emberes küldetések",
                Db = nemEmberesKuldetesekSzama,
                AtlagTeher = nemEmberesKuldetesekAtlagTeher,
                AtlagKoltseg = nemEmberesKuldetesekAtlagKoltseg
            };
            Kuldetes[] EmberesKuldetesek = Program.kuldetesek.Where(k => k.Legenyseg != 0).ToArray();
            int EmberesKuldetesekSzama = EmberesKuldetesek.Length;
            double EmberesKuldetesekAtlagTeher = EmberesKuldetesek.Average(k => k.HasznosTeher);
            double EmberesKuldetesekAtlagKoltseg = EmberesKuldetesek.Average(k => k.Koltseg);
            var emberesRekord = new
            {
                Kategoria = "Emberes küldetések",
                Db = EmberesKuldetesekSzama,
                AtlagTeher = EmberesKuldetesekAtlagTeher,
                AtlagKoltseg = nemEmberesKuldetesekAtlagKoltseg
            };
            dtgKuldetesek.ItemsSource = new List<object>() { emberesRekord, nemEmberesRekord };
        }
    }
}