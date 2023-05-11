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
    public partial class AddQuote : Form
    {
        //private Desk desk = new Desk();
        //private DeskQuote deskQuote = new DeskQuote();

        public AddQuote()
        {
            InitializeComponent();
            surfaceInput.DataSource = Enum.GetValues(typeof(Desk.SurfaceMaterial));
            rushOrderInput.Items.Add("3");
            rushOrderInput.Items.Add("5");
            rushOrderInput.Items.Add("7");

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int width = int.Parse(widthTextBox.Text);
            int depth = int.Parse(depthTextBox.Text);
            int drawers = int.Parse(drawersInput.Text);
            string name = customerName.Text;
            Desk.SurfaceMaterial surfaceMaterial = (Desk.SurfaceMaterial)surfaceInput.SelectedItem;
            //Change to combobox
            string rushOrder = (string)rushOrderInput.SelectedItem;
            string date =  DateTime.Now.ToString();

            //MessageBox.Show(addQuote.Depth.ToString());

            Desk desk = new Desk
            {   Name = name,
                Width = width,
                Depth = depth,
                Drawers = drawers,
                Material = surfaceMaterial
            };

            DeskQuote deskQuote = new DeskQuote(date, rushOrder, drawers, surfaceMaterial, desk);

            float quoteTotal = deskQuote.CalcQuoteTotal();
            MainMenu mainMenu = new MainMenu();
            DisplayQuote displayQuote = new DisplayQuote(deskQuote, quoteTotal, mainMenu, "MM/dd/yyyy");

            displayQuote.Show();
            Hide();


        }



        //TODO: Change way I call Desk class for an instance that calls it. 
        private void deskSizeInput_TextChanged(object sender, EventArgs e)
        {
            
            if (int.TryParse(widthTextBox.Text, out int width))
            {
                if (width < Desk.MINWIDTH || width > Desk.MAXWIDTH)
                {
                    widthTextBox.Text = String.Empty;
                    widthTextBox.Focus();
                    MessageBox.Show("Hello, Width must between 24 and 96 inches");
                }
            }
        }


        private void deskDepthInput_TextChanged(object sender, EventArgs e)
        {
            
            if (int.TryParse(depthTextBox.Text, out int Depth))
            {
                if (Depth < Desk.MINDEPTH || Depth > Desk.MAXDEPTH)
                {
                    depthTextBox.Text = String.Empty;
                    depthTextBox.Focus();
                    MessageBox.Show("Hello, Depth must between 12 and 48 inches");
                }
            }
        }


      


        //Getting the surface materials from Enum
        private void AddQuote_Load(object sender, EventArgs e)
        {
            
        }



        private void deskDrawers_TextChanged(object sender, EventArgs e)
        {
            
            if (int.TryParse(depthTextBox.Text, out int drawers))
            {
                if (drawers < Desk.MINDRAWERS || drawers > Desk.MAXDRAWERS)
                {
                    depthTextBox.Text = String.Empty;
                    depthTextBox.Focus();
                    MessageBox.Show("Hello, Drawers must between 0 and 7 inches");
                }
            }
        }





        private void goback_Click(object sender, EventArgs e)
        {

            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Tag = this;
            mainMenu.Show(this);
        }

       
    }
}


