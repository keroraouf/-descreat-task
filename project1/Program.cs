using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)

         
        { 
                int z, i, k, x, y;

                Console.Write("\n\n");
                Console.Write("Find the prime numbers within a range of numbers:\n");
                Console.Write("---------------------------------------------------");
                Console.Write("\n\n");

                Console.Write("Input starting number of range: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input ending number of range : ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("The prime numbers between {0} and {1} are : \n", x, y);

                for (z = x; z <= y; z++)
                {
                    k = 0;

                    for (i = 2; i <= z / 2; i++)
                    {
                        if (z % i == 0)
                        {
                            k++;
                            break;
                        }
                    }

                    if (k == 0 && z != 1)
                        Console.Write("{0} ", z);
                }
                Console.Write("\n");
                    Console.ReadLine();
            }
        }
        

            }
