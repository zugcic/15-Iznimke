using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vsite.CSharp
{
    // Program generira iznimke u određenim vremenskim intervalima da bismo
    // ih mogli pratiti u PERFMON aplikaciji
    // Nakon što ovaj program pokrenemo (moramo isključiti hvatanje 
    // DivideByZeroException u Visual Studiju!), treba pokrenuti 
    // PerfMon.exe i uključiti praćene .NET CLR Exceptions. Nakon toga kliknemo
    // na tipku da naša aplikacija počne bacati iznimke.
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}