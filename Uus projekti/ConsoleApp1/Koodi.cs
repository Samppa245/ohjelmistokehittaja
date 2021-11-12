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
            Nim = nimi;
            kirj = kirjoittaja;
            siv = sivut;
            onklain = onkolainattu;
            t = tunnus;

        }







        public string lainauscheck()
        {
            if (onklain == "Ei")
            {
                return onklain = "Kyllä";
            }
            else
            {
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
