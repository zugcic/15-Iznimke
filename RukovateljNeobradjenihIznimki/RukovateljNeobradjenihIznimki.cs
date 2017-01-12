using System;
using System.Collections.Generic;
using System.Text;

namespace Vsite.CSharp	  //DZ
{
    // Primjer definiranja obrade UnhandledException događaja
    // Ovo omogućava da zapišemo sve neuhvaćene iznimke (npr. 
    // u log datoteku), no program će još uvijek imati
    // unhandled exception!
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Odkomentirati donju naredbu te događaju UnhandledException prdružiti rukovatelja koji će ispisati podatke o neuhvaćenoj iznimci te pozvati Console.ReadKey() da privremeno zaustavi izvođenje. Pokrenuti program i provjeriti ponašanje.
            //AppDomain.CurrentDomain.UnhandledException;

            try
            {
                throw new Exception("1");
            }
            catch (Exception e)
            {
                Console.WriteLine("Uhvaćena iznimka: " + e.Message);
            }
            throw new Exception("2");
        }

    }
}
