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
            Sorting(arr, 0, arr.Length - 1);
            System.Console.WriteLine("\nThe array after sorting:");
            foreach (double x in arr)
            {
                System.Console.Write(x);
            }
            System.Console.WriteLine("\nPress the <Enter> key");
            System.Console.ReadLine();
        }
        public static void Sorting(double[] arr, long element1, long element2)
        {
            double p = arr[(element2 - element1) / 2 + element1];
            double temp;
            long i = element1;
            long j = element2;
            while (i <= j)
            {
                while (arr[i] < p && i <= element2)
                {
                    ++i;
                }
                while (arr[j] > p && j >= element1)
                {
                    --j;
                }
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i;
                    --j;
                }
             }
            if (j > element1)
                {
                    Sorting(arr, element1, j);
                }
            if (i < element2)
                {
                    Sorting(arr, i, element2);
                }
            }
        }
   }

