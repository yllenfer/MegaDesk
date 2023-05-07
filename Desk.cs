using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
     class Desk

    {

        public int Width { get; set; }

        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;

        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;



        public enum SurfaceMaterial
        {
            Laminete,
            Oak,
            Pine,
            Rosewood,
            Veneer
        }


        


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
