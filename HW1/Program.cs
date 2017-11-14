using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
           
            double dblNum1, dblNum2;
            double dblSum;
            double dblProduct;
            double dblDifference;
            double dblQuotiont;

            //promot for name and receive
            Console.WriteLine("~This program calculates the sum, product, difference and quotient of numbers you give~");
            Console.WriteLine("<----------------------------------------------------------->");
            Console.WriteLine("");//we will learn other ways to do this in console programs

           
            //prompt for hits, walks and at bats
            Console.WriteLine("Enter your first number: "); 
            dblNum1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            dblNum2 = Convert.ToInt32(Console.ReadLine());

            //calculation
            dblSum= dblNum1 + dblNum2;
            dblDifference= dblNum1 - dblNum2;
            dblProduct= dblNum1 * dblNum2;
            dblQuotiont= dblNum1 / dblNum2;

            Console.WriteLine("The sum is: " + dblSum + "  The Difference is: " + dblDifference + "  The Product is: " + dblProduct+ "  The Quotiont is: " + dblQuotiont);
            Console.ReadLine();
        }
    }
}
