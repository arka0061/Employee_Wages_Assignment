using System;

namespace Employees_Wages_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int emp_rate_per_hr = 20;
            int days = 0;
            int working_hrs = 0;
            while (days <= 20 || working_hrs <= 100)
            {

                Random random = new Random();
                int emp_Chceck = random.Next(0, 2);
                int emp_wage = 0;
                int emp_hrs = 0;
              
                  switch (emp_Chceck)
                  {
                      case 0:
                          emp_hrs = 4;
                          break;
                      case 1:
                          emp_hrs = 8;
                          break;
                      default:
                          emp_hrs = 0;
                          break;
                  }

              }
              emp_wage = emp_hrs * emp_rate_per_hr;
             
             Console.WriteLine("Employer Wage is : " + emp_wage);
                 */
                days++;
                working_hrs++;
             }
            }
        }
}
