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
     class DeskQuote
    {

        private int area;
        public string Date { get; set; }
        public string RushOrder { get; set; }
        public int Drawers { get; set; }
        public SurfaceMaterial SurfaceMaterial { get; set; }
        public Desk Desk { get; set; }

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
            float basePrice = 200.0f;
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
            float rushOrderCost = 0.0f;
            if (!string.IsNullOrEmpty(RushOrder))
            {
                switch (RushOrder)
                {
                    case "3":
                        if (area < 1000)
                        {
                            rushOrderCost = 60.0f;
                        }
                        else if (area >= 1000 && area <= 2000)
                        {
                            rushOrderCost = 70.0f;
                        }
                        else if (area > 2000)
                        {
                            rushOrderCost = 80.0f;
                        }
                        break;
                    case "5":
                        if (area < 1000)
                        {
                            rushOrderCost = 40.0f;
                        }
                        else if (area >= 1000 && area <= 2000)
                        {
                            rushOrderCost = 50.0f;
                        }
                        else if (area > 2000)
                        {
                            rushOrderCost = 60.0f;
                        }
                        break;
                    case "7":
                        if (area < 1000)
                        {
                            rushOrderCost = 30.0f;
                        }
                        else if (area >= 1000 && area <= 2000)
                        {
                            rushOrderCost = 35.0f;
                        }
                        else if (area > 2000)
                        {
                            rushOrderCost = 40.0f;
                        }
                        break;
                    case "14":
                        rushOrderCost = 0;
                        break;

                }
            }

            // Calculate the total cost
            float quoteTotal = basePrice + areaCost + drawersCost + surfaceMaterialCost + rushOrderCost;
            return quoteTotal;
        }
    }

    //TODO: Create GetOrder method


}
