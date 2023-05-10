using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        internal DisplayQuote(DeskQuote deskQuote, float quoteTotal, MainMenu mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            this.deskQuote = deskQuote;
            this.quoteTotal = quoteTotal;

            string quoteDate = "Does this work?";

            outputlable.Text = quoteDate;


        }
    }
}
