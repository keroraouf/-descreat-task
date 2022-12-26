using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{ 
      /*Perfect number is a positive number which sum of all positive divisors excluding*/
      /*that number is equal to that number. For example 6 is perfect number since divisor of 6 are 1, 2 and 3.*/
      /*Sum of its divisor is 1 + 2+ 3 = 6*/
public class Exercise28
        {
            public static void Main()
            {
                int x, z, sum;
                int mx, my;

                Console.Write("\n\n");
                Console.Write("Find perfect numbers within a given number of range:\n");
                Console.Write("------------------------------------------------------");
                Console.Write("\n\n");

                Console.Write("Input the starting range or number : ");
                mx = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the ending range of number : ");
                my = Convert.ToInt32(Console.ReadLine());
                Console.Write("The Perfect numbers within the given range : ");
                for (x = mx; x <= my; x++)
                {
                    z = 1;
                    sum = 0;
                    while (z < x)
                    {
                        if (x % z == 0)
                            sum = sum + z;
                        z++;
                    }
                    if (sum == x)
                        Console.Write("{0} ", x);
                }
                Console.Write("\n");
            Console.ReadLine();
            }

        }
    }

