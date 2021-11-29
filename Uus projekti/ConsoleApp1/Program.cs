using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            
            Koodi kirja1 = new Koodi("Timo", "merimakkara", "110", "Ei", "a");
            Koodi kirja2 = new Koodi("Pekka", "Puukasamn elämänkerta", "654", "Ei", "b");
            Koodi kirja3 = new Koodi("tuomo", "seilauksen opas", "432", "Ei", "c");
            Koodi kirja4 = new Koodi("marja", "teppo ja timon seikkailu", "100", "Ei", "d");
            Koodi kirja5 = new Koodi("olli", "ollin meriseikkaile", "515", "Ei", "e");
            string kysymys;
            alkujuttu();
     
            void alkujuttu()
            {
                Console.WriteLine("Hei tervetuloa kirjastoon! Mitä haluat tehdä? Kirjoita Selata, jos haluat kirjat. Kirjoita poistua jos haluat poistua, kirjoita Lainata, jos haluat lainata ja kirjoita palautus, jos haluat palauttaa");
                kysymys = Console.ReadLine();
                if (kysymys == "Lainata" || kysymys == "lainata")
                {
                    prosessi();

                }
            if(kysymys == "Selata" || kysymys == "selata")
                {
                    selaus();
                }
            if(kysymys == "poistua" || kysymys == "Poistua")
                {
                    poistua();
                }
                if (kysymys == "Palautus" || kysymys == "palautus")
                {
                    palauttaa();
                }
            }

            void prosessi()
            {

                Console.WriteLine("Kerro tuoteavain, jos haluat lainata(tuoteavain löyty selata kohdasta)");
                    string kysymysv2 = Console.ReadLine();



                    switch (kysymysv2)
                    {
                        case "a":
                            kirja1.lainauscheck();
                            break;
                        case "b":
                            kirja2.lainauscheck();
                            break;
                        case "c":
                            kirja3.lainauscheck();
                            break;
                        case "d":
                            kirja4.lainauscheck();
                            break;
                        case "e":
                            kirja5.lainauscheck();
                            break;
                    default:
                        Console.WriteLine("Tuoteavainta ei ole olemassa");
                        break;
                    } 
                
             
         

                alkujuttu();
            }

            void palauttaa()
            {
                Console.WriteLine("Kerro kirjan tuotenumero, jonka haluat palauttaa");
                string Kysmys = Console.ReadLine();

                switch (Kysmys)
                {
                    case "a":
                        kirja1.Palautus();
                        break;
                    case "b":
                        kirja2.Palautus();
                        break;
                    case "c":
                        kirja3.Palautus();
                        break;
                    case "d":
                        kirja4.Palautus();
                        break;
                    case "e":
                        kirja5.Palautus();
                        break;
                }
                alkujuttu(); 
            }
            

            

                void selaus(){
                string[] taul1 = {   kirja1.kirjannimit(), kirja1.kirjoittajat(),  kirja1.sivutt(), kirja1.kirjaint(), "" };
                string[] taul2 = {   kirja2.kirjannimit(), kirja2.kirjoittajat(),  kirja2.sivutt(),  kirja2.kirjaint(), "" };
                string[] taul3 = {  kirja3.kirjannimit(),  kirja3.kirjoittajat(),   kirja3.sivutt(),  kirja3.kirjaint(), "" };
                string[] taul4 = {   kirja4.kirjannimit(),  kirja4.kirjoittajat(),  kirja4.sivutt(),  kirja4.kirjaint(), "" };
                string[] taul5 = {   kirja5.kirjannimit(),  kirja5.kirjoittajat(),   kirja5.sivutt(),  kirja5.kirjaint(), "" };

                foreach (string taulukot in taul1)
                    {
                        Console.WriteLine(taulukot);
                    }
                    foreach (string taulukot2 in taul2)
                    {
                        Console.WriteLine(taulukot2);
                    }
                    foreach (string taulukot3 in taul3)
                    {
                        Console.WriteLine(taulukot3);
                    }
                    foreach (string taulukot4 in taul4)
                    {
                        Console.WriteLine(taulukot4);
                    }
                    foreach (string taulukot5 in taul5)
                    {
                        Console.WriteLine(taulukot5);
                    }
                    alkujuttu();
                }
            
            void poistua()
            {
                Console.WriteLine("Kiitos käynnistä");
             
            }

        }
    }

   
}
