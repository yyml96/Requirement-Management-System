using _3.Model;
using _3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3.Presenter;
using _3.Repo_Database;



namespace _3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IMainView view = new MainView();
            
            new MainPresenter(view);
            Application.Run((Form)view);
        }
    }
}
