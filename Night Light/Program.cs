using Night_Light.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Night_Light
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //public class MyCustomApplicationContext : ApplicationContext
        //{
        //    private NotifyIcon trayIcon;

        //    public MyCustomApplicationContext()
        //    {
        //        // Initialize Tray Icon
        //        trayIcon = new NotifyIcon()
        //        {
        //            Icon = Resources.AppIcon,
        //            ContextMenu = new ContextMenu(new MenuItem[] {
        //            new MenuItem("Exit", Exit)
        //        }),
        //            Visible = true
        //        };
        //    }

        //    void Exit(object sender, EventArgs e)
        //    {
        //        // Hide tray icon, otherwise it will remain shown until user mouses over it
        //        trayIcon.Visible = false;

        //        Application.Exit();
        //    }
        //}
    }
}
