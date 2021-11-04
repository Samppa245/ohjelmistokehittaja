using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtavia_vika
{
    class Peruslaskut
    {
        int summa;
        int erotus;
        int osamaara;
        int tulo;
        public int Summa(int a, int b)
        {
            return a + b;
        }
        public int Erotus(int a, int b)
        {

            return a - b;
        }
        public double Osamaara(double a, double b)
        {
            return a / b;

        }
        public double Tulo(double a, double b)
        {
            return a * b;

        }

    }
}
