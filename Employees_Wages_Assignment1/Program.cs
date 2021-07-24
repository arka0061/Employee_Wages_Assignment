using System;

namespace Employees_Wages_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int emp_rate_per_hr = 20;
            for (int day = 0; day < 20; day++)
            {
                Random random = new Random();
                int emp_Chceck = random.Next(0, 2);
                int emp_wage = 0;
                int emp_hrs = 0;
                if (emp_Chceck == 1)
                {
                    Console.WriteLine("Employee is present!");
                    emp_hrs = 8;
                }
                else
                {
                    Console.WriteLine("Employee is Absent!");
                    emp_hrs = 4;
                }
                emp_wage = emp_hrs * emp_rate_per_hr;
                Console.WriteLine("The Wage of Employee is :" + emp_wage);                
            }
        }
    }
}
