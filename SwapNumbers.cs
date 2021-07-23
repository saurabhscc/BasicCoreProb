using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProb
{
    class SwapNumbers
    {
        public int NumberOne;
        public int NumberTwo;
        public int temp = 0;
        public void SwapTwoNumber()
        {

            Console.Write("\nInput the First Number : "); 
            NumberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInput the Second Number : "); 
            NumberTwo = Convert.ToInt32(Console.ReadLine());
            temp = NumberOne; 
            NumberOne = NumberTwo; 
            NumberTwo = temp; 
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + NumberOne); 
            Console.Write("\nSecond Number : " + NumberTwo);
            Console.Read();
        }
    }
}
