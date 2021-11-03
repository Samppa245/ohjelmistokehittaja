using System;

namespace Tehtavia_vika
{
    class Program
    {
        static void Main()
        {
            /*Peruslaskut joulupukki = new Peruslaskut();
            int x = joulupukki.Summa(4, 5);
            int x2 = joulupukki.Erotus(5, 4);
            double x3 = joulupukki.Osamaara(4, 5);
            double x4 = joulupukki.Tulo(4, 5);
            Console.WriteLine("Lukujen {0} {1} summa, erotus, osamaara ja tulo ovat {2} {3} {4} {5}", 4, 5, x, x2, x3, x4);
            Console.WriteLine("Lukujen {0} {1} summa, erotus, osamaara ja tulo ovat {2} {3} {4} {5}", 4, 5, x, x2, x3, x4);
            Peruslaskut Kukkakaali = new Peruslaskut();*/
            Console.WriteLine("Päätä rahat");
            double rahat = int.Parse(Console.ReadLine());
            Class1 timo = new Class1("Timo", "Tuominen", "541414-622622", rahat);
            Console.WriteLine(timo.Naytasaldo());
            
        }
      
    }
}
