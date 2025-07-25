using System;
using System.Windows.Forms;

namespace SarasaviLibrarySystem
{
    static class Program
    {
        /// <summary>
        /// Main entry point of the Sarasavi Library System application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable visual styles and compatible text rendering
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the Inquiry Form as the startup form
            Application.Run(new FormInquiry());
        }
    }
}
