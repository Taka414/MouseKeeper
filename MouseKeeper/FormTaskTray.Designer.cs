namespace Takap.Utility.MouseKeeper
{
    partial class FormTaskTray
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaskTray));
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Status = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Suspend = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Resume = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.ContextMenuStrip;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "MouseKeeper";
            this.NotifyIcon.Visible = true;
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Status,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_Suspend,
            this.ToolStripMenuItem_Resume,
            this.toolStripSeparator2,
            this.ToolStripMenuItem_Exit});
            this.ContextMenuStrip.Name = "contextMenuStrip";
            this.ContextMenuStrip.Size = new System.Drawing.Size(203, 144);
            // 
            // ToolStripMenuItem_Status
            // 
            this.ToolStripMenuItem_Status.Enabled = false;
            this.ToolStripMenuItem_Status.Name = "ToolStripMenuItem_Status";
            this.ToolStripMenuItem_Status.Size = new System.Drawing.Size(202, 32);
            this.ToolStripMenuItem_Status.Text = "状態";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // ToolStripMenuItem_Suspend
            // 
            this.ToolStripMenuItem_Suspend.Name = "ToolStripMenuItem_Suspend";
            this.ToolStripMenuItem_Suspend.Size = new System.Drawing.Size(202, 32);
            this.ToolStripMenuItem_Suspend.Text = "一時停止 (&S)";
            this.ToolStripMenuItem_Suspend.Click += new System.EventHandler(this.ToolStripMenuItem_Suspend_Click);
            // 
            // ToolStripMenuItem_Resume
            // 
            this.ToolStripMenuItem_Resume.Name = "ToolStripMenuItem_Resume";
            this.ToolStripMenuItem_Resume.Size = new System.Drawing.Size(202, 32);
            this.ToolStripMenuItem_Resume.Text = "再開 (&R)";
            this.ToolStripMenuItem_Resume.Click += new System.EventHandler(this.ToolStripMenuItem_Resume_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(202, 32);
            this.ToolStripMenuItem_Exit.Text = "終了(&X)";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FormTaskTray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 146);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "FormTaskTray";
            this.ShowInTaskbar = false;
            this.Text = "Form";
            this.ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Suspend;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Resume;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Status;
    }
}

