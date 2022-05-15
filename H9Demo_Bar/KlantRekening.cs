using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H9Demo_Bar
{
    class KlantRekening
    {
        private List<int> kosten = new List<int>();

        public void VoegToe(int aantal, int prijs)
        {
            kosten.Add(aantal * prijs);
        }

        public void Rekenaf()
        {
            int som = BerekenSom();
            Console.WriteLine($"Totaal = {som}");
            kosten.Clear();

        }

        private int BerekenSom()
        {
            int som = 0;
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
