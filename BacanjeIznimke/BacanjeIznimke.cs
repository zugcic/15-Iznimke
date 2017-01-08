using System;

namespace Vsite.CSharp
{
    // Jednostavni primjer kako iznimke omogućavaju odvajanje
    // glavne logike od hvatanja i oporavka 
    public class BacanjeIznimke
    {

        public static int Faktorjel(int broj)
        {
            // TODO: Dodati u metodu provjeru je li argument manji od 0 i u tom slučaju baciti iznimku tipa ArgumentOutOfRangeException s odogovarajućom porukom

            int rezultat = 1;
            for (int i = 2; i <= broj; ++i)
                rezultat *= i;
            return rezultat;
        }

        static void Main(string[] args)
        {
            // TODO: Provjeriti koju iznimku će baciti metoda faktorjel u donjoj petlji te na osnovu toga...
            // TODO: Donje petlje obuhvatiti try-catch blokom koji će prekinuti daljnje računanje kada bude bačena iznimka

            {
                for (int n = 1; n < 20; ++n)
                {
                    for (int k = 1; k <= n; ++k)
                    {
                        int povrh = Faktorjel(n) / (Faktorjel(k) * Faktorjel(n - k));
                        Console.WriteLine("{0} povrh  {1} = {2}", n, k, povrh);
                    }
                }
            }


            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
