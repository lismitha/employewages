using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EmployeCase4
{
    public const int is_Full_Time = 1;
    public const int is_Part_Time = 2;

    public const int ratePerHrs = 20;


    public static void Main(string[] args)
    {
        int empWage = 0;
        int empHrs = 0;
        // string typeOfEmployye = "";

        Random employee = new Random();
        int randomInput = employee.Next(0,3);

        switch (randomInput)
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

        empWage = ratePerHrs * empHrs;
        Console.WriteLine("Employee wage per day: " + empHrs);
        Console.ReadLine();
    }
}
