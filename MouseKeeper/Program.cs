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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _formTaskTray = new FormTaskTray();
            Application.Run();
        }
    }
}
