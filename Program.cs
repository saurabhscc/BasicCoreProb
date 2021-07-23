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
            Console.WriteLine("6 For: Select Quotient and Remainder");
            Console.WriteLine("7 For: Select Swap the Numbers");
            Console.WriteLine("8 For :Select Even and Odd number");
            Console.WriteLine("9 For: Select Alphabet Vowel");
            Console.WriteLine("10 For: Select Greatest number among Three");
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
                case 6:
                    //  quotient remainder
                    QuotientRemainder QuesRem = new QuotientRemainder();
                    QuesRem.QuotientReminder();
                    break;
                case 7:
                    //Swap 2 number
                    SwapNumbers SwapTwoNo = new SwapNumbers();
                    SwapTwoNo.SwapTwoNumber();
                    break;
                case 8:
                    // Vowel or Not
                    VowelOrConso VowelNot = new VowelOrConso();
                    VowelNot.VowelCheck();
                    break;
                case 9:
                    //Greater Or Smaller
                    GreatestOrSmaller checkgreaterOrSmallest = new GreatestOrSmaller();
                    checkgreaterOrSmallest.GreaterOrSmaller();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Select in Between 1 to 9");
                    break;
            }
            Console.ReadLine();
        }
    }
}


