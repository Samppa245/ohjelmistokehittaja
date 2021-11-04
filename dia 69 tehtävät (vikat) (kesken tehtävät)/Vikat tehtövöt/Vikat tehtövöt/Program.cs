using System;

namespace Vikat_tehtövöt
{
    class Program
    {
        static void Main()
        {
            string nimesi = Console.ReadLine();
            Console.WriteLine("Hei " + nimesi);


            //tehtävä 2
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------");
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


            //teht 4

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
                Console.WriteLine("EI NOLLAA");
            }
            else
            {
                Console.WriteLine("Toinen luvuista on negatiivinen ja toine postiivine");
            }

           


            



            string kirjoitus = Console.ReadLine();
            char ekakirjain = kirjoitus[0];
            char vikakirjainv2 = kirjoitus[kirjoitus.Length - 1];
            string vikakirjain = kirjoitus.Remove(kirjoitus.Length - 1);



            string poisto = vikakirjain.Substring(1);
            string lisätty = vikakirjainv2 + poisto + ekakirjain;
            Console.WriteLine(lisätty);

            for (int z = 1; z <= 99; z+=2)
            {
                Console.WriteLine(z);
            }
        }
    }
}
