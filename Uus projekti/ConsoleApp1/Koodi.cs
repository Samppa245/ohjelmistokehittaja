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
        string onklain;
        string t;
        public Koodi(string nimi, string kirjoittaja, string sivut, string onkolainattu, string tunnus)
        {
            Nim = "Kirja: " + nimi;
            kirj = "Kirjoittajan nimi: " + kirjoittaja;
            siv = "Sivujen määrä: " + sivut;
            onklain = onkolainattu;
            t = "Tuoteavain: " + tunnus;

        }







        public string lainauscheck()
        {
            if (onklain == "Ei")
            {
                Console.WriteLine("Kirja on lainattu");
                return onklain = "Kyllä";
            }
            else
            {
                Console.WriteLine("Kirjaa ei voi lainata uuestaan");
                return "";
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


                return onklain = "Ei";
            }
            else
            {
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
