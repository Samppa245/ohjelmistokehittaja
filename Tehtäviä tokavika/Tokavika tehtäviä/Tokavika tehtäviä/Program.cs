using System;

namespace Tokavika_tehtäviä
{
    class Program
    {
        static void Main()
        {

            static int lasku(int lasku1, int lasku2)
            {

                return (lasku1 + lasku2);
               
            }

            int timo = int.Parse(Console.ReadLine());
            int timov2 = int.Parse(Console.ReadLine());

           int summa = lasku(timo, timov2);
            Console.WriteLine(summa);
        

        static double laskuv2(int aste)
        {

                return (aste  * 1.8 + 32);

        }

        int astev1 = int.Parse(Console.ReadLine());
    

        double asteet = laskuv2(astev1);
        Console.WriteLine(asteet);
        


        static string laskuv3(double kaikkilaskut, double kaikkilaskutv2)
        {
                double plus = kaikkilaskut + kaikkilaskutv2;
                double miinus = kaikkilaskut - kaikkilaskutv2;
                double jako = kaikkilaskut / kaikkilaskutv2;
                double kerto = kaikkilaskut * kaikkilaskutv2;
                string timo = string.Format("{0} {1} {2} {3}", plus, miinus, jako, kerto);

                return(timo);
                

            }

        double kaikkilaskut1 = int.Parse(Console.ReadLine());
        double kaikkilaskut2 = int.Parse(Console.ReadLine());


            string kaikkilaskutv2 = laskuv3(kaikkilaskut1, kaikkilaskut2);
        Console.WriteLine(kaikkilaskutv2);





            static double laskuv4(double jakojäänne, double jakojäännev2)
            {

                
                double timov2 = jakojäänne / jakojäännev2;
                

                return (timov2);

            }

            double jakojäännös1 = double.Parse(Console.ReadLine());
            double jakojäännös2 = double.Parse(Console.ReadLine());


            double jakojäänteet = laskuv4(jakojäännös1, jakojäännös2);
            Console.WriteLine(jakojäänteet);
        }





    }




}


