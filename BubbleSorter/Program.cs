using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[25];
            Rndarray Rndarray = new Rndarray();
            BubbleSort BubbleSort = new BubbleSort();

            Rndarray.Makerand(numbers); // making random array

            System.Console.WriteLine("Unsorted random array: ");
            printnum(numbers);

            //Array.Sort(numbers); // this would sort the array, but we are not using it as i have to make a bubble sort method
            BubbleSort.Sort(numbers);
            System.Console.WriteLine("\nSorted random array: ");
            printnum(numbers);

            System.Console.ReadLine();

        }

        static void printnum(int[] numbers)
        {
            Console.Write("\n{");
            for (int i = 0; i < numbers.Length; ++i)
            {
                Console.Write($" {numbers[i]}");
            }
            Console.Write("}\n");
        }
        

    }
}
