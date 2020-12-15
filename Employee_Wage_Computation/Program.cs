using System;

namespace Employee_Wage_Computation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs, empWage;

            Random random = new Random();

            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage = " + empWage);
        }
    }
}
