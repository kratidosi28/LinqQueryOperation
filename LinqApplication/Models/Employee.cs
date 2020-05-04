using System;
using System.Collections.Generic;
using System.Text;

namespace LinqApplication.Models
{
    class Employee
    {
        public int EMPLOYEE_ID { get; set; }

        public string FIRST_NAME { get; set; }

        public string LAST_NAME { get; set; }

        public int SALARY { get; set; }

        public string JOINING_DATE { get; set; }

        public string DEPARTMENT { get; set; }

        public static List<Employee> EmployeeDetails()

        {
            List<Employee> employees = new List<Employee>();
            {
                employees.Add(new Employee
                {
                    EMPLOYEE_ID = 1,
                    FIRST_NAME = "John",
                    LAST_NAME = "Abraham",
                    SALARY = 1000000,
                    JOINING_DATE = "01-JAN-13 12.00.00 AM",
                    DEPARTMENT = "Banking"
                });

                employees.Add(new Employee
                {
                    EMPLOYEE_ID = 2,
                    FIRST_NAME = "Michael",
                    LAST_NAME = "Clarke",
                    SALARY = 800000,
                    JOINING_DATE = "01-JAN-13 12.00.00 AM",
                    DEPARTMENT = "Insurance"
                });

                employees.Add(new Employee
                {
                    EMPLOYEE_ID = 3,
                    FIRST_NAME = "Roy",
                    LAST_NAME = "Thomas",
                    SALARY = 700000,
                    JOINING_DATE = "01-FEB-13 12.00.00 AM",
                    DEPARTMENT = "Banking"
                });

                employees.Add(new Employee
                {
                    EMPLOYEE_ID = 4,
                    FIRST_NAME = "Tom",
                    LAST_NAME = "Jose",
                    SALARY = 600000,
                    JOINING_DATE = "01-FEB-13 12.00.00 AM",
                    DEPARTMENT = "Insurance"
                });

                return employees;

            }

        }
    }
}
