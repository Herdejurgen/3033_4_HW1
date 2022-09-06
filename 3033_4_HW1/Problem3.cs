using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3033_4_HW1
{
    public class Problem3
    {
        public static void Exams()
        {
            string input = "yes";
            int counter = 0;
            double sum = 0;
            while (input == "yes")
            {
                counter++;
                Console.Write($"Please input exam {counter} grade:");
                double grade = Convert.ToDouble(Console.ReadLine());
                sum = sum + grade;
                Console.Write("Would you like to enter another grade?");
                input = Console.ReadLine();
                input = input.ToLower();
            }
            Console.WriteLine($"The number of exams is {counter}.");
            double average = sum / counter;
            Console.WriteLine($"The average grade percentage is {average:F2}%");
        }
    }
}
