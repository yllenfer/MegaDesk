using Newtonsoft.Json;
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
    public partial class SearchQuotes : Form
    {
        private DeskQuote deskQuote;

        public SearchQuotes()
        {

            InitializeComponent();
            searchBox.DataSource = Enum.GetValues(typeof(Desk.SurfaceMaterial));


        }


        internal SearchQuotes(DeskQuote deskQuote, float quoteTotal, MainMenu mainMenu, string v)
        {
            InitializeComponent();
            searchBox.DataSource = Enum.GetValues(typeof(Desk.SurfaceMaterial));
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(@"C:\Users\Yllen Fernandez\source\Repos\MegaDesk", "quotes.json");

                // Read all the quotes from the file
                string json = File.ReadAllText(filePath);
                JArray quotes = JArray.Parse(json);

                // Get the selected surface material from the ComboBox
                Desk.SurfaceMaterial selectedMaterial = (Desk.SurfaceMaterial)searchBox.SelectedItem;
                string selectedSurfaceMaterial = selectedMaterial.ToString();

                // Filter the quotes based on the selected surface material
                List<JObject> filteredQuotes = new List<JObject>();
                foreach (JObject quote in quotes)
                {
                    string material = quote.SelectToken("Desk.Material").ToString();
                    if (material == selectedSurfaceMaterial)
                    {
                        filteredQuotes.Add(quote);
                    }
                }

                // Display the filtered quotes in the ListBox
                deskQuotesListBox.Items.Clear();
                foreach (JObject quote in filteredQuotes)
                {
                    string customerName = quote.SelectToken("Desk.Name").ToString();
                    string quoteDate = quote.SelectToken("Date").ToString();
                    int width = int.Parse(quote.SelectToken("Desk.Width").ToString());
                    int depth = int.Parse(quote.SelectToken("Desk.Depth").ToString());
                    string surfaceMaterial = quote.SelectToken("Desk.Material").ToString();
                    int numDrawers = int.Parse(quote.SelectToken("Desk.Drawers").ToString());
                    decimal deskPrice = decimal.Parse(quote.SelectToken("DeskQuote.Desk.Price").ToString());
                    float totalPrice = float.Parse(quote.SelectToken("QuoteTotal").ToString());

                    deskQuotesListBox.Items.Add(string.Format("{0} - {1}: {2}\" x {3}\", {4} drawers, ${5:N2} (Total: ${6:N2})",
                        customerName, quoteDate, width, depth, numDrawers, deskPrice, totalPrice));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for quotes: {ex.Message}");
            }
        }




    }



}

