using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {

        private MainMenu _mainMenu;
        private DeskQuote deskQuote;
        private float quoteTotal;
        private MainMenu mainMenu;
        private string rushOrder;

        internal DisplayQuote(DeskQuote deskQuote, float quoteTotal, MainMenu mainMenu, string v, string rushOrder)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            this.deskQuote = deskQuote;
            this.quoteTotal = quoteTotal;
            this.rushOrder  = rushOrder;

            string quoteDate = "Desktop Material " + deskQuote.Desk.Material +
                "\nRush Order: " + deskQuote.RushOrder +
                "\nRush Order: " + deskQuote.RushOrder + 
                "\nName: " + deskQuote.Desk.Name + 
            "\nDate: " + deskQuote.Date;

            ;

            outputlable.Text = quoteDate;


        }
    }
}
