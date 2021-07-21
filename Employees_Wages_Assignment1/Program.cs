using System;

namespace Employees_Wages_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int emp_Chceck = random.Next(0, 2);
            if(emp_Chceck==1)
            {
                Console.WriteLine("Employee is present!");
            }
            else
            {
                Console.WriteLine("Employee is Absent!");
            }
            
        }
    }
}
