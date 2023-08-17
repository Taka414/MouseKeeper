using System;
using System.Windows.Forms;

namespace Takap.Utility.MouseKeeper
{
    static class Program
    {
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
            using (FormTaskTray formTaskTray = new FormTaskTray())
            {
                Application.Run();
            }
        }
    }
}