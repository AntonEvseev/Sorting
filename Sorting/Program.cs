using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[100];
            //заполняем массив случайными числами
            Random rd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rd.Next(1, 5);
            }
            System.Console.WriteLine("The array before sorting:");
            foreach (double x in arr)
            {
                System.Console.Write(x);
            }
            //сортировка
            QuickSorting.sorting(arr, 0, arr.Length - 1);
            System.Console.WriteLine("\nThe array after sorting:");
            foreach (double x in arr)
            {
                System.Console.Write(x);
            }
            System.Console.WriteLine("\nPress the <Enter> key");
            System.Console.ReadLine();
        }
        class QuickSorting
        {
            public static void sorting(double[] arr, long first, long last)
            {
                double p = arr[(last - first) / 2 + first];
                double temp;
                long i = first, j = last;
                while (i <= j)
                {
                    while (arr[i] < p && i <= last) ++i;
                    while (arr[j] > p && j >= first) --j;
                    if (i <= j)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        ++i; --j;
                    }
                }
                if (j > first) sorting(arr, first, j);
                if (i < last) sorting(arr, i, last);
            }
        }
    }
}
