using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Koodi
    {
        string Nim;
        string kirj;
        string siv;
        private string onklain;
        string t;
        public Koodi(string nimi, string kirjoittaja, string sivut, string onkolainattu, string tunnus)
        {
            Nim = "kirjoittajan nimi: " + nimi;
            kirj = "kirjannimi: " + kirjoittaja;
            siv = "Sivujen määrä: " + sivut;
            onklain = onkolainattu;
            t = "Tuoteavain: " + tunnus;

        }

        public string onkokyllä

        {
           
            get { return onklain; }
            set { onklain = value; }
           
        }

        


        public void lainauscheck()
        {
            if (onklain == "Ei")
            {
                Console.WriteLine("Kirja on lainattu");
                

                onkokyllä = "Kyllä";
                
            }
            else
            {
                Console.WriteLine("Kirjaa ei voi lainata uuestaan");
           
            }
        }

        public string kirjaint()
        {
            if (onklain == "Ei")
            {
                return t;
            }
            else
            {
                return "";
            }
        }
        public string kirjannimit()
        {

            if (onklain == "Ei")
            {
                return Nim;
            }
            else
            {
                return "";
            }
        }
        public string Palautus()
        {
            if (onklain == "Kyllä")
            {

                Console.WriteLine("Kirja on palautettu");
                return onklain = "Ei";
            }
            else
            {
                Console.WriteLine("Et ole lainannut kirjaa");
                return "";
            }
        }
        public string kirjoittajat()
        {
            if (onklain == "Ei")
            {
                return kirj;
            }
            else
            {
                return "";
            }
        }
            public string sivutt()
        {
            if (onklain == "Ei")
            {
            
                return siv;
            }
            else
            {
                return "";
            }
        }
    }
}
