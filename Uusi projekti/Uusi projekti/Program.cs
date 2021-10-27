using System;


namespace Uusi_projekti
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nimesi ?");
            string name = Console.ReadLine();
            Console.WriteLine("Hei " + name);

            if (name == "TIMO")
            {
                Console.WriteLine("moro moro");
            }

        } 
    }
}