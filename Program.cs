using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec1 = new Rectangle(10, 20);
            Rectangle rec2 = new Rectangle(15, 25);

            Console.WriteLine("Rectangle with an area of {0} is not equal to a Rectangle with an area of {1} : {2}", rec1.CalculateArea(), rec2.CalculateArea(), rec1!=rec2);
            Console.WriteLine("Rectangle with an area of {0} is equal to a Rectangle with an area of {1} : {2}", rec1.CalculateArea(), rec2.CalculateArea(), rec1 == rec2);
            Console.WriteLine("Rectangle with an area of {0} is greater than a Rectangle with an area of {1} : {2}", rec1.CalculateArea(), rec2.CalculateArea(), rec1 > rec2);
            Console.WriteLine("Rectangle with an area of {0} is greater than or equal to a Rectangle with an area of {1} : {2}", rec1.CalculateArea(), rec2.CalculateArea(), rec1 >= rec2);
            Console.WriteLine("Rectangle with an area of {0} is less than a Rectangle with an area of {1} : {2}", rec1.CalculateArea(), rec2.CalculateArea(), rec1 < rec2);
            Console.WriteLine("Rectangle with an area of {0} is less than or equal to Rectangle with an area of {1} : {2}", rec1.CalculateArea(), rec2.CalculateArea(), rec1 <= rec2);

            Rectangle rec3 = new Rectangle(100, 20);
            Rectangle rec4 = new Rectangle(20, 100);

            Console.WriteLine("Rectangle with an area of {0} is not equal to a Rectangle with an area of {1} : {2}", rec3.CalculateArea(), rec4.CalculateArea(), rec3 != rec4);
            Console.WriteLine("Rectangle with an area of {0} is equal to a Rectangle with an area of {1} : {2}", rec3.CalculateArea(), rec4.CalculateArea(), rec3 == rec4);
            Console.WriteLine("Rectangle with an area of {0} is greater than a Rectangle with an area of {1} : {2}", rec3.CalculateArea(), rec4.CalculateArea(), rec3 > rec4);
            Console.WriteLine("Rectangle with an area of {0} is greater than or equal to a Rectangle with an area of {1} : {2}", rec3.CalculateArea(), rec4.CalculateArea(), rec3 >= rec4);
            Console.WriteLine("Rectangle with an area of {0} is less than a Rectangle with an area of {1} : {2}", rec3.CalculateArea(), rec4.CalculateArea(), rec3 < rec4);
            Console.WriteLine("Rectangle with an area of {0} is less than or equal to Rectangle with an area of {1} : {2}", rec3.CalculateArea(), rec4.CalculateArea(), rec3 <= rec4);


            Polygon hex1 = new Polygon(3, 5, 6, 3, 5, 6 );
            Console.WriteLine("The polygon's perimeter is {0} and it has {1} sides.", hex1.CalculatePerimeter(), hex1.SizeLengths.Count);

            Console.ReadLine();


        }
    }
}
