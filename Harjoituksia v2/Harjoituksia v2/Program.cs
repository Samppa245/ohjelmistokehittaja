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

            Console.Write(jeesv2 + " ja " + jees);
            //TOINEN TEHTÄVÄ
            Console.WriteLine("HARJOITUS 2");
            Console.WriteLine("Syötä ekanumero");
            int ekanumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä tokanumero");
            
            
            int tokanumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Kolmas numero");
            int kolmasnumero = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(ekanumero, tokanumero), kolmasnumero));

            // KOLMAS TEHTÄVÄ
            Console.WriteLine(" HARJOITUS 3");
            string käyttäjä = Console.ReadLine();

            switch (käyttäjä)
            {
                case "1":
                    Console.Write("Yksi");
                    break;
                case "2":
                    Console.Write("Kaksi");
                    break;
                case "3":
                    Console.Write("Kolmas");
                    break;
                case "4":
                    Console.Write("Neljäs");
                    break;
                case "5":
                    Console.Write("Viides");
                    break;
                case "6":
                    Console.Write("Kuudes");
                    break;
                case "7":
                    Console.Write("Seitsemäs");
                    break;
                case "8":
                    Console.Write("Kahdeksas");
                    break;
                case "9":
                    Console.Write("Yhdeksäs");
                    break;
                default:
                    Console.Write("Ei si antanu numeroo");
                    break;




            }
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

            Console.WriteLine("KOKONAISLUKU, TUPLALUKU VAI MERKKIJONO?");
            string luku = Console.ReadLine();
            switch (luku) {
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
                    Console.WriteLine();                    int tuomo = int.Parse(Console.ReadLine());
                    Console.WriteLine(tuomo + 1);
                    break;


                 
            }

            Console.WriteLine("Tehtävä 6");
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
