using System;
using System.Collections.Generic;
using System.Linq;
using LinqApplication.Models;
using Microsoft.EntityFrameworkCore.Internal;

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

            //Query to Get distinct departments
            /* var distinctDept = Employee.EmployeeDetails()
                    .Select(emp => emp.DEPARTMENT)
                    .Distinct().ToList();

             foreach (var dept in distinctDept)
             {
                 Console.WriteLine(dept);
             }
             */

            //Query to select 1st three character from firstname of employee

            /*var Empdetails = from employee in getEmployees
                             select new { EmployeeName = employee.FIRST_NAME.Substring(0,3) };
            Console.WriteLine("First three character of FirstName of all Employees");
            foreach (var employee in Empdetails)
            {
                Console.WriteLine(employee);

            }*/

            //Query to find out position of 'o' in john
            /* var Empdetails = from employee in getEmployees
                                 where (employee.FIRST_NAME == "John")
                                  select (employee.FIRST_NAME).IndexOf('o');

             foreach (var employee in Empdetails)
             {
                 Console.WriteLine(employee);

             }*/




            //query to get first name of all employees table after removing white spaces from both side.

            /*  var Empdetails = from employee in getEmployees
                               select employee.FIRST_NAME.Trim();
              Console.WriteLine("FirstName of all Employees");
              foreach (var employee in Empdetails)
              {
                  Console.WriteLine(employee);

              }*/



            //query to get length of first name of all employees

            /* var Empdetails = from employee in getEmployees
                               select (employee.FIRST_NAME).Length;
              Console.WriteLine("Length of FirstName of all Employees");
              foreach (var employee in Empdetails)
              {
                  Console.WriteLine(employee);

              }*/

            //query to replace 'o' with '$'

            /*   var Empdetails = from employee in getEmployees
                                select (employee.FIRST_NAME).Replace('o','$');
              
               foreach (var employee in Empdetails)
               {
                   Console.WriteLine(employee);

               
            */

            //Query  to get firstname and lastname as single column separated by _

            /*  var Empdetails = from employee in getEmployees
                               select employee.FIRST_NAME + '_' + employee.LAST_NAME;

                  foreach (var employee in Empdetails)
              {
                  Console.WriteLine(employee);

              }*/

            //Query to get all employee details order by firstname ascending

            /*var Empdetails = from employee in getEmployees
                             orderby employee.FIRST_NAME
                             select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

            foreach (var employee in Empdetails)
            {
                Console.WriteLine(employee);

            }
            */

            //Query to get all employee details order by firstname descending

            /* var Empdetails = from employee in getEmployees
                              orderby employee.FIRST_NAME descending
                              select new {employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

             foreach (var employee in Empdetails)
             {
                 Console.WriteLine(employee);

             }*/

            //Query to get all employee details order by firstname ascending and salary descending
            /*  var Empdetails = from employee in getEmployees
                              orderby employee.FIRST_NAME ascending,employee.SALARY descending
                             select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

            foreach (var employee in Empdetails)
            {
                Console.WriteLine(employee);

            }*/


            //Query to get all employee details whose name is "john"
            /*  var Empdetails = from employee in getEmployees
                               where employee.FIRST_NAME == "John"
                               select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

              foreach (var employee in Empdetails)
              {
                  Console.WriteLine(employee);

              }*/

            //Query to get all employee details whose name is "john and roy"
            /*  var Empdetails = from employee in getEmployees
                               where (employee.FIRST_NAME == "John" || employee.FIRST_NAME == "Roy")
                               select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

              foreach (var employee in Empdetails)
              {
                  Console.WriteLine(employee);

              }*/


            //Query to get all employee details whose name are not "john and roy"
            /* var Empdetails = from employee in getEmployees
                              where (employee.FIRST_NAME != "John" && employee.FIRST_NAME != "Roy")
                              select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

             foreach (var employee in Empdetails)
             {
                 Console.WriteLine(employee);

             }
*/

            //Query to get all employee details whose name start with j
            /*   var Empdetails = from employee in getEmployees
                                where employee.FIRST_NAME.StartsWith('J')
                                select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

               foreach (var employee in Empdetails)
               {
                   Console.WriteLine(employee);

               }
              */


            //Query to get all employee details whose name contains o
            /* var Empdetails = from employee in getEmployees
                               where employee.FIRST_NAME.Contains('o')
                               select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

              foreach (var employee in Empdetails)
              {
                  Console.WriteLine(employee);

              }*/


            //Query to get all employee details whose name end with 'n'
            /*  var Empdetails = from employee in getEmployees
                                 where employee.FIRST_NAME.EndsWith('n')
                                 select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

                foreach (var employee in Empdetails)
                {
                    Console.WriteLine(employee);

                }
              */

            //Query to get all employee details whose name end with 'n' and contains 4 letter
            /*var Empdetails = from employee in getEmployees
                             where employee.FIRST_NAME.EndsWith('n') && employee.FIRST_NAME.Length == 4
                                 select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

                foreach (var employee in Empdetails)
                {
                    Console.WriteLine(employee);

                }*/

            //Query to get all employee details whose name start with 'J' and contains 4 letter
            /*var Empdetails = from employee in getEmployees
                             where employee.FIRST_NAME.StartsWith('J') && employee.FIRST_NAME.Length == 4
                                 select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

                foreach (var employee in Empdetails)
                {
                    Console.WriteLine(employee);

                }*/

            //Query to get all employee details whose salary is greater than 600000
            /* var Empdetails = from employee in getEmployees
                              where employee.SALARY> 600000
                                  select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

                 foreach (var employee in Empdetails)
                 {
                     Console.WriteLine(employee);

                 }*/

            //Query to get all employee details whose salary is less than 800000
            /* var Empdetails = from employee in getEmployees
                              where employee.SALARY< 800000
                                  select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

                 foreach (var employee in Empdetails)
                 {
                     Console.WriteLine(employee);

                 }

                  */


            //Query to get all employee details whose salary is between 500000 and 800000
            /*  var Empdetails = from employee in getEmployees
                                where employee.SALARY > 500000 && employee.SALARY <800000
                                    select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

                   foreach (var employee in Empdetails)
                   {
                       Console.WriteLine(employee);

                   }*/



            //Query to get all employee details whose name is "john and michael"
            /*  var Empdetails = from employee in getEmployees
                               where (employee.FIRST_NAME == "John" || employee.FIRST_NAME == "Michael")
                               select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

              foreach (var employee in Empdetails)
              {
                  Console.WriteLine(employee);

              }*/


            //Query to get all employee details whose joining year is 2013
            /*  var Empdetails = from employee in getEmployees
                                where employee.JOINING_DATE.Substring(7,2) == "13"
                                 select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

                foreach (var employee in Empdetails)
                {
                    Console.WriteLine(employee);

                }*/

            //Query to get all employee details whose joining month is jan
            /* var Empdetails = from employee in getEmployees
                              where (employee.JOINING_DATE.Substring(3,3)) == "JAN"
                              select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

             foreach (var employee in Empdetails)
             {
                 Console.WriteLine(employee);

             }*/


            //Query to get all employee details whose join before january 31st 2013
            /*  var Empdetails = from employee in getEmployees
                               where (employee.JOINING_DATE.Substring(0,2) != "31") && (employee.JOINING_DATE.Substring(3,3)) == "JAN" && employee.JOINING_DATE.Substring(7, 2) == "13"
                               select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

              foreach (var employee in Empdetails)
              {
                  Console.WriteLine(employee);

              }*/

            // Query to Get employee details from employee table who joined after January 31st

            /*    var Empdetails = from employee in getEmployees
                                where employee.JOINING_DATE.Substring(3,3) != "JAN"
                                select new { employee.FIRST_NAME, employee.LAST_NAME, employee.JOINING_DATE, employee.SALARY, employee.DEPARTMENT };

               foreach (var employee in Empdetails)
               {
                   Console.WriteLine(employee);

               }

             */

            // Query to Get Joining Date and Time from employee table

            /*     var Empdetails = from employee in getEmployees
                                 select employee.JOINING_DATE;

                 foreach (var employee in Empdetails)
                 {
                     Console.WriteLine(employee);

                 }

            */

            // Query to Get difference between JOINING_DATE and INCENTIVE_DATE from employee and incentives table
            /*
                        var Empdetails = Employee.EmployeeDetails();
                        var IncentiveDetails = Incentives.IncentiveDetails();

                        var getDate = Empdetails.Join(IncentiveDetails, emp =>emp.EMPLOYEE_ID, incen => incen.EMPLOYEE_REF_ID,(emp,incen) => new
                        {
                            JOINING = emp.JOINING_DATE,
                            INCENTIVE = incen.INCENTIVE_DATE,
                        });

                        foreach (var employee in getDate)
                        {
                            Console.WriteLine(employee);

                        }*/


            //Query to Get Last Name from employee table after replacing special character with white space
            /*  var Empdetails = from employee in getEmployees
                               where employee.LAST_NAME.Replace('%','')
                               select employee.LAST_NAME;

              foreach (var employee in Empdetails)
              {
                  Console.WriteLine(employee);

              }*/


            //Query to Get department,total salary with respect to a department from employee table.
          /*  var Empdetails = from employee in getEmployees
                             group employee by employee.DEPARTMENT;
                            
              foreach (var employee in Empdetails)
              {
                  Console.WriteLine(employee.Key);

                foreach (Employee e in employee) // Each group has inner collection
                    Console.WriteLine("Employee salary: {0}", e.SALARY);
               }*/









    }






    }
}
