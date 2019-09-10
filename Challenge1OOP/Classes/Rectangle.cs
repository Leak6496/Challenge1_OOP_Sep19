using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1OOP.Classes
{
    public class Rectangle: Quadrilateral
    {
        public Rectangle(string pColour, int Lenght, int Width) : base(pColour, Lenght, Width, Lenght, Width)
        {
            if (Lenght < 1 || Width<1)
               throw new LessthanoneException("Less Than 1 rectangle side not allowed!");
        }

        public int GetArea()
        {
            return Side1Length * Side2Length;

        }
    }
}
