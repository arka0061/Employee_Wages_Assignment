using System;
using System.Collections;
using System.Collections.Generic;

namespace Employees_Wages_Assignment1
{
    class Program
    {
        public static List<Company_Employee_Wage> Company = new List<Company_Employee_Wage>();
        public static void Main(string[] args)
        {
            EmpWageBuilder emp = new EmpWageBuilder();
            Company.Add(new Company_Employee_Wage()
            { Company_Name = "Google", Wage_Per_Hour = 6, Max_Working_Days = 29, Max_Working_Hours = 130 });
            Company.Add(new Company_Employee_Wage()
            { Company_Name = "Amazon", Wage_Per_Hour = 7, Max_Working_Days = 30, Max_Working_Hours = 120 });
            Company.Add(new Company_Employee_Wage()
            { Company_Name = "Google", Wage_Per_Hour = 9, Max_Working_Days = 25, Max_Working_Hours = 110 });
            emp.Wage_Computation();
            }
        }
    }





