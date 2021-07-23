using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProb
{
    class LeapYear
    {
        public void Leap_Year()
        {
            Console.WriteLine("Enter to Year(YYYY) to Check if it is Leap Year or Not: ");
            int Checkyear = Convert.ToInt32(Console.ReadLine());

            //checking if year is % of 400 or %4 then its a leap year if %100 its not a leap year
            if ((Checkyear % 400 == 0) || (Checkyear % 4 == 0 && Checkyear % 100 != 0))
                Console.WriteLine(Checkyear + " is a Leap Year");
            else
                Console.WriteLine(Checkyear + " is not a Leap Year");
        }
    }
}
