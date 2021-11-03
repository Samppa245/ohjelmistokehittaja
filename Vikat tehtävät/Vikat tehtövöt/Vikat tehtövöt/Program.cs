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
            // teht 3
           
            

        }
    }
}
