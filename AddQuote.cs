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
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int width = int.Parse(widthTextBox.Text);
            int depth = int.Parse(depthTextBox.Text);
            int drawers = int.Parse(drawersInput.Text);
            DeskQuote addQuote = new DeskQuote(width, depth, drawers);
            MessageBox.Show(addQuote.Depth.ToString());





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
            surfaceInput.Items.Clear(); 
            string[] materials = Enum.GetNames(typeof(Desk.SurfaceMaterial));
            surfaceInput.Items.AddRange(materials);
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


