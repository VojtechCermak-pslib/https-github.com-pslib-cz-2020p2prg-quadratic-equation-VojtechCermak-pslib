using System;

namespace kvadratická_rovnice
{
    class Program
    {
        static void Main(string[] args)
        {
            int cisloA;
            int cisloB;
            int cisloC;
            float Diskriminant;
            double vysledek1;
            double vysledek2;

            bool success = false;
            do
            {
                do
                {
                    Console.WriteLine("napiš číslo A: ");
                    string vstupa = Console.ReadLine();
                    success = Int32.TryParse(vstupa, out cisloA);
                    Console.WriteLine(cisloA);
                }
                while (cisloA == 0);

                Console.WriteLine("napiš číslo B:");
                string vstupb = Console.ReadLine();
                success = Int32.TryParse(vstupb, out cisloB);
                Console.WriteLine(cisloB);

                Console.WriteLine("napiš číslo C:");
                string vstupc = Console.ReadLine();
                success = Int32.TryParse(vstupc, out cisloC);
                Console.WriteLine(cisloC);
            }
            while (success == false);

            Diskriminant = (cisloB * cisloB) - (4 * cisloA * cisloC);
            if (Diskriminant == 0)
            {
                vysledek1 = cisloB / (2 * cisloA);
                Console.WriteLine("vysledek = " + vysledek1);
            }
            else if (Diskriminant < 0)
            {
                Console.WriteLine("diskriminant = 0 rovnice nemá řešení");
            }
            else
            {
                vysledek1 = (-cisloB + Math.Sqrt(Diskriminant) / (2 * cisloA));
                vysledek2 = (-cisloB - Math.Sqrt(Diskriminant) / (2 * cisloA));
                Console.WriteLine("vysledek 1 = " + vysledek1);
                Console.WriteLine("vysledek 2 = " + vysledek2);
            }
        }
    }
}