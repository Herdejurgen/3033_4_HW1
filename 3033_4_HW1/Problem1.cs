using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3033_4_HW1
{
    public class Problem1
    {
        public static void CogsAndGears()
        {
            double cog = 79.99;
            double gear = 250;

            double floormarkup = 0.15;
            double bulkmarkup = 0.125;
            double salestax = 0.089;
            double markup;

            Console.Write("Please input the number of cogs:");
            int cognum = Convert.ToInt16(Console.ReadLine());

            Console.Write("Please input the number of gears:");
            int gearnum = Convert.ToInt16(Console.ReadLine());

            if (gearnum + cognum >= 16)
            {
                markup = bulkmarkup;
            }
            else if (gearnum >= 10 || cognum >= 10)
            {
                markup = bulkmarkup;
            }
            else { markup = floormarkup; }

            double subtotal = cog * cognum + gear * gearnum;
            double totalmarkup = markup * subtotal;
            double totalbulkmarkup = bulkmarkup * subtotal;
            double totalfloormarkup = floormarkup * subtotal;
            double discount = -(totalmarkup - totalfloormarkup);
            double total = totalmarkup + subtotal;
            double totaltax = total * salestax;
            double grandtotal = total + totaltax;
            Console.WriteLine("Recipt");
            Console.WriteLine($"Total cost: {total:C2}");
            Console.WriteLine($"Discount amount: {discount:C2}");
            Console.WriteLine($"Sales tax: {totaltax:C2}");
            Console.WriteLine($"Grand total: {grandtotal:C2}");
        }
    }
}
