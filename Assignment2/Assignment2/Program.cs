using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            DisplayMenu();
            int Result = 0;
            while (Result != 7)
            {
                Result = GetMenuSelection();
                if (Result == 1)
                {
                    int length = r.GetLength();
                    Console.WriteLine(length);
                }
                if (Result == 2)
                {
                    Console.WriteLine("Please enter the new length");
                    int newLength = Int32.Parse(Console.ReadLine());
                    r.ChangeLength(newLength);
                }
                if (Result == 3)
                {
                    int width = r.GetWidth();
                    Console.WriteLine(width);
                }
                if (Result == 4)
                {
                    Console.WriteLine("Please enter the new Width");
                    int newWidth = Int32.Parse(Console.ReadLine());
                    r.ChangeLength(newWidth);
                }
                if (Result == 5)
                {
                    int Perimeter = r.GetPerimiter();
                    Console.WriteLine(Perimeter);
                }
                if (Result == 6)
                {
                    int Area = r.GetArea();
                    Console.WriteLine(Area);
                }
            }
            Console.WriteLine("Exiting Program...");
            Thread.Sleep(2000);
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Get Length");
            Console.WriteLine("2. Change Length");
            Console.WriteLine("3. Get Width");
            Console.WriteLine("4. Change Width");
            Console.WriteLine("5. Change Perimeter");
            Console.WriteLine("6. Change Area");
            Console.WriteLine("7.Exit");
        }

        public static int GetMenuSelection()
        {
            return Int32.Parse(Console.ReadLine());

        }
    }
}
