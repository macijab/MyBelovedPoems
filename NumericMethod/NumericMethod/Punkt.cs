using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericMethod
{
    class Punkt
    {
        private double x;//argument funkcji
        private double y;//wartość funkcji
        public Punkt(double x, double y)//konstruktor
        {
            this.x = x;
            this.y = y;
        }
        public double getX()
        {
            return this.x;
        }
        public double getY()
        {
            return this.y;
        }
        public void setX(double a)
        {
            this.x = a;
        }
        public void setY(double a)
        {
            this.y = a;
        }
        public void setXY(double x, double y)//ustawienie jednocześnie argumentu i wartości
        {
            this.x = x;
            this.y = y;
        }

    }
}
