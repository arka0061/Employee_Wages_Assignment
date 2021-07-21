using System;

namespace Employees_Wages_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int emp_rate_per_hr = 20;
            Random random = new Random();
            int emp_Chceck = random.Next(0, 2);
            int emp_wage = 0;
            int emp_hrs = 0;

            if(emp_Chceck==1)
            {
                emp_hrs = 8;
            }
            else
            {
                emp_hrs = 4 ;
            }
            emp_wage = emp_hrs * emp_rate_per_hr;
            Console.WriteLine("The Wage of Employee is :" + emp_wage);
            Console.WriteLine("Hi there");
            
        }
    }
}
