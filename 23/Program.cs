using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            int nToothpicksleft;
            int nUserPick;
            int nCpuPick;
            string strPlayAgain;

            do
            {
                nToothpicksleft = 23;

                Console.WriteLine("~~~~~~~ Game of 23 ~~~~~~~");
                Console.WriteLine("Pick either 1, 2 or 3 toothpicks from the pile.");
                Console.WriteLine("I will pick after you.  last unintelligent entity to draw a toothpick looses.");

                // display toothpicks
                do
                {


                    for (int n = 0; n < nToothpicksleft; n++)
                    {
                        if (n % 4 == 0)
                        {
                            Console.Write("/");
                        }
                        else if (n % 4 == 1)
                        {
                            Console.Write("|");
                        }
                        else if (n % 4 == 2)
                        {
                            Console.Write("__");
                        }
                        else
                        {
                            Console.Write("\\");
                        }
                    }

                    Console.WriteLine("<--" + nToothpicksleft + "toothpicks left. \n");

                    //promp user
                    Console.WriteLine("Pick 1,2 or 3 toothpicks:");
                    while (!int.TryParse(Console.ReadLine(), out nUserPick) || (nUserPick < 1 || nUserPick > 3))
                    {
                        Console.WriteLine("Not a valid entry. Must be a number from 1 to 3");
                        Console.WriteLine("Pick 1, 2 or 3 toothpicks: ");
                    }
                    nToothpicksleft -= nUserPick;
                    // computer's choice
                    if (nToothpicksleft > 4)
                    {
                        nCpuPick = 4 - nUserPick;
                        nToothpicksleft -= nCpuPick;
                        Console.WriteLine("I pick " + nCpuPick);
                    }
                    else if (nToothpicksleft > 1 && nToothpicksleft < 4)
                    {
                        nCpuPick = nToothpicksleft - 1;
                        nToothpicksleft -= nCpuPick;
                        Console.WriteLine("I pick " + nCpuPick + "and I win!");
                    }
                    else if (nToothpicksleft == 1)
                    {
                        nToothpicksleft -= 1;
                        Console.WriteLine(" nice work... you win...");
                    }
                } while (nToothpicksleft > 1);
                Console.WriteLine("Play Again? Y for yes: ");
                strPlayAgain = Console.ReadLine();
            } while (strPlayAgain == "Y");
        }
    }
}
