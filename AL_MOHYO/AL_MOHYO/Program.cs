﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL_MOHYO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] MOHY = { 5, 6, 8, 67, 69, 79, 88 };
            Console.WriteLine("😁enter a key number😁");
            int key = int.Parse(Console.ReadLine());
            int index = Binary_search(MOHY, key, 0, MOHY.Length);
            Console.WriteLine("index  " + key + " = " + index);

           //******************************************************************

            int[] arr = { 5, 8, 23, 55, 64, 65, 88, };
            Console.WriteLine("😁enter a key number😁");
            int key1 = int.Parse(Console.ReadLine());
            int index1 = Binary(arr, key1);
            Console.WriteLine("index  " + key1 + " = " + index1);
        }
        static int Binary_search (int[] array, int key, int low, int high)
        {

            if (low > high)
                return -1;

            int mid = (low + high) / 2;

            if (array[mid] == key)
                return mid;
            else if (array[mid] < key)
                return Binary_search(array, key, mid + 1, high);
            else
                return Binary_search(array, key, low, mid - 1);

        }
        static int Binary(int[] arr, int key)
        {
            int end = 0;
            int start = arr.Length - 1;
            while (end <= start)
            {
                int mid = (end + start) / 2;
                if (key == arr[mid])
                    return (mid + 1);
                if (key > arr[mid])
                    end = mid + 1;
                else start = mid - 1;

            }
            return -1;
        }
    }
}
