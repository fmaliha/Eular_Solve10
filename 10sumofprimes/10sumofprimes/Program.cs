using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10sumofprimes
{
    class Program
    {
        static List<long> Prime = new List<long>();
        static long max_num = 2000000;

        static void Main(string[] args)
        {
            long curr_num = 2;
            long sum_of_primes = 0;


            Prime.Add(curr_num);     //adding the first prime to list as the only even prime num and starting num
            sum_of_primes += curr_num;
            curr_num++;          //as the prime next  to 2 is 3 


            do
            {
              if(IsPrime(curr_num))
                {
                    Prime.Add(curr_num);
                    sum_of_primes += curr_num;
                   
                }
              curr_num += 2;    //// prime numbers are 2 apart 3,5,7 

            } while (curr_num < max_num);
            
           

        Console.WriteLine(sum_of_primes);
        Console.ReadKey();
        }

        static bool IsPrime(long currnum)
        {
            foreach (var num in Prime)
            {
                if (num * num > currnum)     // comparing current value wih prev primes listed as it needs to be lesser than prev prime^2
                {
                    break;
                }

                else if (currnum % num == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
