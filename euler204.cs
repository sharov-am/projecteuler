using System;
using System.Collections.Generic;
using C = System.Console;
using M = System.Math;
using System.Linq;
namespace euler
{
        class euler204
        {

            static ulong k = 0;
            const ulong D = 1000000000;
            static List<int> lPrimes = new List<int>();
            public static void Primes()
            {
                for(int checkValue = 2; checkValue <= 100; checkValue++)
                {
                    if(IsPrime(checkValue))
                    {
                        lPrimes.Add(checkValue);

                    }
                }

            }

            private static bool IsPrime(long checkValue)
            {
                bool isPrime = true;

                foreach(long prime in lPrimes)
                {
                    if((checkValue % prime) == 0 && prime <= Math.Sqrt(checkValue))
                    {
                        isPrime = false;
                        break;
                    }
                }

                return isPrime;
            }





            public static void GetHammingNumbers(ulong initial, int z)
            {

                foreach(var t in lPrimes.Where((x) => x >= z))
                {

                    if((ulong)t * initial <= D)
                    {
                        k++;
                        GetHammingNumbers((ulong)t * initial, t);
                    }

                }

            }
            public static void Main()
            {
                DateTime b = DateTime.Now;
                Console.WriteLine(DateTime.Now);
                Primes();
                GetHammingNumbers(1, 1);
                DateTime e = DateTime.Now;
                Console.WriteLine(e - b);
                Console.WriteLine("  Result is: {0}", ++k);

                Console.ReadKey();



            }
        }
    }
