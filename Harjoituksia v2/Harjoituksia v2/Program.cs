using System;

namespace Harjoituksia_v2
{
    class Program
    {
        static void Main()
        {
            int ekanumero = int.Parse(Console.ReadLine());
            int tokanumero = int.Parse(Console.ReadLine());
            int kolmasnumero = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(ekanumero, tokanumero), kolmasnumero));

        }
    }
}
