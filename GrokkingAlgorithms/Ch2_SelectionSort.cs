using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    public class Ch2_SelectionSort
    {
        public static int[] unrangedArray = new int[] { 3, 18, 1, 25,  9,  19, 15, 7, 12,  17,  23, 5, 20 };

        public static int[] SortArray(int[] NumArray)
        {
            var arrayLength = NumArray.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (NumArray[j] < NumArray[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                var tempVar = NumArray[smallestVal];
                NumArray[smallestVal] = NumArray[i];
                NumArray[i] = tempVar;
            }
            return NumArray;
        }
    }
}
