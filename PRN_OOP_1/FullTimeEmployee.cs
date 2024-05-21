
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_OOP_1
{
    // Class representing a full-time employee, inheriting from Employee
    public class FullTimeEmployee : Employee
    {
        // Constructor to initialize the full-time employee's name and payment rate per hour
        public FullTimeEmployee(string name, double paymentPerHour) : base(name, paymentPerHour) { }

        // Method to calculate the salary for a full-time employee
        // Assumes a standard 8-hour workday
        public override double CalculateSalary()
        {
            return 8 * paymentPerHour; // Salary is calculated based on 8 hours per day
        }
    }
}

