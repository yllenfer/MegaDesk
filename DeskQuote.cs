using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
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
        



        public DeskQuote(int widthValue, int depthValue, int drawersValue) : base(widthValue, depthValue, drawersValue)
        {
            
        }
        
       

        //public int CalArea(int width, int depth)
        //{
            
        //    width = desk.Width;
        //    depth = desk.Depth;


        //    int area = width * depth;
        //    return area;
        //}


        //public double CalPrice(double area, int drawers, Desk.SurfaceMaterial material, int basePrice)
        //{
        //    basePrice = desk.Base;
        //    if (area > 1000)
        //    {
        //        basePrice += 1;

        //        //TODO: I might add a switch statement here


        //    }


        //    switch (material)
        //    {
        //        case SurfaceMaterial.Laminate:
        //            basePrice += (int)SurfaceMaterial.Laminate;
        //            break;
        //        case SurfaceMaterial.Oak:
        //            basePrice += (int)SurfaceMaterial.Oak;
        //            break;
        //        case SurfaceMaterial.Pine:
        //            basePrice += (int)SurfaceMaterial.Pine;
        //            break;
        //        case SurfaceMaterial.Rosewood:
        //            basePrice += (int)SurfaceMaterial.Rosewood;
        //            break;
        //        case SurfaceMaterial.Veneer:
        //            basePrice += (int)SurfaceMaterial.Veneer;
        //            break;
        //    }



        //    return basePrice;
        //}

    }
}
