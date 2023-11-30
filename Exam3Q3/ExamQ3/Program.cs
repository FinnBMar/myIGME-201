using System;
using System.Windows.Forms;

namespace FrustratingUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of the main form
            System.Windows.Forms.Timer mainFormTimer = new System.Windows.Forms.Timer();
            Application.Run(new MainForm(mainFormTimer));
        }
    }
}
