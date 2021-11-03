using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtavia_vika
{
    class Class1
    {
        string tilinumero;
        double saldo;
        string etunimi;
        string sukunimi;

        public Class1(string enimi, string snimi, string tnumero, double sldo)
        {
            etunimi = enimi;
            sukunimi = snimi;
            tilinumero = tnumero;
            saldo = sldo;

        }
        public double Naytasaldo()
        {
            return saldo; 

        }
        public void Pano(double raha)
        {
            saldo += raha;
        }
        public void Otto(double raha)
        {
            if(raha > saldo)
            {
                Console.WriteLine("Tilillasi ei ole tarpeeksi rahaa");


            }
            else
            {
                saldo -= raha;
                Naytasaldo();

            }
        }
    }
}
