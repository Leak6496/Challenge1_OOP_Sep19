using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1OOP.Classes;

namespace Challenge1OOP
{

    public class LessthanoneException : Exception
    {
        public LessthanoneException(string message) : base(message) { }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            string choice;
            int side1, side2, side;
            bool req = true;
        while (req)
        {
                try
                {
                    Console.WriteLine("Please Select number from the menu driven:");
                    Console.WriteLine("1.Create Square");
                    Console.WriteLine("2.Create Rectangle");
                    Console.WriteLine("3.Quit");

                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("Please input side Lenght for square: ");
                        side = int.Parse(Console.ReadLine());
                        Square sq = new Square("red", side);
                        req = false;

                    }
                    if (choice == "2")
                    {
                        Console.WriteLine("Please input the side1 lenght for rectangle: ");
                        side1 = int.Parse(Console.ReadLine());
                        req = false;
                        Console.WriteLine("Please input the side2 Lenght for rectangle: ");
                        side2 = int.Parse(Console.ReadLine());
                        Rectangle Recg = new Rectangle("blue", side1, side2);
                        req = false;
                    }
                    if (choice == "3")
                    {
                        System.Environment.Exit(0);
                    }
                }
                catch( LessthanoneException le)
                {
                    Console.WriteLine(le.Message);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                //Console.Clear();
      }//while true

            Console.ReadLine();
        }
    }
}
