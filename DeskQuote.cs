using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
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
    internal class DeskQuote : Desk
    {

        private int area;
        public string Date { get; set; }
        public string RushOrder { get; set; }

        //public string Name { get; set; }
        public DateTime date; 
        public Desk Desk { get; set; }

        // Create a two dimensional array for RushOrder Method (Julieta White)
        public static int[,] rushOrderPrices = new int[3, 3];

        public DeskQuote(string date, string rushOrder, int drawers, SurfaceMaterial surfaceMaterial, Desk desk)
        {
            Date = date.ToString();
            RushOrder = rushOrder;
            Desk  = desk;


            
        }

        public float CalArea()
        {
            float area = Desk.Width * Desk.Depth;
            return area;

        }




        private void CalcRushCost(string type)
        {
            double value = 0;
            float surfaceArea = CalArea();
            if (surfaceArea < 1000)
            {
                switch (type)
                {
                    case "3":
                        value = 60;
                        break;
                    case "5":
                        value = 40;
                        break;
                    case "7":
                        value = 30;
                        break;
                }
            }
            else if (surfaceArea < 2000)
            {
                switch (type)
                {
                    case "3":
                        value = 70;
                        break;
                    case "5":
                        value = 50;
                        break;
                    case "7":
                        value = 35;
                        break;
                }
            }
            else
            {
                switch (type)
                {
                    case "3":
                        value = 80;
                        break;
                    case "5":
                        value = 60;
                        break;
                    case "7":
                        value = 40;
                        break;
                }
            }
            //toString = value.ToString; 
            RushOrder = value.ToString();
        }


        public float CalQuoteTotal()
        {
            //TODO:  this a placeholder, change this
            float quoteTotal = 1 * 1;
            return quoteTotal;
        }


        // Method GetRushOrder. This method will handle the population of a member
        // variable that hold the dimensional array. (Julieta White)

        /* two dimensional array
         *      $60     $70     $80
         *      $40     $50     $60
         *      $30     $35     $40
         */



        public static int[,] GetRushOrder()
        {
            int[,] rushOrderPrices = new int[3, 3];
            string[] priceList = new string[9];
            priceList = ReadRushOrder();
            int count = 0;
            
            while (count < priceList.Length)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j< 3; j++)
                    {
                        rushOrderPrices[i, j] = int.Parse(priceList[count]);
                        count ++;

                    }
                }
            }
            return rushOrderPrices;
        }
        
        public static string[] ReadRushOrder()
        {
            string[] priceList = new string[9];
            try
            {
                string filePath = @"C:\Users\Ian\Desktop\MegaDesk_Group\Resources\rushOrderPrices.txt";
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
                MessageBox.Show("Something went wrong." + e.Message);
                Application.Exit();
            }
            return priceList;
        }
    }

}
