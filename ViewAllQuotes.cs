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
            this.FormClosing += ViewAllQuotes_Load;
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
                    string customerName = quote.SelectToken("Desk.Name").ToString();
                    string quoteDate = quote.SelectToken("Date").ToString();
                    int width = int.Parse(quote.SelectToken("Desk.Width").ToString());
                    int depth = int.Parse(quote.SelectToken("Desk.Depth").ToString());
                    int numDrawers = int.Parse(quote.SelectToken("Drawers").ToString());
                    string surfaceMaterialValue = quote.SelectToken("Desk.Material").ToString();

                    Desk.SurfaceMaterial surfaceMaterial = (Desk.SurfaceMaterial)Enum.Parse(typeof(Desk.SurfaceMaterial), surfaceMaterialValue);

                    string surfaceMaterialName = surfaceMaterial.ToString();

                    string displayString = string.Format("{0} - {1}: {2}\" x {3}\", {4} drawers, Material: {5}",
                        customerName, quoteDate, width, depth, numDrawers, surfaceMaterialName);

                    displayQuotesBox.Items.Add(displayString);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading quotes: {ex.Message}\n\n{ex.StackTrace}");
            }
        }

        

        private void ViewAllQuotes_Load(object sender, FormClosingEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            e.Cancel = true;
            this.Hide();
        }
    }
}
