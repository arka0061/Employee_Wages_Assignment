using System;

namespace Employees_Wages_Assignment1
{


	public class EmpWageBuilder
	{
		public String Company_Name;
		public int Wage_Per_Hour;
		public int Max_Working_Days;
		public int Max_Working_Hours;
        public int Days = 1;
        public int Total_Wage = 0;
        public int Emp_Hrs = 0;
        public int Working_Hrs = 0;
        public String Choose = "";
        public EmpWageBuilder(String companyName, int wage_Per_Hour, int max_Working_Days, int max_Working_Hours)

		{
			Company_Name = companyName;
			Wage_Per_Hour = wage_Per_Hour;
			Max_Working_Days = max_Working_Days;
			Max_Working_Hours = max_Working_Hours;
		}
	       public void Employee_Wage()
            {
                while (Days <= Max_Working_Days && Working_Hrs <=Max_Working_Hours)
                {
                    Random random = new Random();
                    int Emp_Check = random.Next(0, 2);
                    if (Emp_Check == 0)
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
                    Total_Wage = Working_Hrs * Wage_Per_Hour;
                }
              
            }
        public void Display()
        {
            Console.WriteLine("Total Employee Wage of " + Company_Name + " " + "is " + Total_Wage);
            Console.WriteLine("--------------------------------------------------------------------------");

        }
        }
	}





