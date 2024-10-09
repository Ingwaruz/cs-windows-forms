using System;
using System.Windows.Forms;

namespace last
{
    internal static class Program
    {        
        // Главная точка входа для приложения.        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new brahistohrone.Form1());
        }
    }
}
