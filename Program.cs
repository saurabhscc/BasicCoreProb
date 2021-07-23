using System;

namespace BasicCoreProb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("1 For: Flip a Coin Head and Tail. ");
            Console.WriteLine("2 For: Select Value is Leap Year Or not");
            Console.WriteLine("3 For: Select Power of 2 Number");
            Console.WriteLine("4 For: Select the Harmonic Number");
            Console.WriteLine("5 For: Select Factors of number");
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
                case 4:
                    //Harmonic Series
                    HarmonicNumber CalculateHarmonicNumber = new HarmonicNumber();
                    CalculateHarmonicNumber.CalcHarmonicSeries();
                    break;
                case 5:
                    //Prime Factor
                    PrimeFactor PrimeFactor = new PrimeFactor();
                    PrimeFactor.CalcSFactorialSeries();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Select in Between 1 to 5");
                    break;
            }
            Console.ReadLine();
        }
    }
}


