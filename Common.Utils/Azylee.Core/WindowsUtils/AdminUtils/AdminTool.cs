using Azylee.Core.DataUtils.CollectionUtils;
using Azylee.Core.ProcessUtils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Azylee.Core.WindowsUtils.AdminUtils
{
    /// <summary>
    /// Administrator 工具
    /// </summary>
    public static class AdminTool
    {
        public static bool CheckPassword(string password)
        {
            try
            {
                Process process = ProcessStarter.NewProcess(
                   exe: "cmd.exe",
                   username: "administrator",
                   password: password);
                bool flag = process.Start();
                process.Kill();
                return flag;
            }
            catch { return false; }
        }
    }
}
