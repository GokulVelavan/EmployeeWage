using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public static int computeEMPwage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonths)
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //computation
            while (totalEmpHrs <= maxHoursPerMonths && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;

                Console.WriteLine("DAYS: " + totalWorkingDays + " EMP HRS: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;


            Console.WriteLine(" Total EMP WAGE for COMPANY: " + company + " IS: " + totalEmpWage);
            return totalEmpWage;

        }
              

        static void Main(string[] args)
        {
            computeEMPwage("DMart", 20, 2, 30);
            computeEMPwage("Reliance", 10, 4, 20);
            Console.ReadLine();

        }
    }
}
