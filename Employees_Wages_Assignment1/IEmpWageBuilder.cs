using System;
using System.Collections.Generic;
using System.Text;

namespace Employees_Wages_Assignment1
{
    public interface IEmpWageBuilder
    {
        public void Wage_Computation();
        public void Display(CompanyEmployeWage cmp);
    }
}
