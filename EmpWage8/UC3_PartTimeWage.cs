using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage8
{
    internal class UC3_PartTimeWage
    {
        public static void prtTimeWge()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(1, 3);

            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Emp is Present for full time");
            }
            else if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("Emp is Present for part time");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Emp is Absent");
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Daily wage is " + empWage);
        }
    }
}

