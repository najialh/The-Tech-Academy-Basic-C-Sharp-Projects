using System;

namespace PolymorphismAssignment
{
    // Base class for a person
    public abstract class Person
    {
        // Person's first name
        public string firstName { get; set; }

        // Person's last name
        public string lastName { get; set; }

        // Method that child classes must use
        public abstract void SayName();
    }
}