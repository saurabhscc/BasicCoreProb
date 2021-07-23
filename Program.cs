using System;

namespace BasicCoreProb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("1 For: Flip a Coin Head and Tail. ");
            Console.WriteLine("2 For: Select Value is Leap Year Or not");
            Console.WriteLine("3 For: Select Power of 2 Number");
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
                case 3:
                    //Power Of 2
                    PowerOfTwo CalPower = new PowerOfTwo();
                    object p = CalPower.CalcuOfPower();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Select in Between 1 to 3");
                    break;
            }
            Console.ReadLine();
        }
    }
}


