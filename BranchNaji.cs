using System;

class Program
{
    static void Main()
    {
        // welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // ask for weight
        Console.WriteLine("Please enter the package weight:");
        decimal w = Convert.ToDecimal(Console.ReadLine());

        // if weight too big, stop program
        if (w > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // ask for width
        Console.WriteLine("Please enter the package width:");
        decimal wid = Convert.ToDecimal(Console.ReadLine());

        // ask for height
        Console.WriteLine("Please enter the package height:");
        decimal h = Convert.ToDecimal(Console.ReadLine());

        // ask for length
        Console.WriteLine("Please enter the package length:");
        decimal l = Convert.ToDecimal(Console.ReadLine());

        // add dimensions
        decimal total = wid + h + l;

        // check if too big
        if (total > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // calculate price
        decimal calc = wid * h * l;
        calc = calc * w;
        calc = calc / 100;

        // show result
        Console.WriteLine("Your estimated total for shipping this package is: $" + calc.ToString("0.00"));

        // end message
        Console.WriteLine("Thank you!");
    }
}
