using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
   

    class EmpWageBuiderObject
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuiderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public int ComputeEmpWage()
        {
            int empHrs = 0, empWage, totalEmpHours = 0, totalWorkingDays = 0;
            Random random = new Random();

            while (totalWorkingDays < numOfWorkingDays && totalEmpHours < maxHoursPerMonth)
            {
                totalWorkingDays++;
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        totalEmpHours += 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        totalEmpHours += 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * empRatePerHour;
                totalEmpWage += empWage;
                Console.WriteLine("Day= " + totalWorkingDays + "  Wage= " + empHrs);
            }
            Console.WriteLine("Total Emp Wage for " + company + " is " + totalEmpWage);
            return totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for company" + this.company + " is " + this.totalEmpWage;
        }
    }
}
