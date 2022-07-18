using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_and_DataStructures
{
    public class AlgorithmDataStructures
    {

        public void Insertion_Sort(string msg)
        {
            //To Excecute the Existing Arrays
            string[] A = msg.Split(' ');
            for (int i = 1; i < (A.Length) - 1; i++)
            {
                int j = i;
                string B = A[i];


                while (A[j - 1].CompareTo(B) > 0)
                {
                    A[j] = A[j - 1];
                    j--;
                    if (j == 0)
                    {
                        break;
                    }
                }
                A[j] = B;
            }

            //To Excecute the new set of Arrays
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("\n", A[i] + " ");
            }
        }
    }
}
