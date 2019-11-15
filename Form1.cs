using RunScreenSaver.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunScreenSaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timerWait_Tick(object sender, EventArgs e)
        {
            var info = new LASTINPUTINFO();
            info.size = Marshal.SizeOf(info);
            if (GetLastInputInfo(ref info))
            {
                var delta = (int)(GetTickCount() - info.dwTime);
                var rest = 1000 * 60 * Settings.Default.WaitMinutes - delta;
                if (rest < 0)
                {
                    testStart.PerformClick();
                }

                waitLabel.Text = $"{rest / 1000 / 60:0} 分";
            }
        }

        private const uint WM_SYSCOMMAND = 0x112;
        private const uint SC_SCREENSAVE = 0xF140;

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

        [DllImport("user32.dll")]
        static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        [StructLayout(LayoutKind.Sequential)]
        struct LASTINPUTINFO
        {
            public int size;
            public uint dwTime;
        }

        [DllImport("kernel32.dll")]
        static extern uint GetTickCount();

        private void saveButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            MessageBox.Show("保存しました。");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            screenSavers.Items.Clear();
            screenSavers.Items.AddRange(
                Directory.GetFiles(Environment.SystemDirectory, "*.scr")
                    .Select(filePath => Path.GetFileNameWithoutExtension(filePath))
                    .ToArray()
            );
        }

        private void testStart_Click(object sender, EventArgs e)
        {
            //PostMessage(Handle, WM_SYSCOMMAND, SC_SCREENSAVE, 0);

            var exeFile = Path.Combine(Environment.SystemDirectory, Settings.Default.SelectedScreenSaver + ".scr");
            if (!File.Exists(exeFile))
            {
                return;
            }

            Process.Start(exeFile, "/S");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowNow();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = Visible && e.CloseReason == CloseReason.UserClosing;

            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void showMenu_Click(object sender, EventArgs e)
        {
            ShowNow();
        }

        private void ShowNow()
        {
            WindowState = FormWindowState.Normal;
            Show();
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerAutoHide_Tick(object sender, EventArgs e)
        {
            Hide();
            timerAutoHide.Stop();
        }
    }
}
