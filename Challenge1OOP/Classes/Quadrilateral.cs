using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1OOP.Classes
{
    public class Quadrilateral: Shape
    {
        public int Side1Length { get; set; }
        public int Side2Length { get; set; }
        public int Side3Length { get; set; }
        public int Side4Length { get; set; }

        public Quadrilateral(string pColour, int s1, int s2, int s3, int s4) : base(pColour)
        {
        //    if (s1 < 1 || s2 < 1 || s3 < 1 || s4 < 1)
          //      throw new LessthanoneException("Less Than 1");


            Side1Length = s1;
            Side2Length = s2;
            Side3Length = s3;
            Side4Length = s4;

        }
        public int GetPerimeter()
        {
            return Side1Length + Side2Length + Side3Length + Side4Length;
        }

    }
}
