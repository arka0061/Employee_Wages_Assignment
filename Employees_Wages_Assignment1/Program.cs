using System;
using System.Collections;
using System.Collections.Generic;

namespace Employees_Wages_Assignment1
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            EmpWageBuilder obj1 = new EmpWageBuilder("Google",5, 27, 120);
            EmpWageBuilder obj2 = new EmpWageBuilder("Google", 6, 30, 110);
            ///Company 1 object
            obj1.Employee_Wage(); 
            obj1.Display();
            ///Company 2 object
            obj2.Employee_Wage();
            obj2.Display();
        }
       
    }
}


