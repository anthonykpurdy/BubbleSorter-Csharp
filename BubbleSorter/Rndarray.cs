using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorter
{
    public class Rndarray
    {
        public void Makerand(int[] numbers)
        {
            Random randNum = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                int rndint = randNum.Next(0, 99);
                
                if (numbers.Contains(rndint)) { // checking for duplicates
                    i--;
                }
                else{
                    numbers[i] = rndint;
                }
               
            }


        }
    }
}
