using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1OOP.Classes
{
    public class Triangle : Shape
    {
        public float Side1L { get; set; }
        public float Side2L { get; set; }
        public float Side3L { get; set; }

        public Triangle(string Pcolour, float s1, float s2, float s3) : base(Pcolour)
        {
            if (s1 < 1 || s2 <1  || s3 <1 )
                throw new LessthanoneException("your triangle side less than one not allowed");

            Side1L = s1;
            Side2L = s2;
            Side3L = s3;
            
        }
        public float GetPerimeter()
        {
            return Side1L + Side2L + Side3L;
        }
    }

    }
