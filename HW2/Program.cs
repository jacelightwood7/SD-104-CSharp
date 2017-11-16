using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nlastNum = 1;
            int nnextToLastNum = 1;
            int fibNum;
            int currentNum=0;
            //promp user

            Console.WriteLine("enter whitch Fibonacci number you would like to see");
            fibNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < fibNum; i++)
            {
                currentNum = nlastNum + nnextToLastNum;
                nnextToLastNum = nlastNum;
                nlastNum = currentNum;

                
            }
            Console.WriteLine("The fibonacci number you asked to see is: " + nnextToLastNum);
            Console.ReadLine();

        }
    }
}
