using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTheOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            Console.ReadKey();
        }

        public static int[] SortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] % 2 == 1 && array[j] % 2 == 1 && array[i] > array[j])
                    {
                        var por = array[i];
                        array[i] = array[j];
                        array[j] = por;
                    }
                }
            }

            return array;
        }

        public static int[] SortArray1(int[] array)
        {
            List<int> odd = new List<int>();

            foreach (var number in array)
            {
                if (number % 2 != 0)
                    odd.Add(number);
            }
            int[] oddAr = odd.ToArray();
            Array.Sort(oddAr);


            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    array[i] = oddAr[j];
                    j++;
                }
            }
            return array;
        }

    }
}
