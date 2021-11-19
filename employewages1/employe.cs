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
                Random random = new Random();
                //computation
                int empcheck = random.Next(0, 2);
                if (empcheck == IS_FILL_TIME)
                {
                    Console.WriteLine("Employ is present");
                }
                else
                {
                    Console.WriteLine("Employe is absent");
                }

            }
        }
    }