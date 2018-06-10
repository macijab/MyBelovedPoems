using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CałkowanieNumeryczne
{
    class Obliczenia
    {
        private double h;
        private int nrFunkcji { get; set; }
        public double WartoscwPunkcie(double x, int nrFunkcji)
        {
            
            double a = 0;
            switch (nrFunkcji)
            {
                case 1:
                    a = 2 * Math.Pow(x, 2);
                    break;
                case 2:
                    a = Math.Exp(-Math.Pow(x, 2));
                    break;
                case 3:
                    a = Math.Cos(x);
                    break;
                case 4:
                    a = Math.Sqrt(1 - Math.Pow(x, 2));
                    break;
                default:
                    MessageBox.Show("zaznacz jaką chcesz całke policzyć");
                    break;
            }
            return a;
        }
        //metoda prostokatow
        public double Calka_Prostokaty(double a, double b, double n)
        {
            double wartoscCalki = 0;
            h = ((b - a)) / n;
            for (double i = a; i <= b; i += h)
                wartoscCalki += (h * WartoscwPunkcie( i, nrFunkcji)); 
            return wartoscCalki;
        }
        public double Calka_Trapezy(double a, double b, double n)
        {
            double wartoscCalki = 0;
            h = (b - a) / n;
            for (double i = a; i <= b; i += h)
                wartoscCalki += (WartoscwPunkcie(i, nrFunkcji));
            return wartoscCalki;
        }
        //metoda parabol Simpsona
        double CalkaParabole(double a, double b, int n)
        {
            double x;
            double s = 0;
            double wartoscCalki = 0;
            h = ((b - a) / n); //dx
            for (int i = 1; i < n; i++)
            {
                x = a + i * h;
                s += WartoscwPunkcie(x - h / 2, nrFunkcji);
                wartoscCalki += WartoscwPunkcie(x, nrFunkcji);
            }
            s += WartoscwPunkcie(b - h / 2, nrFunkcji);
            wartoscCalki = (h / 6) * (WartoscwPunkcie(a, nrFunkcji) + WartoscwPunkcie(b, nrFunkcji) + 2 * wartoscCalki + 4 * s);
            return wartoscCalki;
        }
        //metoda Monte Carlo (losowanie punktów)
        double CalkaLosowanie(double a, double b, int n)
        {
            double wartoscCalki = 0;
            int PunktowPodFunkcja = 0;
            double max = 0;
            double min = 0;
            h = ((b - a) / n);

            //zakres losowania
            for (double i = a; i < b; i += h)
            {
                if (WartoscwPunkcie(i, nrFunkcji) > max) max = WartoscwPunkcie(i, nrFunkcji);
                if (WartoscwPunkcie(i, nrFunkcji) < min) min = WartoscwPunkcie(i, nrFunkcji);
            }
            //losowanie punktow
            Random rand = new Random();
            for (int i = 1; i < n; i++)
            {
                Punkt punkt = new Punkt((rand.NextDouble() * (b - a) + a), (rand.NextDouble() * (max - min) + min));
                if (punkt.y < WartoscwPunkcie(punkt.x, nrFunkcji))
                    PunktowPodFunkcja++;
            }
            wartoscCalki = (((double)PunktowPodFunkcja / n) * ((b - a) * (max - min)));
            return wartoscCalki;
        }
        //metoda Monte Carlo (srednia)
        double CalkaSrednia(double a, double b, int n)
        {
            double wartoscCalki = 0;
            double srednia = 0;
            double punkt;
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                punkt = (rand.NextDouble() * (b - a) + a);
                srednia += (WartoscwPunkcie(punkt, nrFunkcji) / n);
            }
            wartoscCalki = srednia * (b - a);
            return wartoscCalki;
        }
    }

    class Punkt
    {
  
        double x;
        double y;
        public Punkt(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}

