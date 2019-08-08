using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Usenko._01
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckQuickSort();
        }

        static void CheckQuickSort()
        {
            var arrayForCheck1 = new int[] { 9, 184, 1, 52, 461, 6, 265, 26, 7, 1, 5, 8, 435, 23, 6, 72, 34, 62, 345, 234, 62 };
            var arrayForCheck2 = new int[] { -9, 184, 1, 52, -461, 6, 265, 26, -7, 1, 5, 8, 435, -23, 6, 72, 34, -62, 345, 234, 62 };

            Console.WriteLine("Quick Sort:");
            Console.WriteLine("Input 1: ");
            for (int i = 0; i < arrayForCheck1.Length; i++)
                Console.Write(arrayForCheck1[i] + " ");
            Console.WriteLine("");
            Console.WriteLine("Output 1: ");
            arrayForCheck1 = QuickSortMethod.QuickSort(arrayForCheck1);
            for (int i = 0; i < arrayForCheck1.Length; i++)
                Console.Write(arrayForCheck1[i] + " ");

            Console.WriteLine("");

            Console.WriteLine("Input 2: ");
            for (int i = 0; i < arrayForCheck2.Length; i++)
                Console.Write(arrayForCheck2[i] + " ");
            Console.WriteLine("");
            Console.WriteLine("Output 2: ");
            arrayForCheck2 = QuickSortMethod.QuickSort(arrayForCheck2);
            for (int i = 0; i < arrayForCheck2.Length; i++)
                Console.Write(arrayForCheck2[i] + " ");

            Console.ReadKey();
        }
    }
}
