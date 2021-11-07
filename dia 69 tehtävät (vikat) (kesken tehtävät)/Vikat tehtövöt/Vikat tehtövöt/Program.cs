using System;

namespace Vikat_tehtövöt
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Kerro ikäsi, niin ohjelmalla on sinulle asiaa (Tehtävä 11)");
            int Ikäsi = int.Parse(Console.ReadLine());
            Console.WriteLine("Hei näytät ikäistäsi nuoremmalta " + Ikäsi);


            //tehtävä 12
            Console.WriteLine("---------------");
            Console.WriteLine("Anna numero joka on SUUREMPI KUIN KYMMENEN ja ohjelma tulostaa luvun verran lukuja. (Tehtävä 12)");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 10)
            {
                for (int x = 0; x < numero; x++)
                {
                    Console.WriteLine(numero);


                }
            }
            else
            {
                Console.WriteLine("SUUERMPI KUIN 10");
            }
            // teht 13
            Console.WriteLine("---------------");
            Console.WriteLine("Kirjoita sana, niin ohjelma vaihtaa sanan ensimmäisen ja viimesisen kirjaimen paikkaa(Tehtävä 13)");
            string kirjoitus = Console.ReadLine();
            char ekakirjain = kirjoitus[0];
            char vikakirjainv2 = kirjoitus[kirjoitus.Length - 1];
            string vikakirjain = kirjoitus.Remove(kirjoitus.Length - 1);



            string poisto = vikakirjain.Substring(1);
            string lisätty = vikakirjainv2 + poisto + ekakirjain;
            Console.WriteLine(lisätty);


            //teht 4
            Console.WriteLine("---------------");
            Console.WriteLine("Anna kaksi lukua, niin ohjelma kertoo onko luvut positiivisia vai negatiivisia tai kumpaakin. (Anna ensiksi yksi luku ja paina enteriä, sen jälkeen toinen luku)(Tehtävä 14)");
            int luku = int.Parse(Console.ReadLine());
            int lukuv2 = int.Parse(Console.ReadLine());
            if (luku < 0 && lukuv2 < 0)
            {
                Console.WriteLine("Luvut ovat negatiivisia");

            }
            else if (luku > 0 && lukuv2 > 0)
            {
                Console.WriteLine("Luvut ovat positiivisia");
            }
            else if (luku == 0 || lukuv2 == 0)
            {
                Console.WriteLine("Kummatkin/toinen luvuista on nolla");
            }
            else
            {
                Console.WriteLine("Toinen luvuista on negatiivinen ja toine postiivine");
            }



            Console.WriteLine("---------------");
            Console.WriteLine("Kirjoita jokin lause, niin ohjelma tulostaa pisimmän sanan lauseesta. (Tehtävä 15)");

            string lause = Console.ReadLine();
            string[] pilkkominen = lause.Split(' ');
            int pituudet = 0;
            string word = "";

            foreach (string sanat in pilkkominen)
            {
                if (sanat.Length > pituudet)
                {
                    pituudet = sanat.Length;
                    word = sanat;
                }

            }
            Console.WriteLine("Isoin Sana on " + word);


            Console.WriteLine("---------------");
            Console.WriteLine("TÄMÄ TEHTÄVÄ TULOSTAA PARITTOMAT LUVUT 99 ASTI. PAINA ENTERIÄ ALOITTAAKSESI (TEHTÄVÄ 16)");

            string painallus = Console.ReadLine();
            if (painallus == "")
            {
                for (int z = 1; z <= 99; z += 2)
                {
                    Console.WriteLine(z);
                }

            }
            else
            {
                if (painallus == "")
                {
                    for (int z = 1; z <= 99; z += 2)
                    {
                        Console.WriteLine(z);
                    }
                }

            }




            Console.WriteLine("Tämä ohjelma tulostaa 3 jaolliset luvut(PAINA ENTER)");
            // Vähän monimutkaisemmin :D, vaikka ois voinu vaa lisätä for looppii += 3
            string painallusv2 = Console.ReadLine();
            if (painallusv2 == "")
            {

                for (double p = 0; p <= 100; p++)
                {
                    double u = p / 3;
                    bool Kokonainen = u == (int)u;
                    if (Kokonainen == true)
                    {
                        Console.WriteLine(p);
                    }
                }
            }
            else
            {
                for (double p = 0; p <= 100; p++)
                {
                    double u = p / 3;
                    bool Kokonainen = u == (int)u;
                    if (Kokonainen == true)
                    {
                        Console.WriteLine(p);
                    }
                }
            }


        }
    }
}
