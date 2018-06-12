using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NumericMethod
{
    class PunktComparer
    {
        public int Compare(object x, object y)
        {
            Punkt xPunkt = x as Punkt; //rzutowanie
            Punkt yPunkt = y as Punkt;
            return String.Compare(xPunkt.ToString(), yPunkt.ToString());
        }
    }
}
