using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFUI
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Author
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public DateTime DOB { get; set; }
            public string BookTitle { get; set; }
            public bool IsMVP { get; set; }
        }

        #region DataGrid 
        List<Author> authors = new List<Author>();
        private List<Author> LoadCollectionData()
        {

            authors.Add(new Author()
            {
                ID = 101,
                Name = "Mahesh Chand",
                BookTitle = "Graphics Programming with GDI+",
                DOB = new DateTime(1975, 2, 23),
                IsMVP = false
            });

            authors.Add(new Author()
            {
                ID = 201,
                Name = "Mike Gold",
                BookTitle = "Programming C#",
                DOB = new DateTime(1982, 4, 12),
                IsMVP = true
            });

            authors.Add(new Author()
            {
                ID = 244,
                Name = "Mathew Cochran",
                BookTitle = "LINQ in Vista",
                DOB = new DateTime(1985, 9, 11),
                IsMVP = true
            });

            return authors;
        }
        #endregion

        #region Localization
        private void LoadLanguage(int index)
        {
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri("pack://SiteOfOrigin:,,,/Lang/en-US.xaml", UriKind.Absolute);
            Application.Current.Resources.MergedDictionaries[index] = dict;
        }
        #endregion

        #region NotifyIcon
        private System.Windows.Forms.NotifyIcon notifyIcon = null;
        System.Windows.Forms.ContextMenu nIconMenu = new System.Windows.Forms.ContextMenu();
        System.Windows.Forms.MenuItem nIconMenuItem1 = new System.Windows.Forms.MenuItem();
        System.Windows.Forms.MenuItem nIconMenuItem2 = new System.Windows.Forms.MenuItem();
        private void InitialTray()
        {
            notifyIcon = new System.Windows.Forms.NotifyIcon();
            notifyIcon.Icon = new System.Drawing.Icon(@"Icon/Tool.ico");
            notifyIcon.Text = "WPFUI";
            notifyIcon.Visible = true;
            notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(notifyIcon_MouseClick);
            this.StateChanged += new EventHandler(WPFUI_StateChanged);
            //小圖示選單
            nIconMenuItem1.Index = 0;
            nIconMenuItem1.Text = "結束1";
            nIconMenuItem1.Click += new System.EventHandler(nIconMenuItem1_Click);
            nIconMenu.MenuItems.Add(nIconMenuItem1);
            notifyIcon.ContextMenu = nIconMenu;
            nIconMenuItem2.Index = 0;
            nIconMenuItem2.Text = "結束2";
            nIconMenuItem2.Click += new System.EventHandler(nIconMenuItem1_Click);
            nIconMenu.MenuItems.Add(nIconMenuItem2);
            notifyIcon.ContextMenu = nIconMenu;
        }
        private void notifyIcon_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //如果鼠标左键单击
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.Visibility == Visibility.Visible)
                {
                    this.Visibility = Visibility.Hidden;
                }
                else
                {
                    this.Show();
                    this.WindowState = (WindowState)System.Windows.Forms.FormWindowState.Normal;
                }

            }
        }
        private void WPFUI_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Minimized)
            {
                this.Visibility = Visibility.Hidden;
            }
        }

        private void nIconMenuItem1_Click(object sender, System.EventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = LoadCollectionData();
            InitialTray();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadLanguage(9);
        }


    }
}
