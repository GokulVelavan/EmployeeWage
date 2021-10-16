using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Program
    {
<<<<<<< HEAD
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        public static int computeEMPwage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
=======
         public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {
>>>>>>> ee2b01351322d8c40a3c249bb3e42f269b7c3a1a


<<<<<<< HEAD
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

                Console.WriteLine("DAYS:{0}", +totalWorkingDays + "EMP HRS: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;


            Console.WriteLine(" Total EMP WAGE:{0}", totalEmpWage);
            return totalEmpWage;

        }

        static void Main(string[] args)
        {
            computeEMPwage();
=======
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
            
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("EMP WAGE:{0}", empWage);
>>>>>>> ee2b01351322d8c40a3c249bb3e42f269b7c3a1a
            Console.ReadLine();

        }
    }
}
