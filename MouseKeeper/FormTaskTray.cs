using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Takap.Utility.MouseKeeper
{
    /// <summary>
    /// 常駐タスクトレイを表します。
    /// </summary>
    public partial class FormTaskTray : Form
    {
        DateTime _lastMoved;
        DateTime _movedPos;
        Point _pos;

        [DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public FormTaskTray()
        {
            InitializeComponent();
            Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                // 45秒以上位置が変わらなかった場合30秒に一度ポインタを刺激する
                var now = DateTime.Now;

                var pos = Cursor.Position;
                if (_pos != pos)
                {
                    _lastMoved = now;
                }
                _pos = pos;

                if (now - _lastMoved > TimeSpan.FromSeconds(45))
                {
                    if (now - _movedPos > TimeSpan.FromSeconds(30))
                    {
                        _movedPos = now;
                        Trace.WriteLine($"[{now:HH:mm:ss.fff}] Move. {pos}");

                        mouse_event(1, 0, 0, 0, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }
        }

        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
