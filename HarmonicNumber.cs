using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProb
{
    class HarmonicNumber
    {
        public int num = 0;
        double Result = 0.0;
        public void CalcHarmonicSeries()
        {

            Console.Write("Input the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Result += 1 / (float)i;
                Console.Write("1/{0} + ", i); 
            }
            Console.WriteLine($"= {Result}");
            Console.ReadLine();
        }
    }
}
