using System;
using System.Collections.Generic;
using C = System.Console;
using M = System.Math;
using System.Linq;
namespace euler
{
    class euler205
    {
        List<int> pyramidicalsum = new List<int>() ;
        List<int> cubicsum = new List<int> ();
        static int pyrsum = 0;
        static int cubsum = 0;
        public  void FirstSum(int pyramidalnumber)
        {
            if(pyramidalnumber < 10)
            {
                for(int j = 1; j < 5; j++)
                {
                    pyrsum += j;
                    FirstSum(++pyramidalnumber);
                    pyramidalnumber--;
                    if(pyramidalnumber == 9)
                    {
                        this.pyramidicalsum.Add(pyrsum);

                    }
                    pyrsum -= j;
                }
            }
            
        }

        public  void SecondSum(int cubenumber)
        {
            if(cubenumber < 7)
            {
                for(int j = 1; j < 7; j++)
                {
                    cubsum += j;
                    SecondSum(++cubenumber);
                    cubenumber--;
                    if(cubenumber == 6)
                    {
                        this.cubicsum.Add(cubsum);
                    }
                    cubsum -= j;
                }
            }



        }

        
        
        
        public static void Main()
        {
            DateTime begin = DateTime.Now;
            euler205 e = new euler205();
            double result = 0;
            double pl1 = 0,pl2 = 0;
            e.FirstSum(1);
            e.SecondSum(1);
            for(int t = 9; t <= 36; t++)
            {
               for(int j = 6; j<=36;j++)
               {
                   if(t > j)
                   {
                       pl1 = (double)e.pyramidicalsum.Where(x=>x==t).Count()/(double)e.pyramidicalsum.Count;
                       pl2 = (double)e.cubicsum.Where(x=>x==j).Count()/(double)e.cubicsum.Count;
                       result += pl1 * pl2;

                   }
               }
            }

            
            Console.WriteLine(result);
            DateTime end = DateTime.Now;
            Console.WriteLine(end - begin);
            Console.Read();
        }
    }
}