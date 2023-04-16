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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _ = new FormTaskTray();
            Application.Run();
        }
    }
}
