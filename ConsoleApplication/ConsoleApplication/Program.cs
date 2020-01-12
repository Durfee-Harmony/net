using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Harmony";
            string loc = "USA";
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            DateTime today = DateTime.Today;
            DateTime christ = new DateTime(2020, 12, 25);
            double christmas = (christ - today).TotalDays;
            Console.WriteLine("My name is: " + name);
            Console.WriteLine("My location is: " + loc);
            Console.WriteLine("The date is: " + date);
            Console.WriteLine("Days till Christmas: " + christmas);

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
            Console.ReadKey();
        }
    }
}
