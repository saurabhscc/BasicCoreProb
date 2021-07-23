using System;

namespace BasicCoreProb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flipped The Coin For Head Or Tail Percentage!");
            Console.WriteLine("1 For: Flip a Coin Head and Tail. ");
            Console.WriteLine("2 For: Select Value is Leap Year Or not");
            int selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    //FLIP COIN
                    FlipCoin FlipCoin = new FlipCoin();
                    FlipCoin.CheckHeadTailPercentage();
                    break;
                case 2:
                    //CheckLeapYearOrNot
                    LeapYear LeapYearOrNot = new LeapYear();
                    LeapYearOrNot.Leap_Year();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Select in Between 1 to 2");
                    break;
            }
            Console.ReadLine();
        }
    }
}


