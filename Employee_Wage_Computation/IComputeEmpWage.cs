using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    interface IComputeEmpWage
    {
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public int ComputeEmpWage(CompanyEmpWage companyEmpWage);
        public int GetTotalWage(string company);
    }
}
