using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public interface IComputEmpWage
    {
         void addCompanyEmpWage(string company, int empRatePerhour, int numOfWorkingDays, int maxHoursPerMonth);
         void computeEmpWage();
         int getTotalWage(string company);
    }
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonths;
        public int totalEmpWage;
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonths)
        {

            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonths = maxHoursPerMonths;
            this.totalEmpWage = 0;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }


        public string toString()
        {
            return "Total Emp Wage for company :" + this.company + " is: " + this.totalEmpWage;
        }
    }
    public class EmpWageBuilder:IComputEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonths)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonths);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }

        public void computeEmpWage()
        {
            foreach(CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEMPwage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString()); 
            }
        }
        private int computeEMPwage(CompanyEmpWage companyEmpWage)
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //computation
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonths && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
            return totalEmpHrs * companyEmpWage.empRatePerHour;

        }
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance",10,4,20 );
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Wage For Dmart company" + empWageBuilder.getTotalWage("Dmart"));
            Console.WriteLine("Total Wage For Reliance company" + empWageBuilder.getTotalWage("Relianc"));


        }
    }
}
