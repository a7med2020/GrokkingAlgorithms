using System;

namespace GrokkingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Ch1 Binary Search Iterative = 1");
            Console.WriteLine("Ch1 Binary Search Recursive = 2");
            Console.WriteLine("Ch2 Selection Sort = 3");
            Console.WriteLine("Ch3 Recusion = 4");
            Console.WriteLine("Ch4 Quick Sort = 5");
            Console.WriteLine("Ch5 Hash Table = 6");
            Console.WriteLine("Towers of Hanoi = 7");
            Console.WriteLine("==================================================================");
            Console.WriteLine("==================================================================");
            Console.WriteLine("");
            Console.WriteLine("Algorithm Number: ");
            string index = Convert.ToString(Console.ReadLine());
            CallingAlgorithm(Convert.ToInt32(index));

            Console.ReadKey();

        }


        static void  CallingAlgorithm(int algorithmKey)
        {
            switch (algorithmKey)
            {
                case (int)AlgorithmKeys.Ch1_BinarySearch_BinarySearchIterative:
                     Console.WriteLine( Ch1_BinarySearch.BinarySearchIterative(Ch1_BinarySearch.arrayOfInt99, 90));
                    break;

                case (int)AlgorithmKeys.Ch1_BinarySearch_BinarySearchRecursive:
                    Console.WriteLine(Ch1_BinarySearch.BinarySearchRecursive(Ch1_BinarySearch.arrayOfInt99, 90 ,0 ,Ch1_BinarySearch.arrayOfInt99.Length-1));
                    break;

                case (int)AlgorithmKeys.Ch2_SelectionSort_SortArray:
                    foreach (var item in Ch2_SelectionSort.SortArray(Ch2_SelectionSort.unrangedArray))
                    {
                        Console.WriteLine(item.ToString());
                    }
                    break;
                 case (int)AlgorithmKeys.Ch3_Recusion:
                    Console.WriteLine("Factorial of 5: {0}" ,Ch3_Recursion.Factorial(5));
                    break;
                case (int)AlgorithmKeys.Ch4_QuickSort:
                    Ch4_QuickSort.Execute_QuickSort();
                    break;
                case (int)AlgorithmKeys.Ch5_HashTable:
                    Ch5_HashTable.Execute_HashTable();
                    break;
                case (int)AlgorithmKeys.TowersOfHanoi:
                    TowersOfHanoi.Execute();
                    break;
                default:
                    Console.WriteLine("No Algorithm");
                    break;
            }
        }
    }
}
