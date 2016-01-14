Iznimke
=======

HvatanjeIznimke
---------------
Ilustracija odvajanja glavne logike od dijela koji hvata i obraðuje iznimku
te oporavlja program.


TijekIzvodjenja
---------------
Ispis tijeka izvoðenja try-catch-finally blokova


FltarIznimki
------------
Primjer filtra iznimki.


BacanjeIznimkeUPozvanojMetodi
-----------------------------
Primjer izvoðenja try-catch-finally kada je iznimka baèena unutar pozvane metode.


RukovateljNeobradjenihIznimki
----------------------------
Primjer definiranja obrade UnhandledException dogaðaja
Ovo omoguæava da zapišemo sve neuhvaæene iznimke (npr. u log datoteku), 
no program æe još uvijek imati unhandled exception!


IznimkeWinForms
---------------
Primjer ponašanja WinForms aplikacije kod neobraðene iznimke.


IznimkePerfMon
--------------
Program generira iznimke u odreðenim vremenskim intervalima da bismo
ih mogli pratiti u PERFMON aplikaciji
TODO: 
1. Izgraditi program IznimkePerfmon
2. Pokrenut program iz Windows (ne iz Visual Studija)
3. U Windowsima potražiti program PerfMon (Performance Monitor) te ga pokrenuti
4. U PerfMon-u kliknuti na crveni + i u popisu brojaèa potražiti .NET CLR Exceptions
5. Proširiti stavku .NET CLR Exceptions i u njoj odabrati "# of Exceps Thrown"" 
6. U popisu objekata potražiti i selektirati "IznimkePerfMon" te pritisnuti tipku Add
7. U programu IznimkePerfmon pritisnuti tipku za bacanje iznimki te pratiti prikaz u PerfMonu

