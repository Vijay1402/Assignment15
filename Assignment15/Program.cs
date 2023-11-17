using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{
    internal class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int len = arr.Length;
            int noSwap = 0;
            for (int i = 0; i <= len - 1; i++)
            {
                for (int j = 0; j < len - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        noSwap++;
                    }
                }
            }
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                Console.WriteLine("\n");
            }
        }
        public static int BinarySerach(int[] arr, int searchItem)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == searchItem)
                { 
                    return mid; 
                }
                else if (arr[mid] < searchItem)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAY INPUT");
            Console.WriteLine("Enter the number of elements of the array: ");
            int len = int.Parse(Console.ReadLine());
            int[] arr = new int[len];
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sorting the array using Bubble sort");
            BubbleSort(arr);
            Console.WriteLine("This is the sorted array");
            Print(arr);
            Console.WriteLine("Enter the number to searched in the array");
            int x = int.Parse(Console.ReadLine());
            int pos = BinarySerach(arr,x);
            if (pos < 0)
            {
                Console.WriteLine("Element not found in array");
            }
            else
            {
                Console.WriteLine("Element found at index "+pos);
            }
            Console.ReadKey();
        }
    }
}
