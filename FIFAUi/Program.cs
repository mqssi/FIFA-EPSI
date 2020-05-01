using FIFALib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFAUi
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialiser bdd

            GlobalConfig.InitializeConnections(DatabaseType.Sql);
             Application.Run(new Creation());
            //Application.Run(new Accueil());
        }
    }
}
