using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;

namespace CIPERules_Client
{
    public partial class MainForm : MetroSetForm
    {

        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern short VkKeyScan(char ch);

        private WebClient wc_DebugCaptcha = new WebClient();
        private string debugCaptchaResult = String.Empty;
        private IntPtr discordHwnd = IntPtr.Zero;

        // Captcha
        private string captchaToSend = "{NO-CAPTCHA-FOR-USER}";
        private bool captchaRequired = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            worker_debugCaptcha.RunWorkerAsync();
            captchaHandler.RunWorkerAsync();
        }

        private void Worker_debugCaptcha_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {

                if (wc_DebugCaptcha.DownloadString($"http://127.0.0.1/checkNeedCaptcha.php?idDiscord={txt_debugCaptchaDiscordID.Text}").Contains("true"))
                {
                    do
                    {
                        captchaToSend = wc_DebugCaptcha.DownloadString($"http://127.0.0.1/getCaptcha.php?idDiscord={txt_debugCaptchaDiscordID.Text}");
                        Thread.Sleep(1000);
                    } while (captchaToSend.Contains("{NO-CAPTCHA-FOR-USER}"));


                    captchaRequired = true;
                }

                debugCaptchaResult = captchaToSend;

                Thread.Sleep(1000);
            }

        }

        public static int BuildLParam(int low, int high)
        {
            return (int)(((uint)high << 16) | (uint)low);
        }

        public static void Click(IntPtr prmHwnd, Point Location)
        {
            Point currentPos = Cursor.Position;
            int coordinates = BuildLParam(Location.X, Location.Y);
            SendMessage(prmHwnd, (int)WindowsMessage.WM_MOUSEMOVE, 0, coordinates);
            SendMessage(prmHwnd, (int)WindowsMessage.WM_LBUTTONDOWN, 1, coordinates);
            SendMessage(prmHwnd, (int)WindowsMessage.WM_MOUSEMOVE, 1, coordinates);
            SendMessage(prmHwnd, (int)WindowsMessage.WM_LBUTTONUP, 0, coordinates);
            coordinates = BuildLParam(currentPos.X, currentPos.Y);
            SendMessage(prmHwnd, (int)WindowsMessage.WM_MOUSEMOVE, 0, coordinates);
        }

        public static Keys ConvertCharToVirtualKey(char ch)
        {
            short vkey = VkKeyScan(ch);
            Keys retval = (Keys)(vkey & 0xff);
            int modifiers = vkey >> 8;
            if ((modifiers & 1) != 0) retval |= Keys.Shift;
            if ((modifiers & 2) != 0) retval |= Keys.Control;
            if ((modifiers & 4) != 0) retval |= Keys.Alt;
            return retval;
        }

        public static void WriteAndReturn(IntPtr prmHwnd, string text)
        {

            foreach (char ch in text)
            {
                PostMessage(prmHwnd, (int)WindowsMessage.WM_KEYDOWN, (int)ConvertCharToVirtualKey(ch), 0);
                Thread.Sleep(50);
            }

            PostMessage(prmHwnd, (int)WindowsMessage.WM_KEYDOWN, (int)0x0D, 0);

        }

        private void MetroSetButton1_Click(object sender, EventArgs e)
        {
            discordHwnd = FindWindow("Chrome_WidgetWin_1", txt_discordWindowTitle.Text);
            MoveWindow(discordHwnd, 0, 0, 940, 500, true);
        }

        private void MetroSetButton2_Click(object sender, EventArgs e)
        {
            Point p = new Point(393, 454);
            Click(discordHwnd, p);
            Thread.Sleep(500);
            WriteAndReturn(discordHwnd, "");
        }

        private void CaptchaHandler_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (captchaRequired)
                {
                    Point p = new Point(393, 454);
                    Click(discordHwnd, p);
                    Thread.Sleep(500);
                    WriteAndReturn(discordHwnd, captchaToSend);
                    captchaRequired = false;
                }
                Thread.Sleep(1000);
            }

        }
    }
}
