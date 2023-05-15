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
            searchBox.SelectedIndexChanged += searchBox_SelectedIndexChanged;
            this.FormClosing += SearchQuote_FormClosing;



        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"C:\Users\Yllen Fernandez\source\Repos\MegaDesk\quotes.json";
                string json = File.ReadAllText(filePath);
                JArray quotes = JArray.Parse(json);

                deskQuotesListBox.Items.Clear();

                // Retrieve the selected surface material from the searchBox dropdown
                Desk.SurfaceMaterial selectedMaterial = (Desk.SurfaceMaterial)searchBox.SelectedItem;

                foreach (JObject quote in quotes)
                {
                    // Retrieve quote data
                    string quoteDate = quote.SelectToken("Date").ToString();
                    string rushOrder = quote.SelectToken("RushOrder").ToString();
                    int numDrawers = int.Parse(quote.SelectToken("Drawers").ToString());
                    string customerName = quote.SelectToken("Desk.Name").ToString();
                    int width = int.Parse(quote.SelectToken("Desk.Width").ToString());
                    int depth = int.Parse(quote.SelectToken("Desk.Depth").ToString());
                    int basePrice = int.Parse(quote.SelectToken("Desk.Base").ToString());
                    int numDrawersTwo = int.Parse(quote.SelectToken("Desk.Drawers").ToString());
                    int surfaceMaterialValue = int.Parse(quote.SelectToken("SurfaceMaterial").ToString());
                    //Add base Price
                    //int babse - int.Parse(quote.)
                    Desk.SurfaceMaterial surfaceMaterial = (Desk.SurfaceMaterial)surfaceMaterialValue;

                    
                    if (surfaceMaterial == selectedMaterial)
                    {
                     
                        string surfaceMaterialString = surfaceMaterial.ToString();

                       
                        string displayString = string.Format("{0} - {1}: {2}\" x {3}\", {4} drawers, ${5:N2}, Material: {6}",
                                                customerName, quoteDate, width, depth, numDrawers, basePrice + (numDrawers * 50) + (int)surfaceMaterial, surfaceMaterialString);
                        deskQuotesListBox.Items.Add(displayString);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading quotes: {ex.Message}\n\n{ex.StackTrace}");
            }
        }


        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Desk.SurfaceMaterial selectedMaterial = (Desk.SurfaceMaterial)searchBox.SelectedItem;
            string selectedMaterialString = selectedMaterial.ToString();
            deskQuotesListBox.Text = "Selected Material: " + selectedMaterialString;
        }



        private void SearchQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }



    }

}





