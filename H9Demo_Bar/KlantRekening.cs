using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H9Demo_Bar
{
    class KlantRekening
    {
        private List<double> kosten = new List<double>();

        public void VoegToe(int aantal, double prijs, KostberekeningsStrategie strategie)
        {
            
            kosten.Add(aantal * strategie.VerkrijgActuelePrijs(prijs));
        }

        public void Rekenaf()
        {
            double som = BerekenSom();
            Console.WriteLine($"Totaal = {som}");
            kosten.Clear();

        }

        private double BerekenSom()
        {
            double som = 0;
            foreach (var kost in kosten)
            {
                som += kost;
            }

            return som;
        }

        public override string ToString()
        {
            return BerekenSom().ToString();
        }
    }
}
