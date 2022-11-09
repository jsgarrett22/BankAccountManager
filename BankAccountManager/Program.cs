using System;
using System.Windows.Forms;

/**
 * Bank Account Manager
 * Simulates a bank account GUI interface with appropriate functionality.
 * Written by: Joshua S. Garrett
 * 11/07/2022
 */
namespace BankAccountManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
