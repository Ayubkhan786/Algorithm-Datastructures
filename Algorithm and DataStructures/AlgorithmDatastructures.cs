﻿using System;
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
    }
}