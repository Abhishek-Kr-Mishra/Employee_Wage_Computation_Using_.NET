
using System;

namespace Employee_Wage_Computation
{
    class Program
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        static int NUM_OF_WORKING_DAYS = 20;
        static int EMP_RATE_PER_HOUR = 20;
        static int MAX_HRS_IN_MONTH = 100;
        static int empHrs = 0, empWage, totalEmpWage = 0, totalEmpHours = 0, totalWorkingDays = 0;

        public static int computeEmpWage()
        {
            Random random = new Random();

            while (totalWorkingDays < NUM_OF_WORKING_DAYS && totalEmpHours <= MAX_HRS_IN_MONTH)
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Day= " + totalWorkingDays + "  Wage= " + empWage);
            }
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Total Employee Wage of a Month "+computeEmpWage());
        }
    }
}
