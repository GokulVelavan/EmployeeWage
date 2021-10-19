using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
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
}
