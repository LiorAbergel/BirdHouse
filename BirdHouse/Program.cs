using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace BirdHouse
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // before starting application , we check if Microsoft Excel is installed
            // if not, the application can't start22

            ApplicationConfiguration.Initialize();
            Application.Run(new LogInForm());
     
        }
    }
}