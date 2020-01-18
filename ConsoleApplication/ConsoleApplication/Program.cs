using System;

namespace ConsoleApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string name;
      Console.Write("I demand you to enter your name: ");
      name = Console.ReadLine();

      string loc;
      Console.Write("I demand you to enter your location: ");
      loc = Console.ReadLine();

      string date = DateTime.Now.ToString("d");
      DateTime today = DateTime.Today;
      DateTime christ = new DateTime(today.Year, 12, 25);
      double christmas = (christ - today).TotalDays;

      Console.WriteLine($"Apparently... your name is: {name}");
      Console.WriteLine($"Seriously? Your location is: {loc}");
      Console.WriteLine($"The date is: {date}");
      Console.WriteLine($"Days till Christmas: {christmas}");

      double width, height, woodLength, glassArea;
      string widthString, heightString;

      Console.Write("I demand you to enter a width: ");
      widthString = Console.ReadLine();
      width = double.Parse(widthString);

      Console.Write("I demand you to enter a height: ");
      heightString = Console.ReadLine();
      height = double.Parse(heightString);

      woodLength = 2 * (width + height) * 3.25;
      glassArea = 2 * (width * height);
      Console.WriteLine($"The length of the wood is {woodLength} feet");
      Console.WriteLine($"The area of the glass is {glassArea} square metres");

      Console.WriteLine("Press any key to continue...");
      Console.ReadKey();
    }
  }
}
