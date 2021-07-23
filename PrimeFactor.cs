using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProb
{
    class PrimeFactor
    {
        public int j = 0;
        public int num = 0;
        public int factorial = 1;
        public void CalcSFactorialSeries()
        {
            Console.Write("Calculate the factorial of a given number:"); 
            num = Convert.ToInt32(Console.ReadLine());
            for (j = 1; j <= num; j++) 
                factorial *= j; 
            Console.Write("The Factorial of {0} is: {1}\n", num, factorial); 
        }
    }
}
