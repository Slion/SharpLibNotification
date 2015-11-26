using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace NotificationDemo
{
    public partial class DemoForm : Form
    {

        /// <summary>
        /// System tray icon.
        /// </summary>
        private SharpLib.Notification.Control iNotifyIcon;


        public DemoForm()
        {
            InitializeComponent();
        }

        private void buttonCreateNotificationIcon_Click(object sender, EventArgs e)
        {
            SetupTrayIcon();
        }


        /// <summary>
        ///
        /// </summary>
        private void SetupTrayIcon()
        {
            iNotifyIcon = new SharpLib.Notification.Control();
            iNotifyIcon.Icon = GetIcon("notification.ico");
            iNotifyIcon.Text = "TV Server Status";
            iNotifyIcon.Visible = true;

            //Double click toggles visibility - typically brings up the application

            /*
            iNotifyIcon.DoubleClick += delegate (object obj, EventArgs args)
            {
                SysTrayHideShow();
            };

            
            //Adding a context menu, useful to be able to exit the application
            ContextMenu contextMenu = new ContextMenu();
            //Context menu item to toggle visibility
            MenuItem hideShowItem = new MenuItem("Hide/Show");
            hideShowItem.Click += delegate (object obj, EventArgs args)
            {
                SysTrayHideShow();
            };
            contextMenu.MenuItems.Add(hideShowItem);

            //Context menu item separator
            contextMenu.MenuItems.Add(new MenuItem("-"));

            //Context menu exit item
            MenuItem exitItem = new MenuItem("Exit");
            exitItem.Click += delegate (object obj, EventArgs args)
            {
                Application.Exit();
            };
            contextMenu.MenuItems.Add(exitItem);

            iNotifyIcon.ContextMenu = contextMenu;
            */
        }

        /// <summary>
        /// Access icons from embedded resources.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Icon GetIcon(string name)
        {
            string[] names = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].EndsWith(name))
                {
                    using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(names[i]))
                    {
                        return new Icon(stream);
                    }
                }
            }

            return null;
        }

    }
}
