using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class Employeecase7
    {
        public const int is_Full_Time = 1;
        public const int is_Part_Time = 2;

        public static int computeEmpwage(string company,int empRatePerHr,int numOfWorkinDays,int maxHrPerMonth)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 1;

            Random employee = new Random();
            while (totalEmpHrs <= maxHrPerMonth && totalWorkingDays <= numOfWorkinDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3); ;

                switch (empCheck)
                {
                    case is_Full_Time:
                        empHrs = 8;
                        break;

                    case is_Part_Time:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                     totalEmpHrs = totalEmpHrs += empHrs;
                     Console.WriteLine("days#:" + totalWorkingDays + "  Employe Hours:" + empHrs);
            }
                     int TotalEmpWage = totalEmpHrs * empRatePerHr;
               
                     Console.WriteLine("Totall Employe wage per company:" + company + " is:" +TotalEmpWage);
                     return TotalEmpWage;     
        }
           static void Main(string[] args)
           {
                computeEmpwage("vedantu", 21,2,10);
                computeEmpwage("byjus", 11, 5, 20);
           }
    }
}
