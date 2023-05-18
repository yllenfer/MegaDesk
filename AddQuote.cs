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
using Newtonsoft.Json;
using System.IO;
using System.Collections;


namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        

        public AddQuote()
        {
            InitializeComponent();
            surfaceInput.DataSource = Enum.GetValues(typeof(Desk.SurfaceMaterial));
            rushOrderInput.Items.Add("3");
            rushOrderInput.Items.Add("5");
            rushOrderInput.Items.Add("7");
            rushOrderInput.Items.Add("14");
            this.FormClosing += AddQuote_FormClosing;





        }

        private void submitButton_Click(object sender, EventArgs e)


        {
            if (string.IsNullOrWhiteSpace(widthTextBox.Text) ||
                string.IsNullOrWhiteSpace(depthTextBox.Text) ||
                string.IsNullOrWhiteSpace(drawersInput.Text) ||
                string.IsNullOrWhiteSpace(customerName.Text) ||
                surfaceInput.SelectedItem == null ||
                rushOrderInput.SelectedItem == null)
            {
                warningLabel.Text = "Please fill in all the required fields.";
                warningLabel.Visible = true;
                return; 
            }


            

            warningLabel.Visible = false;



            int width = int.Parse(widthTextBox.Text);
            int depth = int.Parse(depthTextBox.Text);
            int drawers = int.Parse(drawersInput.Text);
            string name = customerName.Text;
            Desk.SurfaceMaterial surfaceMaterial = (Desk.SurfaceMaterial)surfaceInput.SelectedItem;
        
            string rushOrder = (string)rushOrderInput.SelectedItem;
            string date = DateTime.Now.ToString("MMMM/dd/yyyy");

            

            Desk desk = new Desk
            {
                Name = name,
                Width = width,
                Depth = depth,
                Drawers = drawers,
                Material = surfaceMaterial
            };

            DeskQuote deskQuote = new DeskQuote(date, rushOrder, drawers, surfaceMaterial, desk);

            float quoteTotal = deskQuote.CalcQuoteTotal();



            DeskQuoteInfo deskQuoteInfo = new DeskQuoteInfo
            {
                Desk = desk,
                DeskQuote = deskQuote,
                QuoteTotal = quoteTotal,
                Date = date,
                RushOrderDays = rushOrder
            };

            try
            {
                string filePath = @"C:\Users\Yllen Fernandez\source\Repos\MegaDesk\quotes.json";

                
                string fileJsonData = System.IO.File.ReadAllText(filePath);

                
                var quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(fileJsonData) ?? new List<DeskQuote>();

                
                quotes.Add(deskQuote);

               
                string json = JsonConvert.SerializeObject(quotes);

              
                System.IO.File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the quote: {ex.Message}");
            }




            MainMenu mainMenu = new MainMenu();
            DisplayQuote displayQuote = new DisplayQuote(deskQuote, quoteTotal, mainMenu, "MM/dd/yyyy");

            displayQuote.Show();
            Hide();


        }





        private void drawersInput_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidDrawers(drawersInput.Text, out string errorMsg))
            {
                e.Cancel = true;
                drawersInput.Select(0, drawersInput.Text.Length);

             
                warningLabel.Text = errorMsg;
                warningLabel.Visible = true;
            }
        }

        private void drawersInput_Validated(object sender, EventArgs e)
        {
           
            warningLabel.Visible = false;
        }

        private bool ValidDrawers(string drawers, out string errorMsg)
        {
            if (drawers.Length == 0)
            {
                errorMsg = "Drawers is required.";
                return false;
            }

            if (Convert.ToInt32(drawers) >= Desk.MINDRAWERS && Convert.ToInt32(drawers) <= Desk.MAXDRAWERS)
            {
                errorMsg = "";
                return true;
            }

            errorMsg = "Drawers must be between " + Desk.MINDRAWERS + " and " + Desk.MAXDRAWERS + ".";
            return false;
        }





        private void depthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidDepth(depthTextBox.Text, out string errorMsg))
            {
                e.Cancel = true;
                depthTextBox.Select(0, depthTextBox.Text.Length);

              
                warningLabel.Text = errorMsg;
                warningLabel.Visible = true;
            }
        }

        private void depthTextBox_Validated(object sender, EventArgs e)
        {
           
            warningLabel.Visible = false;
        }

        private bool ValidDepth(string depth, out string errorMsg)
        {
            if (depth.Length == 0)
            {
                errorMsg = "Depth is required.";
                return false;
            }

            if (Convert.ToInt32(depth) >= Desk.MINDEPTH && Convert.ToInt32(depth) <= Desk.MAXDEPTH)
            {
                errorMsg = "";
                return true;
            }

            errorMsg = "Depth must be between " + Desk.MINDEPTH + " in and " + Desk.MAXDEPTH + " in.";
            return false;
        }





        
        private void AddQuote_Load(object sender, EventArgs e)
        {
            
        }



      



       



        private void widthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidWidth(widthTextBox.Text, out string errorMsg))
            {
                e.Cancel = true;
                widthTextBox.Select(0, widthTextBox.Text.Length);

           
                warningLabel.Text = errorMsg;
                warningLabel.Visible = true;
            }
        }

        private void widthTextBox_Validated(object sender, EventArgs e)
        {
            
            warningLabel.Visible = false;
        }

        private bool ValidWidth(string width, out string errorMsg)
        {
            if (width.Length == 0)
            {
                errorMsg = "Width is required.";
                return false;
            }

            if (Convert.ToInt32(width) >= Desk.MINWIDTH && Convert.ToInt32(width) <= Desk.MAXWIDTH)
            {
                errorMsg = "";
                return true;
            }

            errorMsg = "Width must be between " + Desk.MINWIDTH + " in and " + Desk.MAXWIDTH + " in.";
            return false;
        }

        private void rushOrderInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rushOrderInput.SelectedIndex == -1) 
            {
                warningLabel.Text = "Please select a rush material.";
                warningLabel.Visible = true;
            }
            else
            {
                warningLabel.Visible = false;
            }
        }

        private void customerName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(customerName.Text) && int.TryParse(customerName.Text, out _))
            {
                warningLabel.Text = "Invalid customer name. Please enter a valid name.";
                warningLabel.Visible = true;
            }
            else
            {
                warningLabel.Visible = false;
            }
        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            e.Cancel = true; 
            this.Hide(); 
        }




    }


    class DeskQuoteInfo
    {
        public Desk Desk { get; set; }
        public DeskQuote DeskQuote { get; set; }
        public float QuoteTotal { get; set; }
        public string Date { get; set; }
        public string RushOrderDays { get; set; }


    }




    }


