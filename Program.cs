using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Tervehdys
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tänään = DateTime.Now; // Tätä käytetään otsikossa
            DateTime alkuhetki = DateTime.Now; //aikaleima ennen tietojen syöttöä
            DateTime loppuhetki;
            Double aikaero;
            string asiakassegmentti;
            CultureInfo culture = new CultureInfo("fi-FI"); //käytä aina fi-FI -muotoa (CultureInfoa)
            string nimi;
            string osoite;
            string postitoimipaikka;
            string sähköposti;
            int ika;
            string postinumero;
            string puhelinnumero;
            Console.Write("Tänään on: " + tänään.ToString("F", culture));
            Console.WriteLine(" Tervetuloa hienon konsoliaplikaation käyttäjiksi!"); // Tervehdys teksti
            Console.WriteLine();
            Console.Write("Kerro nimesi: "); //Write pysyy samalla rivillä
            //Console.WriteLine("Kerro nimesi: "); // WriteLine vaihtaa riviä
            nimi = Console.ReadLine();
            Console.Write("Kerro ikäsi: ");
            ika = int.Parse(Console.ReadLine());
            if (ika <7)
            {
                asiakassegmentti = "Alle kouluikäinen";
            }
            else if (ika >= 7 && ika < 17)
            {
                asiakassegmentti = "Lapsi tai varkki";
            }
            else if (ika >= 17 && ika < 24)
            {
                asiakassegmentti = "Nuori";
            }
            else if (ika >= 24 && ika < 66)
            {
                asiakassegmentti = "Keski-ikäinen";
            }
            else
            {
                asiakassegmentti = "Eläkeläinen - todennäköisesti";
            }
            Console.Write("Kerro osoitteesi: ");
            osoite = Console.ReadLine();
            Console.Write("Kerro postinumerosi: ");
            postinumero = Console.ReadLine();
            Console.Write("Kerro postitoimipaikkasi: ");
            postitoimipaikka = Console.ReadLine();
            Console.Write("Kerro puhelinnumerosi: ");
            puhelinnumero = Console.ReadLine();
            Console.Write("Kerro sähköpostisi: ");
            sähköposti = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Asiakastietokanta:"); //, " + nimi + ", ikäsi on: " + ika.ToString());
            Console.WriteLine();
            Console.WriteLine("Nimi: " + nimi);
            Console.WriteLine("Ikä: " + ika.ToString());
            Console.WriteLine("Osoite: " + osoite + ", " + postinumero.ToString() + ", " + postitoimipaikka);
            Console.WriteLine();
            Console.WriteLine("Yhteystiedot: ");
            Console.WriteLine("Puhelinnumero: " + puhelinnumero);
            Console.WriteLine("Sähköposti: " + sähköposti);
            // Miksi postinumerossa/puhelinnumerossa ei näy nolla ensimmäisenä numerona? Esim. 06100 näkyy konsolissa kirjoittaessa 6100
            loppuhetki = DateTime.Now; //aikaleima tietojen syötön jälkeen
            aikaero = loppuhetki.Subtract(alkuhetki).TotalSeconds;
            Console.WriteLine("");
            Console.WriteLine("Asiakasluokitus: " + asiakassegmentti);
            Console.WriteLine("");
            Console.WriteLine("Aikaa kului " + aikaero.ToString() + " Paina Enteriä lopettaaksesi ohjelman"); // Lopetus ohjeistus
            Console.ReadLine();
        }
    }
}
