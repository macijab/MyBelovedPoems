using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericMethod
{
    class Całka
    {
        private double wynik;
        private double h;
        private int liczba_przedzialow;
        public int getLP()
        {
            return liczba_przedzialow;
        }
        public void setLP(int a)
        {
            this.liczba_przedzialow = a;
        }

        public double getWynik()
        {
            return wynik;
        }
        public void setWynik(double a)
        {
            this.wynik = a;
        }

        public double metodaTrapezów(double a, double b,double c, double d)
        {
            double wartoscCalki = 0;
            h = ((b - a) / liczba_przedzialow);
            for (double i = a; i <= b; i += h)
                wartoscCalki += ((c + d) / 2) * h;
            return wartoscCalki;
        }
    }
}
