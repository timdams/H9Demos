using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H9Demo_Bar
{
    interface KostberekeningsStrategie
    {
        double VerkrijgActuelePrijs(double basisPrijs);
    }

    class NormaleStrategie : KostberekeningsStrategie
    {
        public double VerkrijgActuelePrijs(double basisPrijs)
        {
            return basisPrijs; 
        }
    }

    class HappyHourStrategie : KostberekeningsStrategie
    {
        public double VerkrijgActuelePrijs(double basisPrijs)
        {
            return basisPrijs*0.5;
        }
    }

}
