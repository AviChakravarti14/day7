using System;
using ShapeAreaLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Square square = new Square();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();
            Console.WriteLine("Enter 1.Rectangle    2.Square    3.CIrcle     4. Triangle  ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("Enter length and breadth of the rectangle");
                        double x=double.Parse(Console.ReadLine());
                        double y=double.Parse(Console.ReadLine());
                        Rectangle.Area(x, y);
                        

                        break;


                    }
                    case 2:
                    {
                        Console.WriteLine("Enter side of square");
                        double y=double.Parse(Console.ReadLine());
                        Square.Area(y);
                        break;

                    }
                    case 3:
                    {
                        Console.WriteLine("Enter radius of circle");
                        double x = double.Parse(Console.ReadLine());
                        Circle.Area(x);
                        break;

                    }
                    case 4:
                    {
                        Console.WriteLine("Enter base and height of triangle");
                        double x = double.Parse(Console.ReadLine());
                        double y = double.Parse(Console.ReadLine());
                       Triangle.Area(x, y);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choice");
                        return;
                    }
                  
                   
            }
            Console.ReadKey();

        }
    }
}
