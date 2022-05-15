using System;
using System.Collections.Generic;

namespace H9Demo_Bar
{
    class Program
    {
        static void Main(string[] args)
        {

            KostberekeningsStrategie actueleStrategie = new NormaleStrategie();
            List<KlantRekening> klanten = new List<KlantRekening>();
            for (int i = 0; i < 10; i++)
            {
                klanten.Add(new KlantRekening());
            }

            string keuze = "";
            do
            {
                Console.Clear();
                ToonTitel(actueleStrategie);
                PrintAlleRekeningen(klanten);
                keuze = ToonMenuEnVraagInvoer();
                switch (keuze)
                {
                    case "a":
                        Console.WriteLine("Welke klantnummer? (0-9)");
                        int klant = int.Parse(Console.ReadLine());
                        Console.WriteLine("Hoeveel consumpties?");
                        int aantal = int.Parse(Console.ReadLine());
                        Console.WriteLine("Prijs consumpties?");
                        double prijs = double.Parse(Console.ReadLine());
                        klanten[klant].VoegToe(aantal, prijs, actueleStrategie);
                        break;
                    case "r":
                        Console.WriteLine("Welke klantnummer? (0-9)");
                        int klantr = int.Parse(Console.ReadLine());
                        klanten[klantr].Rekenaf();
                        break;

                    case "h":
                        if (actueleStrategie is NormaleStrategie)
                        {
                            Console.WriteLine("Happy hour  actief");
                            actueleStrategie = new HappyHourStrategie();
                        }
                        else
                        {
                            Console.WriteLine("Happy hour actief");
                            actueleStrategie = new NormaleStrategie();
                        }
                      
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            } while (keuze!="q");
        }

        private static void PrintAlleRekeningen(List<KlantRekening> klanten)
        {
            for (int i = 0; i < klanten.Count; i++)
            {
                Console.WriteLine($"{i}: {klanten[i]}");
            }
        }

        private static string ToonMenuEnVraagInvoer()
        {
            Console.WriteLine("Wat wil je doen?");
            Console.WriteLine("\t a : order invoeren");
            Console.WriteLine("\t r : afrekenen ");
            Console.WriteLine("\t h : happy hour starten/stoppen");
            Console.WriteLine("\t q : stoppen");
            return Console.ReadLine();
        }

        private static void ToonTitel(KostberekeningsStrategie actueleStrategie)
        {
            string title = @"
__________________ _______  _______    ______   _______  _______ 
\__   __/\__   __/(       )(  ____ \  (  ___ \ (  ___  )(  ____ )
   ) (      ) (   | () () || (    \/  | (   ) )| (   ) || (    )|
   | |      | |   | || || || (_____   | (__/ / | (___) || (____)|
   | |      | |   | |(_)| |(_____  )  |  __ (  |  ___  ||     __)
   | |      | |   | |   | |      ) |  | (  \ \ | (   ) || (\ (   
   | |   ___) (___| )   ( |/\____) |  | )___) )| )   ( || ) \ \__
   )_(   \_______/|/     \|\_______)  |/ \___/ |/     \||/   \__/
                                                                 
";
            if (actueleStrategie is HappyHourStrategie)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.WriteLine(title);
            Console.ResetColor();
        }
    }
}
