using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage8
{
    internal class UC1_PresentAbsent
    {
        public static void empCheck()
        {
            Random random = new Random();
            int emp = random.Next(0, 2);
            if (emp == 0)
            {
                Console.WriteLine("Employee is Present.");
            }
            else
            {
                Console.WriteLine("Employee is Absent.");
            }

        }
    }
}