using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1OOP.Classes
{
    public class EquilateralTriangle: Triangle
    {
        public EquilateralTriangle(string Pcolour, float s1) : base (Pcolour, s1, s1, s1)
        { }
        public float GetArea()
        {
            return (float)Math.Sqrt(3) / 4 * (Side1L * Side1L);

        }
    }
}
