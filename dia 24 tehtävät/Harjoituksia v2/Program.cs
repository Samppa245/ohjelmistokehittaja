using System;

namespace Harjoituksia_v2
{
    class Program
    {
        static void Main()
        {
            // EKA TEHTÄVÄ
            Console.WriteLine("HARJOITUS 1, syötä kaksi lukua ja ohjelma tulostaa luvut suuruusjärjestyksessä");

            int X = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int jees = Math.Min(X, y);
            int jeesv2 = Math.Max(X, y);

            Console.WriteLine(jeesv2 + " ja " + jees);

            Console.WriteLine(" Syötä kolme numeroa, niin ohjelma etsii suurimman luvuista");

            //TOINEN TEHTÄVÄ
            Console.WriteLine("HARJOITUS 2");
            Console.WriteLine("Syötä ekanumero");
            int ekanumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä tokanumero");


            int tokanumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Kolmas numero");
            int kolmasnumero = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(ekanumero, tokanumero), kolmasnumero));

            Console.WriteLine(" Anna numero 1-9, niin ohjelma tulostaa luvun kirjain muodossa.");

            // KOLMAS TEHTÄVÄ
            Console.WriteLine(" HARJOITUS 3");
            string käyttäjä = Console.ReadLine();

            switch (käyttäjä)
            {
                case "1":
                    Console.WriteLine("Yksi");
                    break;
                case "2":
                    Console.WriteLine("Kaksi");
                    break;
                case "3":
                    Console.WriteLine("Kolmas");
                    break;
                case "4":
                    Console.WriteLine("Neljäs");
                    break;
                case "5":
                    Console.WriteLine("Viides");
                    break;
                case "6":
                    Console.WriteLine("Kuudes");
                    break;
                case "7":
                    Console.WriteLine("Seitsemäs");
                    break;
                case "8":
                    Console.WriteLine("Kahdeksas");
                    break;
                case "9":
                    Console.WriteLine("Yhdeksäs");
                    break;
                default:
                    Console.WriteLine("Ei si antanu numeroo");
                    break;




            }
            Console.WriteLine("Syötä 5 lukua, niin ohjelma tulostaa suurimman luvun.");

            Console.WriteLine("Syötä 1 luku");
            int eka = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä 2 luku");
            int toka = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä 3 luku");
            int kolmas = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä 4 luku");
            int neljäs = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä 5 luku");
            int viides = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(Math.Max(Math.Max(eka, toka), kolmas), neljäs), viides));

            Console.WriteLine("Valitse syötätkö kokonaisluvun, merkkijonon vai tuplaluvun ISOILLA KIRJAIMILLA. Kun olet valinnut, niin syötä luku ja paina enter");

            Console.WriteLine("KOKONAISLUKU, TUPLALUKU VAI MERKKIJONO?");
            string luku = Console.ReadLine();
            switch (luku)
            {
                case "MERKKIJONO":
                    Console.WriteLine("Kerroppa merkkijono sitten");
                    string teuvo = Console.ReadLine();
                    Console.WriteLine(teuvo + "*");
                    break;
                case "KOKONAISLUKU":
                    Console.WriteLine("Kerroppe numero sitten");
                    int pekka = int.Parse(Console.ReadLine());
                    Console.WriteLine(pekka + 1);
                    break;
                case "TUPLALUKU":
                    Console.WriteLine(); double tuomo = double.Parse(Console.ReadLine());
                    Console.WriteLine(tuomo * 2);
                    break;



            }

            Console.WriteLine("Syötä luku 1-9 väliltä. Jos pisteet ovat välillä 1-3, ohjelma kertoo pisteet 10:llä. Mikäli pisteet ovat välillä 4-6, ohjelma kertoo pisteet 100:lla ja mikäli pisteet ovat välillä 7-9 ohjelma kertoo pisteet 1000:lla. ");
            int pisteet = int.Parse(Console.ReadLine());
            if (pisteet >= 0 && pisteet <= 3)
            {
                pisteet *= 10;
                Console.WriteLine(pisteet);

            }

            else if (pisteet >= 4 && pisteet <= 6)
            {
                pisteet *= 100;
                Console.WriteLine(pisteet);

            }
            else if (pisteet >= 7 && pisteet <= 9)
            {
                pisteet *= 1000;
                Console.WriteLine(pisteet);

            }
            else
            {
                Console.WriteLine("Virhe syötä luku 0-9 väliltä");
            }












        }
    }
}
