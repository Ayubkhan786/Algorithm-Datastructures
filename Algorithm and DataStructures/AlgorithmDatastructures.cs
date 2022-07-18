using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_and_DataStructures
{
    public class AlgorithmDataStructures
    {

        public void DisplayPrime()
        {

            int p = 1000;     // total value to be found
            bool n = true;       // Lets assume n = prime number 
            int i, j;
            for (i = 2; i <= p; i++)
            {
                for (j = 2; j <= p; j++)
                    if (i != j && i % j == 0)        //If both are not equal and the modulus is zero then
                    {
                        n = false;                   // It's not a prime Number
                        break;
                    }

                if (n)
                {
                    Console.WriteLine("\n" + i);           //Remaining are Prime Numbers 
                }
                n = true;

            }
            Console.ReadKey();                   // It is used to Avoid Continous Loop/after execution it waits
        }
        public bool FindPalindrome()
        {
            int val = 121,num = 0;
                while (val > 0)
                {
                   num =num * 10 + val % 10;
                    val = val / 10;
                }
                if (num == val)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        public void FindAnagram(String fix, String s)
        {
            int l = s.Length;
            if (l == 1)
            {
                Console.WriteLine(fix + s);
            }
            else
            {
                for (int i = 0; i < l; i++)
                {
                    char[] mychar = s.ToCharArray();
                    char c = mychar[i];
                    String st = s.Substring(0, i) + s.Substring(i + 1);
                    FindAnagram(fix + c, st);
                }
            }
        }
    }
}
