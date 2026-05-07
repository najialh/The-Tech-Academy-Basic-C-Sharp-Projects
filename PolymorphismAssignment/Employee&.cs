using System;

namespace PolymorphismAssignment
{
    // Employee class gets from Person and uses IQuittable
    public class Employee : Person, IQuittable
    {
        // Employee ID number
        public int Id { get; set; }

        // Prints the employee's full name
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        // Prints a message when the employee quits
        public void Quit()
        {
            Console.WriteLine(firstName + " has resigned from the position.");
        }
    }
}
