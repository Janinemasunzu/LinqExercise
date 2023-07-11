using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            int sum = numbers.Sum();
            Console.WriteLine("The sum of all numbers");
            Console.WriteLine(sum);
            Console.WriteLine();
            //TODO: Print the Average of numbers
            Console.WriteLine("Average of all numbers");
            Console.WriteLine(numbers.Average());
            Console.WriteLine();    
            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Numbers in ascending order");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine("Numbers in descending order");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers greater than 6");
            numbers.Where(x => x > 6).ToList().ForEach(x=> Console.WriteLine(x));
            Console.WriteLine();
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Printed only 4 numbers in ascending order");
            foreach (var x in numbers.OrderBy(x => x).Take(4)) 
            { 
                Console.WriteLine(x);
            }
             Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("My age at index 4 in descending order");
            numbers.SetValue(23, 4);
            foreach (var age in numbers)
            { 
                Console.WriteLine(age);
            }
            Console.WriteLine();
            // List of employees ****Do not remove this****
            List<Employee> employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Printed full names with the first name starting with C and S");
            employees.Where( x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S').OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Printed Full names and ages of employees who are over 26");
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x=> Console.WriteLine($"Names : {x.FullName}, age : {x.Age}"));
            Console.WriteLine();


            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Printed sum of YOE");
            var employeeSum =employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine(employeeSum);
            Console.WriteLine();
            Console.WriteLine("Average of YOE");
            var employeeAverage = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine(employeeAverage);
            Console.WriteLine();
            //TODO: Add an employee to the end of the list without using employees.Add()
            Employee employee = new Employee();
            employee.FirstName = "Jesse";
            employee.LastName = "Nguwe";
            employee.Age = 30;
            employee.YearsOfExperience = 12;

            employees.Append(employee).ToList().ForEach(x => Console.WriteLine(x.FullName));

            Console.WriteLine(employee);
           

          
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
