using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage8
{
    internal class UC_6WorkingHoursCondn
    {
        public static void wrkingHrs()
        {
            const int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int dayCount = 0;
            int totalHrs = 0;

            do
            {
                dayCount++;
                Random random = new Random();
                int empCheck = random.Next(1, 4);

                switch (empCheck)
                {
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalHrs += empHrs;
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage; //totalempwage = totalempwage + empwage
                //Console.WriteLine("Daily emp wage is {0} total emp wage {1}", empWage, totalEmpWage);
            } while (dayCount < 20 && totalHrs < 100);
            Console.WriteLine();
            Console.WriteLine("Total Emp Wage is :" + totalEmpWage);
            Console.WriteLine("Total no. of hours work done by Emp is :" + totalHrs);
            Console.WriteLine("Total Number of Days : " + dayCount);

        }
    }
}
   