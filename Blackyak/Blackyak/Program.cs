using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace Blackyak
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // UI thread 예외처리
            Application.ThreadException += Application_ThreadException;
            // 모든 예외처리
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            // non-UI thread 예외처리
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.Run(new Form1());
        }

        public static bool IsAdministrator()
        {
            var windowsIdentity = WindowsIdentity.GetCurrent();

            if (windowsIdentity != null)
            {
                var windowsPrincipal = new WindowsPrincipal(windowsIdentity);
                return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
            }

            return false;
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //logger.Error(e.ExceptionObject);
            //App.ShowAlert(text: LocalizedStrings.Alert_System_Exception, caption: LocalizedStrings.Error, level: App.AlertLevel.Error);
        }

        /// <summary>
        /// UI thread 예외처리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //logger.Error(e.Exception);
            //App.ShowAlert(text: LocalizedStrings.Alert_System_Exception, caption: LocalizedStrings.Error, level: App.AlertLevel.Error);
        }

    }
}
