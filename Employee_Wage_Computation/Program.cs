
using System;

namespace Employee_Wage_Computation
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmpWageBuiderObject dmart = new EmpWageBuiderObject("D-Mart", 20, 50, 10);
            EmpWageBuiderObject bigBazar = new EmpWageBuiderObject("Big-Bazar", 20, 80, 20);
            dmart.ComputeEmpWage();
            Console.WriteLine(dmart.toString());

            bigBazar.ComputeEmpWage();
            Console.WriteLine(bigBazar.toString());

        }
    }
}
