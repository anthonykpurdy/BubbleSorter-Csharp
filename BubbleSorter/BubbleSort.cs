using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorter
{
    internal class BubbleSort
    {
        public void Sort(int[] numbers) 
        { 
            int size = numbers.Length;

            for(int i = 0; i < size - 1; i++)
            {
                for(int j = 0; j < size - i - 1; j++) 
                {
                    if (numbers[j] > numbers[j + 1]) 
                    { 
                        int temp = numbers[j];
                        numbers[j] = numbers[j +1];
                        numbers[j + 1] = temp;
                    }
                }
            }

        }
    }
}
