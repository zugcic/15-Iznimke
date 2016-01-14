using System;
using System.IO;

namespace Vsite.CSharp
{
    // Primjer filtera iznimki
    class Program
    {
        static void Main(string[] args)
        {
            // u petlji bacamo razlièite tipove iznimki i pratimo tko æe ih uhvatiti
            Exception[] iznimke = new Exception[] { new FileNotFoundException(), 
                new ArgumentOutOfRangeException(), new ArgumentException() };

            for (int i = 0; i < iznimke.Length; ++i)
            {
                try
                {
                    throw iznimke[i];
                }
                // TODO: Složiti filtere iznimki tipa Exception, ArgumentOutOfRangeException i ArgumentException te provjeriti koja æe iznimka biti uhvaæena u kojem bloku.
                catch (Exception e)
                {
                    Console.WriteLine("Exception");
                    Console.WriteLine(e);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
