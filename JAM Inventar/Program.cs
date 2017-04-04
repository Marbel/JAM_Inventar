using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Cfg;
using JAM_Inventar.Core;

namespace JAM_Inventar
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Get Language of Registry, get Default if non existent
            Helper.StrCulture = Helper.GetStringRegistryValue("Language", Helper.StrCulture);
            // Set actual Language key
            Helper.SetStringRegistryValue("Language", Helper.StrCulture);
            // Set Culture for Application
            Helper.SetCulture();
            
            // Initialize NHibernate
            Start.Cfg = new Configuration();
            Start.Cfg.Configure();
            Start.Cfg.AddAssembly(typeof(Domain.Product).Assembly);


            // Get ourselves an NHibernate Session
            var sessions = Start.Cfg.BuildSessionFactory();
            Start.Sess = sessions.OpenSession();

            // Create the database schema
            new SchemaUpdate(Start.Cfg).Execute(true, true);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());

            


        }
    }
}
