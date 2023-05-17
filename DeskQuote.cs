using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static MegaDesk.Desk;

namespace MegaDesk
{
     class DeskQuote
    {

        private int area;
        public string Date { get; set; }
        public string RushOrder { get; set; }
        public int Drawers { get; set; }
        public SurfaceMaterial SurfaceMaterial { get; set; }
        public Desk Desk { get; set; }

        // RushOrder method declaration (Julieta White)
        public static int[,] rushOrderPrices = new int[3, 3];

        public DeskQuote(string date, string rushOrder, int drawers, SurfaceMaterial surfaceMaterial, Desk desk)
        {
            Date = date.ToString();
            RushOrder = rushOrder;
            Drawers = drawers;
            SurfaceMaterial = surfaceMaterial;
            Desk = desk;
        }

        public float CalArea()
        {
            float area = Desk.Width * Desk.Depth;
            return area;
        }

        public float CalcQuoteTotal()
        {
            //float basePrice = 200.0f;
            float areaCost = 0.0f;
            float drawersCost = Drawers * 50.0f;
            float surfaceMaterialCost = 0.0f;

            // Calculate the area cost
            float area = CalArea();
            if (area > 1000)
            {
                areaCost = (area - 1000) * 1.0f;
            }

            // Calculate the surface material cost
            switch (SurfaceMaterial)
            {
                case SurfaceMaterial.Oak:
                    surfaceMaterialCost = 200.0f;
                    break;
                case SurfaceMaterial.Laminate:
                    surfaceMaterialCost = 100.0f;
                    break;
                case SurfaceMaterial.Pine:
                    surfaceMaterialCost = 50.0f;
                    break;
                case SurfaceMaterial.Rosewood:
                    surfaceMaterialCost = 300.0f;
                    break;
                case SurfaceMaterial.Veneer:
                    surfaceMaterialCost = 125.0f;
                    break;
            }

            // Calculate the rush order cost
            //float rushOrderCost = 0.0f;
            rushOrderPrices = GetRushOrderPrices(); // (Julieta White)
            int rushOrderCost = 0;  // (julieta White)
            if (!string.IsNullOrEmpty(RushOrder))
            {
                switch (RushOrder)
                {
                    case "3":
                        if (area < 1000)
                        {
                            rushOrderCost = rushOrderPrices[0, 0]; //60.0f;
                        }
                        else if (area >= 1000 && area <= 2000)
                        {
                            rushOrderCost = rushOrderPrices[0, 1]; //70.0f;
                        }
                        else if (area > 2000)
                        {
                            rushOrderCost = rushOrderPrices[0, 2]; //80.0f;
                        }
                        break;
                    case "5":
                        if (area < 1000)
                        {
                            rushOrderCost = rushOrderPrices[1, 0]; //40.0f;
                        }
                        else if (area >= 1000 && area <= 2000)
                        {
                            rushOrderCost = rushOrderPrices[1, 1]; //50.0f;
                        }
                        else if (area > 2000)
                        {
                            rushOrderCost = rushOrderPrices[1, 2]; //60.0f;
                        }
                        break;
                    case "7":
                        if (area < 1000)
                        {
                            rushOrderCost = rushOrderPrices[2, 0]; //30.0f;
                        }
                        else if (area >= 1000 && area <= 2000)
                        {
                            rushOrderCost = rushOrderPrices[2, 1]; //35.0f;
                        }
                        else if (area > 2000)
                        {
                            rushOrderCost = rushOrderPrices[2, 2]; //40.0f;
                        }
                        break;
                    case "14":
                        rushOrderCost = 0;
                        break;

                }
            }

            // Calculate the total cost
            float quoteTotal = Desk.BASE + areaCost + drawersCost + surfaceMaterialCost + rushOrderCost;
            return quoteTotal;
        }

        // Read in the rush order price list from the file.
        // "rushOrderPrices.txt".
        public static string[] ReadRushOrderPrices()
        {
            string[] priceList = new string[9];
            try
            {
                string filePath = "rushOrderPrices.txt";
                StreamReader reader = new StreamReader(filePath);
                int i = 0;
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    priceList[i] = line;
                    i++;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong. " + e);
                Application.Exit();
            }
            return priceList;  //return list of prices
        }

        /* Method GetRushOrder() will handle the population of a member
         * variable that hold a two dimensional array (Julieta White).
         * 
         * two dimensional array
         *      $60     $70     $80
         *      $40     $50     $60
         *      $30     $35     $40
         */     
        public static int[,] GetRushOrderPrices()
        {
            int[,] rushOrderPrices = new int[3,3];
            string[] priceList = new string[9];
            priceList = ReadRushOrderPrices();

            // Creating the 2dimensional array.
            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rushOrderPrices[i, j] = int.Parse(priceList[index]);
                    index++;
                }
            }
            return rushOrderPrices;
        }
    }
    
}
