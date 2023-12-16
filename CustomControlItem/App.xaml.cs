using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Reflection;

namespace WPFUI
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        System.Threading.Mutex mutex;

        public App()
        {
            this.Startup += new StartupEventHandler(App_Startup);
        }

        void App_Startup(object sender, StartupEventArgs e)
        {
            bool ret;
            string projectName = Assembly.GetEntryAssembly()?.GetName().Name;
            //Console.WriteLine(projectName);
            mutex = new System.Threading.Mutex(true, projectName, out ret);

            if (!ret)
            {
                MessageBox.Show("已有一個程式例項執行");
                Environment.Exit(0);
            }

        }
    }
}
