using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage8
{
    internal class UC4_SwitchCase
    {
        public static void Switch()
        {
            const int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(1, 3);

            switch (empCheck)
            {
                case 1:
                    empHrs = 8;
                    Console.WriteLine("Emp is Present for full time");
                    break;
                case 2:
                    empHrs = 4;
                    Console.WriteLine("Emp is Present for part time");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Emp is Absent");
                    break;
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Daily wage is " + empWage);
        }
    }
}


