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

=======
         public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
>>>>>>> ee2b01351322d8c40a3c249bb3e42f269b7c3a1a
        static void Main(string[] args)
        {

            int empHrs = 0;
            int empWage = 0;
<<<<<<< HEAD
            int totalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
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
                totalEmpWage += empWage;
                Console.WriteLine("EMP WAGE:{0}", empWage);
            }


            Console.WriteLine(" Total EMP WAGE:{0}", totalEmpWage);
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
