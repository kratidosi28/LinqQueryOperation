using System;
using System.Collections.Generic;
using System.Linq;
using LinqApplication.Models;

namespace LinqApplication
{
    class Program
    {
    static void Main(string[] args)
        {
            var getEmployees = Employee.EmployeeDetails();

            //Query to Get all Employee Details
            /*   var Empdetails = from employee in getEmployees
                                select new { EmployeeId = employee.EMPLOYEE_ID,FirstName =employee.FIRST_NAME, LastName = employee.LAST_NAME, Salary = employee.SALARY,JoiningDate = employee.JOINING_DATE,Department = employee.DEPARTMENT };
             Console.WriteLine("To Get all EmployeeDetails");
             foreach (var employee in Empdetails)
             {
                 Console.WriteLine(employee);
             }*/

            //Query to Get FIRST_NAME,LAST_NAME
            /* var Empdetails = from employee in getEmployees
                              select new { FirstName = employee.FIRST_NAME, LastName = employee.LAST_NAME };
             Console.WriteLine("FirstName And LastName of all Employees");
             foreach (var employee in Empdetails)
             {
                 Console.WriteLine(employee);
             }*/

            //Query to Get FirstName using alias name as "Employee Name"
            /* var Empdetails = from employee in getEmployees
                              select new { EmployeeName = employee.FIRST_NAME };
             Console.WriteLine("FirstName of all Employees");
             foreach (var employee in Empdetails)
             {
                 Console.WriteLine(employee);

               }*/

            //Query to Get FirstName in UpperCase
            /* var Empdetails = from employee in getEmployees
                              select new { EmployeeName =  employee.FIRST_NAME.ToUpper() };
             Console.WriteLine("FirstName of all Employees in UpperCase");
             foreach (var employee in Empdetails)
             {
                 Console.WriteLine(employee);

             }*/

            //Query to Get FirstName in UpperCase
            /* var Empdetails = from employee in getEmployees
                              select new { EmployeeName = employee.FIRST_NAME.ToLower() };
             Console.WriteLine("FirstName of all Employees in LowerCase");
             foreach (var employee in Empdetails)
             {
                 Console.WriteLine(employee);

             }*/

           var distinctDept  = from employee in getEmployees
                               where 
                             select  employee.DEPARTMENT.Distinct();
            Console.WriteLine("Unique Departments");
            foreach (var employee in distinctDept)
            {
                Console.WriteLine(employee);

            }

         




        }






    }
}
