
using System;

namespace Employee_Wage_Computation
{
    class Program
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        

        public static int ComputeEmpWage(string company, int empratePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0, empWage, totalEmpWage = 0, totalEmpHours = 0, totalWorkingDays = 0;
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
                empWage = empHrs * empratePerHour;
                totalEmpWage += empWage;
                Console.WriteLine("Day= " + totalWorkingDays+"  Wage= " + empHrs);
            }
            Console.WriteLine("Total Emp Wage for " + company + " is " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            ComputeEmpWage("D-mart", 20, 20, 50);
            Console.WriteLine();
            ComputeEmpWage("Big-Bazar", 20, 10, 50);
        }
    }
}
