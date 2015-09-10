using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumFirstThousandPrimes());
            Console.ReadLine();
        }

        static long SumFirstThousandPrimes()
        {
            var primeCtr = 0;
            var number = 1;
            var sum = 0;
            bool isPrime;

            do
            {
                if (number == 1)
                {
                    isPrime = false;
                }
                else
                {
                    isPrime = true;
                    
                    for (var divisor = 1; divisor <= number / 2; divisor++)
                    {
                        if (number % divisor == 0 && divisor != 1)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    sum += number;
                    primeCtr++;
                }

                number++;
            } while (primeCtr < 1000);

            return sum;
        }
    }
}
