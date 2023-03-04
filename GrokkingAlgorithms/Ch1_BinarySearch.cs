using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    class Ch1_BinarySearch
    {
        public static int[] arrayOfInt99 = new int[] { 1, 3, 5, 7, 9, 12, 15, 17, 18, 19, 20, 23, 25, 27, 28, 30, 31, 33, 34, 35, 36, 38, 40, 41, 45, 48, 49, 50, 51, 52, 53, 59, 61, 70, 71, 72, 73, 74, 80, 90, 91, 95, 99};
        public static object BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "Nil";
        }

        public static object BinarySearchRecursive(int[] inputArray, int key, int min, int max)
        {
           
            if (min > max)
            {
                return "Nil";
            }
            else
            {
                int mid = (min + max) / 2;
                int a = inputArray[mid];
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    return BinarySearchRecursive(inputArray, key, min, mid - 1);
                }
                else
                {
                    return BinarySearchRecursive(inputArray, key, mid + 1, max);
                }
            }
        }

    }
}
