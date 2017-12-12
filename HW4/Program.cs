using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLargest;
            int nSmallest;
            int nCurrent;
            string strEntry;

            Console.WriteLine("Enter an Integer");
            nLargest = nSmallest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another Integer or Q to Quit");
            strEntry = Console.ReadLine();

            while (strEntry != "Q")
            {
                nCurrent = Convert.ToInt32(strEntry);
                Console.WriteLine("Enter another Integer or Q to Quit");
                strEntry = Console.ReadLine();

                if(nCurrent > nLargest)
                {
                    nLargest = nCurrent;
                }
                else if (nCurrent < nSmallest)
                {
                    nSmallest = nCurrent;
                
                }
                Console.WriteLine("Enter another Integer or Q to Quit");
                strEntry = Console.ReadLine();
            }
            Console.WriteLine("The Largest value you entered was " + nLargest + ".");
            Console.WriteLine("The smallest Value you entered was " + nSmallest + ".");

            Console.ReadLine();
        }
    }
}
