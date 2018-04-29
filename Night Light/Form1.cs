using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Management; //Need to add System.Management dll to References
using Microsoft.Win32;
using System.Timers;

namespace Night_Light
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Start window in bottom right corner
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);

            //Start window in top right corner
            //this.StartPosition = FormStartPosition.Manual;
            //foreach (var scrn in Screen.AllScreens)
            //{
            //    if (scrn.Bounds.Contains(this.Location))
            //    {
            //        this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Top);
            //        return;
            //    }
            //}

        }

        public static void SetDisplay()
        {
            if (isTimeInRange())
            {
                SetBrightness(50);
                SetGamma(70);
            }
            else
            {
                SetBrightness(100);
                SetGamma(200);
            }
        }

        int gamma;
        private void btnSet_Click(object sender, EventArgs e)
        {
            if (cboGamma.Text == "Select Gamma")
                MessageBox.Show("Select Gamma Value");
            else
                gamma = int.Parse(cboGamma.Text);

            SetGamma(gamma);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetGamma(150);
        }

        private void tbrBrightness_Scroll(object sender, EventArgs e)
        {
            byte b = 0;
            if (byte.TryParse(tbrBrightness.Value + "", out b))
            {
                SetBrightness(b);
                lblBrightnessVal.Text = b + "%";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.WindowState = FormWindowState.Normal;
            if (isRunAtStartup())
            {
                cbxRunAtStartup.Checked = true;
            }
            SetDisplay();

            var initBrig = GetBrightness();
            lblBrightnessVal.Text = initBrig + "%";
            tbrBrightness.Value = initBrig;
        }

        private void cbxRunAtStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRunAtStartup.Checked)
            {
                SetStartup(true);
            }
            else
                SetStartup(false);
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("gdi32.dll")]
        public static extern bool SetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct RAMP
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Red;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Green;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Blue;
        }

        public static void SetGamma(int gamma)
        {
            if (gamma <= 256 && gamma >= 1)
            {
                RAMP ramp = new RAMP();
                ramp.Red = new ushort[256];
                ramp.Green = new ushort[256];
                ramp.Blue = new ushort[256];
                for (int i = 1; i < 256; i++)
                {
                    int iArrayValue = i * (gamma + 128);

                    if (iArrayValue > 65535)
                        iArrayValue = 65535;
                    ramp.Red[i] = ramp.Blue[i] = ramp.Green[i] = (ushort)iArrayValue;
                }
                SetDeviceGammaRamp(GetDC(IntPtr.Zero), ref ramp);
            }
        }
        static void SetBrightness(byte targetBrightness)
        {
            ManagementScope scope = new ManagementScope("root\\WMI");
            SelectQuery query = new SelectQuery("WmiMonitorBrightnessMethods");
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query))
            {
                using (ManagementObjectCollection objectCollection = searcher.Get())
                {
                    foreach (ManagementObject mObj in objectCollection)
                    {
                        mObj.InvokeMethod("WmiSetBrightness",
                            new Object[] { UInt32.MaxValue, targetBrightness });
                        break;
                    }
                }
            }
        }
        static int GetBrightness()
        {
            ManagementScope scope = new ManagementScope("root\\WMI");
            SelectQuery query = new SelectQuery("WmiMonitorBrightness");
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query))
            {
                using (ManagementObjectCollection objectCollection = searcher.Get())
                {
                    foreach (ManagementObject mObj in objectCollection)
                    {
                        var br_obj = mObj.Properties["CurrentBrightness"].Value;

                        int br = 0;
                        int.TryParse(br_obj + "", out br);
                        return br;
                        //break;
                    }
                }
            }
            return 0;

        }

        private void SetStartup(bool RunAtStartup)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (RunAtStartup)
                rk.SetValue(Application.ProductName, Application.ExecutablePath);
            else
                rk.DeleteValue(Application.ProductName, false);

        }
        private bool isRunAtStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            var val = rk.GetValue(Application.ProductName);

            if (val + "" == Application.ExecutablePath)
                return true;
            else
                return false;

        }

        public static bool isTimeInRange()
        {
            TimeSpan start = TimeSpan.Parse("18:00");
            TimeSpan end = TimeSpan.Parse("06:00");
            TimeSpan now = DateTime.Now.TimeOfDay;

            // start and stop times are in different days
            if (now >= start || now <= end)
            {
                return true;
                // current time is between start and stop
            }
            else return false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //Hide main window and minimize to task bar
        {
            //
        }

        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Form1 frm = new Form1();
                frm.Show();
                if(this.WindowState == FormWindowState.Minimized)
                    this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            //notifyIcon1.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
            }
            //e.Cancel = true;
            //WindowState = FormWindowState.Minimized;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             SetDisplay();
        }
    }
}
