using System;

namespace Employees_Wages_Assignment1
{
    class Program
    {
       public static int Emp_Rate_Per_Hr = 20;
       public static int Days = 0;
       public static int Emp_Wage = 0;
       public static int Emp_Hrs = 0;
       public static int Working_Hrs = 0;
        public static void Main(string[] args)
        {
            Program obj = new Program(); 
            Console.WriteLine("Welcome to Employee Wage Program!");
            Program.Employee_Wage();           
        }
        public static void Employee_Wage()
        {
            while (Days <= 20 || Working_Hrs <= 100)
            {
                Random random = new Random();
                int Emp_Check = random.Next(0, 2);

                switch (Emp_Check)
                {
                    case 0:
                        Console.WriteLine("Employee is Absent");
                        Emp_Hrs = 4;
                        break;
                    case 1:
                        Console.WriteLine("Employee is Present");
                        Emp_Hrs = 8;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Days++;
                Working_Hrs = Working_Hrs + Emp_Hrs;
            }
            Emp_Wage = Working_Hrs * Emp_Rate_Per_Hr;

            Console.WriteLine("Employer Wage is : " + Emp_Wage);
        }
    }
}


