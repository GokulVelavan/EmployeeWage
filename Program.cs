using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Program
    {
        

        
              

        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.computeEMPwage();
            Console.WriteLine(dMart.toString());
            reliance.computeEMPwage();
            Console.WriteLine(reliance.toString());
            Console.ReadLine();

        }
    }
}
