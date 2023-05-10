using MegaDesk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
     class Desk

    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Base { get; set; }
        public int Drawers { get; set; }

        public SurfaceMaterial Material { get; set; }

        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;



        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;

        public const int BASE = 200;


        public enum SurfaceMaterial
        {
           
            Laminate = 100,
            Oak = 200,
            Pine = 50,
            Rosewood = 300,
            Veneer = 125
        }


        //protected Desk(int widthValue, int depthValue, int drawersValue) {
        
        //    Width = widthValue;
        //    Depth = depthValue;
        //    Drawers = drawersValue;
        
        //}

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());

        }
    }
}



