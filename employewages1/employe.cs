using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employewages1
{
    internal class employe
    {
        static void Main(string[] args)
        {
            //constants
            int IS_FILL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            //Variable
            int empHrs = 0;
            int empwages = 0;
            Random random = new Random();
            //computation
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_FILL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empwages = empwages * EMP_RATE_PER_HOUR;

            Console.WriteLine("emp wages: + emp wages");
       
            }
        }
    }