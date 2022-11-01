using System;
using System.Linq.Expressions;

namespace EmpWage8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num == 0)
            {
                Console.WriteLine();
                Console.WriteLine("**************************************");
                Console.WriteLine("Welcome to Employee Wage Computation");
                Console.WriteLine();

                Console.WriteLine("Select Option\n1.Employee Attendace \n2.Daily Wage \n3.Part Time Wage \n4.Switch Case \n5.Monthly Wage \n6.100 Hours OR 20 Days \n7.Exit");
                int opt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (opt)
                {
                    case 1:
                        UC1_PresentAbsent.empCheck();
                        break;
                    case 2:
                        UC2_DailyWage.dailyWge();
                        break;
                    case 3:
                        UC3_PartTimeWage.prtTimeWge();
                        break;
                    case 4:
                        UC4_SwitchCase.Switch();
                        break;
                    case 5:
                        UC5_WageForMonth.monthlyWage();
                        break;
                    case 6:
                        UC_6WorkingHoursCondn.wrkingHrs();
                        break;
                    case 7:
                        num++;
                        break;

                    default:
                        Console.WriteLine("Invaild Choice");
                        break;
                }
            }


        }
    }
}
