using System;
using System.Threading;

namespace ConsoleApplication
{
    class ConsoleApplication
    {
        static void Main()
        {

            string name, location;
            Console.WriteLine("Please enter your name:");

            name = Console.ReadLine();
            Console.WriteLine("Please enter your location:");

            location = Console.ReadLine();
            Console.WriteLine($"My name is {name}.");
            Console.WriteLine($"I am from {location}.");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            DateTime thisDay = DateTime.Today;
            Console.WriteLine(thisDay.ToString("d"));

            DateTime endTime = DateTime.Parse("12/25/2020");
            DateTime startTime = DateTime.Now;
            TimeSpan advent = endTime - startTime;
            Console.WriteLine($"There are {advent.Days} days until Christmas");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            GlazerApp();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
        static void GlazerApp()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please enter the window width:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please enter the window height:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width + height);

            Console.WriteLine($"The length of the wood is {woodLength} feet.");
            Console.WriteLine($"The area of the glass is {glassArea} square metres.");
        }

    }
}
