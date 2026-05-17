using System;

namespace OperatorOverloadAssignment
{
    // Main program class where execution starts
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first employee and assign values
            Employee employee1 = new Employee()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith"
            };

            // Create the second employee and assign values
            Employee employee2 = new Employee()
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Doe"
            };

            // Use the overloaded == operator to compare employee IDs
            bool isEqual = employee1 == employee2;

            // Show the comparison result in the console window
            Console.WriteLine("Are the employees equal? " + isEqual);

            // Prevent the console from closing immediately
            Console.ReadLine();
        }
    }
}