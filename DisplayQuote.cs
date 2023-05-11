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
       

        internal DisplayQuote(DeskQuote deskQuote, float quoteTotal, MainMenu mainMenu, string v)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            this.deskQuote = deskQuote;
            this.quoteTotal = quoteTotal;


            string quoteDate =
                "\nName: " + deskQuote.Desk.Name +
                "\nDesktop Material:  " + deskQuote.Desk.Material +
                "\nRush Order: " + deskQuote.RushOrder +
                "\nTotal: $" + deskQuote.CalcQuoteTotal() +  
                "\nDate: " + deskQuote.Date;

            

            outputlable.Text = quoteDate;


        }
    }
}
