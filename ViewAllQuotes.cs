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

using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
        
    {
        private DataGridView dataGridView;
        public ViewAllQuotes()
        {
            InitializeComponent();
            Shown += ViewAllQuotes_Shown;
            this.FormClosing += ViewAllQuotes_FormClosing;
            dataGridView = new DataGridView(); // Add this line
            Controls.Add(dataGridView); // Add this line
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

                DataTable dataTable = new DataTable();

                // Add columns to the DataTable
                dataTable.Columns.Add("Customer Name");
                dataTable.Columns.Add("Quote Date");
                dataTable.Columns.Add("Width");
                dataTable.Columns.Add("Depth");
                dataTable.Columns.Add("Num Drawers");
                dataTable.Columns.Add("Surface Material");

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

                    // Add a new row to the DataTable
                    dataTable.Rows.Add(customerName, quoteDate, width, depth, numDrawers, surfaceMaterialName);
                }

                // Set the DataGridView's DataSource to the DataTable
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading quotes: {ex.Message}\n\n{ex.StackTrace}");
            }
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
