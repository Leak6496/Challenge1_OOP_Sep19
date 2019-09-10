using System;
using NUnit.Framework;
using Challenge1OOP;
using Challenge1OOP.Classes;
// remember to reference and import your shape library

namespace Quadrilateral_Tests {
    [TestFixture]
    public class Tests {
        Square Sq1 { get; set; }
        Rectangle Rec1 { get; set; }
       
        Square Sq2 { get; set; }
        Rectangle Rec2 { get; set; }

     
        Square Squ { get; set; }
        Rectangle Recg { get; set; } 
        [SetUp]
        public void Init() {
            Sq1 = new Square("Blue", 4);
            Rec1 = new Rectangle("Red", 4, 3);
            
            Sq2 = new Square("Blue", 6);
            Rec2 = new Rectangle("Red", 5, 4);
        }
        
        [Test]
        public void SquareTests() {
            int area = 16;
            int perimeter = 16;
            
            Assert.AreEqual(area, Sq1.GetArea());
            Assert.AreEqual(perimeter, Sq1.GetPerimeter());
            
            area = 36;
            perimeter = 24;
            
            Assert.AreEqual(area, Sq2.GetArea());
            Assert.AreEqual(perimeter, Sq2.GetPerimeter());

        }

        [Test]
        [TestCase(5,20)]
        [TestCase(15, 60)]
        [TestCase(7, 28)]
        public void Square_GetPerimeter_ValidInput_ReturnIsCorrect(int s, int ans)
        {
           
           Squ = new Square("Blue", s);
           var output = Squ.GetPerimeter();
            Assert.AreEqual(ans, output);

        }

        [Test]
        [TestCase(5, 25)]
        [TestCase(15, 225)]
        [TestCase(7, 49)]
        public void Square_GetArea_ValidInput_ReturnIsCorrect(int s, int ans)
        {
            Squ = new Square("Blue", s);
            var output = Squ.GetArea();
            Assert.AreEqual(ans, output);
        }
              
      
        public void Rectangle_GetArea_ValidInput_ReturnIsCorrect(int s1,int s2, int ans)
        {
           Recg = new Rectangle("Red", s1, s2);
            var output = Recg.GetArea();
            Assert.AreEqual(ans, output);
        }
               
        [Test]
        public void RectangleTests() {
            int area = 12;
            int perimeter = 14;
            
            Assert.AreEqual(area, Rec1.GetArea());
            Assert.AreEqual(perimeter, Rec1.GetPerimeter());

            area = 20;
            perimeter = 18;
            
            Assert.AreEqual(area, Rec2.GetArea());
            Assert.AreEqual(perimeter, Rec2.GetPerimeter());
            
        }
        
    }
}