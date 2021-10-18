using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonths;
        private int totalEmpWage;



        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonths)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonths = maxHoursPerMonths;
        }

        public void computeEMPwage()
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //computation
            while (totalEmpHrs <=this.maxHoursPerMonths && totalWorkingDays < this.numOfWorkingDays)
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
             totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total EMP WAGE for COMPANY: " + company + " IS: " + totalEmpWage);

        }
         
        public string toString()
        {
            return "Total Emp Wage for company :" + this.company + " is: " + this.totalEmpWage;
        }



    }
}
