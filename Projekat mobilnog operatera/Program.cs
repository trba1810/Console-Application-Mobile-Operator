using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var korisnik = Korisnik();
            Console.WriteLine("Unesite userName");
            var user = Console.ReadLine();
            Console.WriteLine("Unesite password");
            var pass = Console.ReadLine();
            var Validan = ProveraKorisnika(user, pass, korisnik);



            if (!Validan)
            {
                Console.WriteLine("Pogresili ste user ili pass");
                return;
            }


            Console.WriteLine("Dobro dosli u nas call centar");
            Console.WriteLine("Izaberitu jednu od opcija");
            Console.WriteLine("1- Provera stanja vaseg kredita");
            Console.WriteLine("2- Nove akcije");
            Console.WriteLine("3- Roaming");
            Console.WriteLine("4- Prelazak na drugi paket");
            Console.WriteLine("0- Razgovor sa operaterom");

            int izbor = Convert.ToInt32(Console.ReadLine());


            switch (izbor)
            {
                case 1:
                    Console.WriteLine("Dobro dosli:" + " " + korisnik[0] + " " + korisnik[1]);
                    Console.WriteLine("Stanje na vasem racunu je :" + korisnik[3] + " din ");
                    break;
                case 2:
                    Console.WriteLine("Nase najnovije akcije su: ");
                    Console.WriteLine("Telefon za 1 din");
                    Console.WriteLine("Neogranicen internet");
                    Console.WriteLine("Poklon VR naocare");
                    break;
                case 3:
                    Console.WriteLine("Roaming za CG,SLO,HR,RU iznosi 13,2 din po min");
                    Console.WriteLine("Sve ostale zemlje 25 din po min");
                    break;
                case 4:
                    Console.WriteLine("Prelaskom sa drugog operatera na nas dobijate 30% popusta");
                    Console.WriteLine("Novi korisnici dobijaju 15% popusta");
                    Console.WriteLine("Stari korisnici koji produzuju ugovor i prelaze na bolji paket dobijaju 50% popusta");
                    break;
                case 0:
                    Console.WriteLine("Operater ce vam se uskoro javiti");
                    break;
                default:
                    Console.WriteLine("Morate izbrati ponudjeni broj");
                    break;
            }
            Console.ReadLine();
        }

        public static string[] Korisnik()
        {
            var niz = new string[] { "Milan", "Petrovic", "0641112223", "20000", "Milan123", "123456" };
            return niz;
            var niz2 = new object[5];
        }

        public static bool ProveraKorisnika(string userName, string password, string[] Korisnik)
        {
            try
            {
                if (userName == Korisnik[4] && password == Korisnik[5])
                {
                    return true;
                }
                throw new Exception("korisnik nije pronadjen");
            }
            catch (Exception e)
            {
                Console.WriteLine("greska");

            }
            Console.WriteLine("test");
            Console.ReadLine();
            return false;


        }
    }
}