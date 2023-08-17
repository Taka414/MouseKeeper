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
            IsSuspend = false;
        }

        private string TEXT_EXEC = "ステータス: 実行中";
        private string TEXT_SUSPEND = "ステータス: 一時停止中";

        private void Timer_Tick(object sender, EventArgs e)
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
                        ToolStripMenuItem_Status.Text = $"{TEXT_EXEC}, {DateTime.Now:yyyy/MM/dd HH:mm:ss}";
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

        private void ToolStripMenuItem_Suspend_Click(object sender, EventArgs e)
        {
            IsSuspend = true;
        }

        private void ToolStripMenuItem_Resume_Click(object sender, EventArgs e)
        {
            IsSuspend = false;
        }

        // ツールメニューを一時停止に設定するかどうか
        // true: 一時停止 / false: それ以外
        private bool IsSuspend
        {
            set
            {
                ToolStripMenuItem_Suspend.Enabled = !value;
                ToolStripMenuItem_Resume.Enabled = value;
                ToolStripMenuItem_Status.Text = value ? TEXT_SUSPEND : TEXT_EXEC;
                Timer.Enabled = !value;
            }
        }
    }
}
