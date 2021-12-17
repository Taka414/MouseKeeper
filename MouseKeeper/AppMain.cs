using System;
using System.Windows.Forms;

namespace Takap.Utility.MouseKeeper
{
    static class AppMain
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new FormTaskTray();
            Application.Run();
        }
    }
}
