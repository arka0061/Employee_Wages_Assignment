using System;

namespace Employees_Wages_Assignment1
{
    class Program
    {
       public  int Days = 1;
       public  int Emp_Wage = 0;
       public  int Emp_Hrs = 0;
       public  int Working_Hrs = 0;
       public String Choose = "";
        public static void Main(string[] args)
        {
            Program obj = new Program(); 
            Console.WriteLine("Welcome to Employee Wage Program!");
            obj.Employee_Wage("Google", 6, 25, 120);     
            obj.Employee_Wage("Wipro", 5, 27, 140);   
        }
        public void Employee_Wage(String Company,int Wage_Per_Hour,int Max_Working_Days,int Max_Working_Hours)
        {
            while (Days <= Max_Working_Days && Working_Hrs <= Max_Working_Hours)
            {           
                Random random = new Random();
                int Emp_Check = random.Next(0, 2);
                if(Emp_Check==0)
                {
                    Choose = "Part_Time";
                }
                else
                {
                    Choose = "Full_Time";
                }

                switch (Choose)
                {
                    case "Part_Time":
                        Console.WriteLine("Employee is Absent");
                        Emp_Hrs = 4;
                        break;
                    case "Full_Time":
                        Console.WriteLine("Employee is Present");
                        Emp_Hrs = 8;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Days++;
                Working_Hrs = Working_Hrs + Emp_Hrs;
                Emp_Wage = Working_Hrs * Wage_Per_Hour;                     
            }      
           Console.WriteLine("Total Employee Wage of " +Company+" "+"is "+ Emp_Wage);
           Console.WriteLine("--------------------------------------------------------------------------");
        }
    }
}


