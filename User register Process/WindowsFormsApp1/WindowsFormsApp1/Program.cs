using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            // Enable visual styles for modern look
            Application.EnableVisualStyles();

            // Use compatible text rendering
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the main form
            Application.Run(new Form1());
        }
    }
}
