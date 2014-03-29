using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClanMon
{
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
            Clock PerfTimer = new Clock();
            frmClanMon frmClanMain = new frmClanMon();
            frmClanMain.Show();
            frmClanMain.Subscribe(PerfTimer);

            PerfTimer.Run();

        }
    }
}
