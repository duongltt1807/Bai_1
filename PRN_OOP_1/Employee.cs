using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_OOP_1
{
    // Abstract class representing an Employee
    public abstract class Employee : IEmployee
    {
        // Protected fields accessible within derived classes
        protected string name;            // Name of the employee
        protected double paymentPerHour;  // Payment rate per hour for the employee

        // Constructor to initialize the employee's name and payment rate per hour
        public Employee(string name, double paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        // Abstract method to calculate the salary, must be implemented by derived classes
        public abstract double CalculateSalary();

        // Overriding the ToString method to provide a string representation of the Employee object
        public override string ToString()
        {
            return $"Name: {name}, Payment per Hour: {paymentPerHour}";
        }
    }
}
