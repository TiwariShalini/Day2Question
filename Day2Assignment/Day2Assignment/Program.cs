using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int num, i, ctr, stno, enno;

             
                Console.WriteLine("Find the prime numbers within a range of numbers:");
                Console.WriteLine("Input min number: ");
                stno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input max number: ");
                enno = Convert.ToInt32(Console.ReadLine());
                Console.Write("The prime numbers between {0} and {1} are : \n", stno, enno);

                for (num = stno; num <= enno; num++)
                {
                    ctr = 0;

                    for (i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            ctr++;
                            break;
                        }
                    }

                    if (ctr == 0 && num != 1)
                        Console.WriteLine("{0} ", num);
                }
               
            }
        }
    }


