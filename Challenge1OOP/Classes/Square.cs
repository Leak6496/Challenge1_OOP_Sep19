using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1OOP.Classes
{
    public class Square : Quadrilateral
    {

        public Square(string pColour, int sideL) : base(pColour, sideL, sideL, sideL, sideL)
        {
            if (sideL < 1)
                throw new LessthanoneException("Less Than 1 square side not allowed!");
        }
        public int GetArea()
        {
            return (Side1Length*Side1Length);
        }
    }
}
