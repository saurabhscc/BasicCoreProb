using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProb
{
    class FlipCoin
    {
        public int FlipHeads = 0;
        public int FlipTails = 0;
        const double ConstantDec = 0.5;


        public void CheckHeadTailPercentage()
        {
            Console.WriteLine("Enter How many times you want to Flip a Coin : ");
            int FlipNumber = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int coinFlip = 1; coinFlip <= FlipNumber; coinFlip++)
            {

                //Check Random 
                double CheckFlipCoin = random.Next(0, 2);
                if (CheckFlipCoin < ConstantDec)
                {
                    //If it is head
                    Console.WriteLine("Result: Is Head");
                    FlipHeads++;
                }
                else
                {
                    //If it is tail 
                    Console.WriteLine("Result: Is Tail");
                    FlipTails++;
                }
            }
            //Calculating Percentage
            double CheckPercentageTail = (FlipHeads * 100) / FlipNumber;
            double CheckPercentageHead = (FlipTails * 100) / FlipNumber;
            Console.WriteLine("percentage of TAILS and HEADS is : " + CheckPercentageTail + " " + CheckPercentageHead);
            Console.ReadKey();
        }
    }
}
