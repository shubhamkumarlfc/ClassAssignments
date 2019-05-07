using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;

namespace WindowsFormsApp_Assignment3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String path = AppDomain.CurrentDomain.BaseDirectory;
            Log.Logger = new LoggerConfiguration().WriteTo.File(path + @"..\..\Logs\assignment3.log").CreateLogger();
            Log.Information("Windows form application has Started");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
