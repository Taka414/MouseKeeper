using System;
using System.Windows.Forms;

namespace Takap.Utility.MouseKeeper
{
    static class Program
    {
        static FormTaskTray _formTaskTray;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            MultiStartupUtil.SingleStartupContext("_mouse_keeper", _Main);
        }

        private static void _Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _formTaskTray = new FormTaskTray();
            try
            {
                Application.Run();
            }
            finally
            {
                using (_formTaskTray) { }
            }
        }
    }
}