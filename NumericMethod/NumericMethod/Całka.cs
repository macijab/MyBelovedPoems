using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericMethod
{
    class Całka
    {
        private double wynik;//wynik całkowania
        private double h;//wysokość trapezu
        private int liczba_przedzialow;//liczba przedziałów całkowania
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
        public double adbs(double a)//metoda zwracająca wartość bezwzględną
        {
            if (a < 0)
            {
                return a * (-1);
            }
            else
            {
                return a;
            }
        }

        public double metodaTrapezów(double a, double b,double c, double d)//metoda licząca całke metodą trapezów, gdzie a i b to argumenty a c i d to watrości funkcji
        {
            double wartoscCalki = 0;//ustawienie początkowej wartości całki
            h = adbs(((b - a) / liczba_przedzialow));//policzenie wysokości trapezu
            for (double i = a; i <= b; i += h)//pętla licząccza z punktu a do punktu b pole całki 
                wartoscCalki += ((c + d) / 2) * h;
            return wartoscCalki;
        }
    }
}
