using Azylee.Core.AppUtils;
using Azylee.Core.LogUtils.SimpleLogUtils;
using Oreo.FileMan.Commons;
using Oreo.FileMan.Views;
using System;
using System.Windows.Forms;

namespace Oreo.FileMan
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            R.Log = new Log();
            Log.AllocConsole();

            R.Services.FBS.Start();

            R.Log.i("App is Runing...");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
