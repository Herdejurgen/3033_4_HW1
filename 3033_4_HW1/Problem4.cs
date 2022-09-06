using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3033_4_HW1
{
    public class Problem4
    {
        public static double LineValueForY(double m,double x, double b)
        {
            double y = m * x + b;
            return y;
        }
        public static int Factorial(int input)
        {
            int j = 1;
            for(int i = input;i>0 ;i-- )
            {
                j = i * j;
            }
            return j;
        }
    }
}
