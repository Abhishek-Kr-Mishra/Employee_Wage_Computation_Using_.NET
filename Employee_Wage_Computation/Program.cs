using System;

namespace Employee_Wage_Computation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            int IS_FULL_TIME = 1;

            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if(empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
