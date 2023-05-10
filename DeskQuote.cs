using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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






        public DeskQuote(string date, string rushOrder, Desk desk)
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




    }
}
