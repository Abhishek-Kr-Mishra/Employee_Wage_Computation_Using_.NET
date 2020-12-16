
using System;

namespace Employee_Wage_Computation
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmpWageBuiderArray empWageBuiderArray = new EmpWageBuiderArray();

            empWageBuiderArray.AddCompanyEmpWage("D-Mart", 20, 15, 80);
            empWageBuiderArray.AddCompanyEmpWage("Big-Bazar", 20, 10, 80);
            empWageBuiderArray.ComputeEmpWage();
        }
    }
}
