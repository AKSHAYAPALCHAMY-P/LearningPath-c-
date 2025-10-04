using System;

namespace FibonacciSeries
{
    class EvenfibonacciSeries
    {
        public static void Main(string[] args)
        {
            int nlimit = 4000000;
            int n1 = 0, n2 = 1;
            int evenSum = 0;

            while(evenSum < nlimit)
            {
                int n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                if(n3 % 2 == 0)
                {
                    evenSum += n3;
                }

                Console.WriteLine(evenSum);
            }
            
        }
    }
}