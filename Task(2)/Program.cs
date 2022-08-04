using System;

namespace Task_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            //int a = int.Parse(Console.ReadLine());
            //int b= int.Parse(Console.ReadLine());
            //int c= int.Parse(Console.ReadLine());

            Console.WriteLine("Area of the circle: "+Area(r));
            //Console.WriteLine("Area of the rectangle: "+Area(a,b));
            //Console.WriteLine("Area of the rectangular parallelepiped: "+Area(a,b,c));
            //Console.WriteLine("Area of the circle inside of a triangle: "+Area(a, b, c, r));
        }
        
        static int Area(int r)
        {
            return 3 * r * r;
        }
        static int Area(int a, int b)
        {
            return a * b;
        }
       
        static int Area(int a, int b, int c)
        {
            return 2 * (a * b + a * c + b * c);
           
        }
        static int Area(int a, int b, int c, int r)
        {
            int p = (a + b + c) / 2;
            return p * r;
        }

    }
}
