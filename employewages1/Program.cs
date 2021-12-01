using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employewages1
{
    public class Employewages
    {
        public const int is_Full_Time = 1;
        public const int is_Part_Time = 2;

        private string company;
        private int empRatePerHr;
        private int numOfWorkingDays;
        private int maxHrPerMonth;
        private int totalEmpWage;

        public Employewages(string company, int empRatePerHr, int numOfWorkingDays, int maxHrPerMonth)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrPerMonth = maxHrPerMonth;
        }
        public void ComputeWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //computation
            while (totalEmpHrs <= this.maxHrPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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
                    totalEmpHrs += empHrs;
                    Console.WriteLine("days#:" + totalWorkingDays + "  Employe Hours:" + empHrs);
                
            
            }
                 totalEmpWage = totalEmpHrs * this.empRatePerHr;
                Console.WriteLine("Totall Employe wage per company:" + company + " is:" +totalEmpWage);
        }
              public string tostring()
              {
                return "totall empwage for company :" + company + "is" + this.totalEmpWage;
              }

        class program
        {
            static void main(string[] args)
            {
                Employewages vedantu = new Employewages("vedantu", 21, 2, 10);
                Employewages byjus = new Employewages("byjus", 11, 5, 20);
                vedantu.ComputeWage();
                Console.WriteLine(vedantu.ToString());
                byjus.ComputeWage();
                Console.WriteLine(byjus.ToString());
            }
        } 
    }
}
