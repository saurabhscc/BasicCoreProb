using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProb
{
    class VowelOrConso
    {
        public char Alphabet;
        public void VowelCheck()
        {
            Console.Write("Check whether the input  Alphabet (A-Z or a-z) is a vowel or not:\n"); 
            Alphabet = Convert.ToChar(Console.ReadLine()); 
            if (Alphabet == 'a' | Alphabet == 'A' | Alphabet == 'i' | Alphabet == 'I' | Alphabet == 'U' | Alphabet == 'u' | Alphabet == 'E' | Alphabet == 'e' | Alphabet == 'O' | Alphabet == 'o')//check
                Console.WriteLine("Given" + " " + Alphabet + " is a Vowel"); 
            else
                Console.WriteLine("Given" + " " + Alphabet + " is a Consonant"); 
        }
    }
}

