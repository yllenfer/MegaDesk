using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            Shown += ViewAllQuotes_Shown;
        }


        private void ViewAllQuotes_Shown(object sender, EventArgs e)
        {
            ViewAllQuotes_Load();
        }



        private void ViewAllQuotes_Load()
        {
            try
            {
                string filePath = @"C:\Users\Yllen Fernandez\source\Repos\MegaDesk\quotes.json";
                string json = File.ReadAllText(filePath);
                JArray quotes = JArray.Parse(json);

                displayQuotesBox.Items.Clear();

                foreach (JObject quote in quotes)
                {
                    // Retrieve quote data
                    string quoteDate = quote.SelectToken("Date").ToString();
                    string rushOrder = quote.SelectToken("RushOrder").ToString();
                    int numDrawers = int.Parse(quote.SelectToken("Drawers").ToString());
                    string surfaceMaterial = quote.SelectToken("SurfaceMaterial").ToString();
                    string customerName = quote.SelectToken("Desk.Name").ToString();
                    int width = int.Parse(quote.SelectToken("Desk.Width").ToString());
                    int depth = int.Parse(quote.SelectToken("Desk.Depth").ToString());
                    int basePrice = int.Parse(quote.SelectToken("Desk.Base").ToString());
                    int numDrawersTwo = int.Parse(quote.SelectToken("Desk.Drawers").ToString());
                    string surfMaterial = quote.SelectToken("Desk.Material").ToString();

                    // Calculate the total quote
                    float totalQuote = basePrice + (numDrawers * 50) + int.Parse(surfaceMaterial);

                    string displayString = string.Format("{0} - {1}: {2}\" x {3}\", {4} drawers, ${5:N2}",
                        customerName, quoteDate, width, depth, numDrawers, totalQuote, quote);

                    displayQuotesBox.Items.Add(displayString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading quotes: {ex.Message}\n\n{ex.StackTrace}");
            }
        }

    }
}
