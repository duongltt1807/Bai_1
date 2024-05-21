using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_OOP_1
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            // Initialize a dynamic array to manage Employee objects
            Employee[] employees = new Employee[0];

            while (true)
            {
                // Display menu options to the user
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Find Employee with Highest Salary");
                Console.WriteLine("3. Find Employee by Name");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                // Perform the action based on user input
                switch (choice)
                {
                    case "1":
                        // Call method to add a new employee
                        AddEmployee(ref employees);
                        break;
                    case "2":
                        // Call method to find the employee with the highest salary
                        FindHighestPaidEmployees(employees);
                        break;
                    case "3":
                        // Call method to find an employee by name
                        FindEmployeeByName(employees);
                        break;
                    case "4":
                        // Exit the program
                        Console.WriteLine("Exiting the program.");
                        return;
                    default:
                        // Handle invalid input
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }

        public static void AddEmployee(ref Employee[] employees)
        {
            try
            {
                // Prompt the user to enter employee details
                Console.WriteLine("Add Employee:");
                Console.Write("Enter employee name: ");
                string name = Console.ReadLine();
                Console.Write("Enter hourly wage: ");
                double paymentPerHour = Convert.ToDouble(Console.ReadLine());

                // Resize the array to accommodate the new employee
                Array.Resize(ref employees, employees.Length + 1);
                // Add a new FullTimeEmployee (by default) to the array
                employees[employees.Length - 1] = new FullTimeEmployee(name, paymentPerHour);
                Console.WriteLine("Employee added successfully.");
            }
            catch (FormatException)
            {
                // Handle invalid input format
                Console.WriteLine("Error: Invalid input data. Please try again.");
            }
        }

        public static void FindHighestPaidEmployees(Employee[] employees)
        {
            // Initialize variables to track the highest salaries and corresponding employees
            double maxSalaryFullTime = double.MinValue;
            double maxSalaryPartTime = double.MinValue;
            FullTimeEmployee highestPaidFullTime = null;
            PartTimeEmployee highestPaidPartTime = null;

            // Iterate through each employee to find the highest salaries
            foreach (var employee in employees)
            {
                if (employee is FullTimeEmployee)
                {
                    double salary = employee.CalculateSalary();
                    if (salary > maxSalaryFullTime)
                    {
                        maxSalaryFullTime = salary;
                        highestPaidFullTime = (FullTimeEmployee)employee;
                    }
                }
                else if (employee is PartTimeEmployee)
                {
                    double salary = employee.CalculateSalary();
                    if (salary > maxSalaryPartTime)
                    {
                        maxSalaryPartTime = salary;
                        highestPaidPartTime = (PartTimeEmployee)employee;
                    }
                }
            }

            // Display the highest-paid employees
            Console.WriteLine($"Employee with highest salary in FullTime: {highestPaidFullTime}, Salary: {maxSalaryFullTime}");
            Console.WriteLine($"Employee with highest salary in PartTime: {highestPaidPartTime}, Salary: {maxSalaryPartTime}");
        }

        public static void FindEmployeeByName(Employee[] employees)
        {
            // Prompt the user to enter the name of the employee to find
            Console.Write("Enter the name of the employee to find: ");
            string name = Console.ReadLine();
            bool found = false;

            // Iterate through each employee to find matches
            foreach (var employee in employees)
            {
                if (employee.ToString().Contains(name))
                {
                    // If a match is found, display the employee details
                    Console.WriteLine($"Employee found: {employee}");
                    found = true;
                }
            }

            // If no match is found, inform the user
            if (!found)
            {
                Console.WriteLine("No employee found with that name.");
            }
        }
    }
}
