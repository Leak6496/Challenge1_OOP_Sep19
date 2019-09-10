using System;
using NUnit.Framework;
using Challenge1OOP;
using Challenge1OOP.Classes;
// remember to reference and import your shape library

namespace Triangle_Tests {
    [TestFixture]
    public class Tests {
        RightAngleTriangle Ra1 { get; set; }
        EquilateralTriangle Eq1 { get; set; }
        
        RightAngleTriangle Ra2 { get; set; }
        EquilateralTriangle Eq2 { get; set; }


        [SetUp]
        public void Init() {
            Ra1 = new RightAngleTriangle("White", 3, 4);
            Eq1 = new EquilateralTriangle("black", 6);
            
            Ra2 = new RightAngleTriangle("White", 7, 4);
            Eq2 = new EquilateralTriangle("black", 8);
        }
        
 
        
        [Test]
        public void RightAngleTriangleTests() {
            float area = 6;
            float perimeter = 12;
            
            Assert.AreEqual(Math.Round(area,2), Math.Round(Ra1.GetArea(),2));
            Assert.AreEqual(Math.Round(perimeter,2), Math.Round(Ra1.GetPerimeter(), 2));
            area = 14;
            perimeter = 19.06f;
            
            Assert.AreEqual(Math.Round(area,2), Math.Round(Ra2.GetArea(),2));
            Assert.AreEqual(Math.Round(perimeter,2), Math.Round(Ra2.GetPerimeter(), 2));

        }
        
        [Test]
        public void EquilateralTriangleTests() {
            float area = 15.59f;
            float perimeter = 18;
            
            Assert.AreEqual(Math.Round(area,2), Math.Round(Eq1.GetArea(),2));
            Assert.AreEqual(Math.Round(perimeter,2), Math.Round(Eq1.GetPerimeter(), 2));
            
            area = 27.71f;
            perimeter = 24;
            
            Assert.AreEqual(Math.Round(area,2), Math.Round(Eq2.GetArea(),2));
            Assert.AreEqual(Math.Round(perimeter,2), Math.Round(Eq2.GetPerimeter(), 2));
        }
    }
}