using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vsite.CSharp
{
    // Primjer obrade ThreadException u Windows.Forms aplikaciji
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Hvataj);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void Hvataj(object posiljatelj, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
            System.Diagnostics.Debugger.Launch();
        }
    }
}