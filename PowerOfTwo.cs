using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProb
{
    class PowerOfTwo
    {
        public int num = 0;
        public void CalculationOfPower()
        {

            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = num * 2; 
            Console.WriteLine(result);
            Console.ReadLine();
        }

        internal object CalcuOfPower()
        {
            throw new NotImplementedException();
        }
    }
}
