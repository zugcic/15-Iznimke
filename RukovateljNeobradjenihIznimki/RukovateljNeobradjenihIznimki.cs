using System;
using System.Collections.Generic;
using System.Text;

namespace Vsite.CSharp
{
    // Primjer definiranja obrade UnhandledException dogaðaja
    // Ovo omoguæava da zapišemo sve neuhvaæene iznimke (npr. 
    // u log datoteku), no program æe još uvijek imati
    // unhandled exception!
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Odkomentirati donju naredbu te dogaðaju UnhandledException prdružiti rukovatelja koji æe ispisati podatke o neuhvaæenoj iznimci te pozvati Console.ReadKey() da privremeno zaustavi izvoðenje. Pokrenuti program i provjeriti ponašanje.
            //AppDomain.CurrentDomain.UnhandledException;

            try
            {
                throw new Exception("1");
            }
            catch (Exception e)
            {
                Console.WriteLine("Uhvaæena iznimka: " + e.Message);
            }
            throw new Exception("2");
        }

    }
}
