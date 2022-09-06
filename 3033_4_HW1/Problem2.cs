using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3033_4_HW1
{
    public class Problem2
    {
        public static void Exams3()
        {
            double sum = 0;
            for(int i =1;i<=3 ;i++ )
            {
                Console.Write($"Please input Exam {i} grade:");
                double examgrade = Convert.ToDouble(Console.ReadLine());
                sum = sum + examgrade;
            }
            double average = sum / 3;
            Console.WriteLine($"The average grade percentage is {average:F2}%");
        }
    }
}
