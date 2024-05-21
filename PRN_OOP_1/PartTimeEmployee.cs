using PRN_OOP_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_OOP_1
{
    // Class representing a part-time employee, inheriting from Employee
    public class PartTimeEmployee : Employee
    {
        // Private field to store the number of working hours for the part-time employee
        private double workingHours;

        // Constructor to initialize the part-time employee's name, payment rate per hour, and working hours
        public PartTimeEmployee(string name, double paymentPerHour, double workingHours) : base(name, paymentPerHour)
        {
            this.workingHours = workingHours; // Set the working hours for the part-time employee
        }

        // Method to calculate the salary for a part-time employee
        // Salary is based on the actual number of working hours
        public override double CalculateSalary()
        {
            return workingHours * paymentPerHour; // Salary is calculated based on the specified working hours
        }
    }
}
