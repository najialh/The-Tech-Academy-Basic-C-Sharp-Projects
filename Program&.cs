using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an employee object
            Employee emp = new Employee()
            {
                firstName = "John",
                lastName = "Smith",
                Id = 1
            };

            // Show the employee's name
            emp.SayName();

            // Use the interface for polymorphism
            IQuittable quittableEmp = emp;

            // Call the Quit method
            quittableEmp.Quit();

            // Keeps the console open
            Console.ReadLine();
        }
    }
}