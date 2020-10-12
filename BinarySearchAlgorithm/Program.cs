using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAlgorithm
{
    class Program
    {
        public const int NOT_FOUND = -1;

        static void Main(string[] args)
        {
            ////Initial test array & target
            //int[] mySortedArray = { -4, -1, 0, 1, 4, 6, 9, 10, 13, 17, 20 };
            //int myTarget = 20;

            ////Intial values for array Info
            //int[] arrayInfo = { 0, mySortedArray.Length - 1, -1};

            ////Recursive check for binary search
            //while (arrayInfo[2] == -1 && arrayInfo[0] <= arrayInfo[1])
            //{
            //    arrayInfo = BinarySearchAlgo(mySortedArray, myTarget, arrayInfo[0], arrayInfo[1]);
                
            //}

            //ShowResult(arrayInfo);

            //Test for algorithm from book
            int SIZE = 8;
            int[] a = new int[SIZE];
            for (int i = 0; i < SIZE; i++)
                a[i] = i * 2;

            for (int i = 0; i < SIZE * 2; i++)
                Console.WriteLine("Found " + i + " at " + BinarySearch(a, i));

            Console.ReadLine();
        }

        ////Binary search algorithm
        ////Check to see if the mid-index value is equal to target
        ////then return is index
        //static int[] BinarySearchAlgo(int[] mySortedArr, int myTarget, int startIndex, int endIndex)
        //{
        //    int result = -1;
        //    int newStartIndex, newEndIndex;

        //    //Get value of mid-item
        //    int midIndex = Convert.ToInt32(Math.Round(Convert.ToDecimal((startIndex + endIndex)/2)));
        //    int midValue = mySortedArr[midIndex];

        //    //Check to see if midValue equal to myTarget
        //    //then update startIndex, endIndex and result (if neccesary)
        //    if(midValue == myTarget)
        //    {
        //        result = midIndex;
        //        newStartIndex = 0;
        //        newEndIndex = 0;
        //    }
        //    else if(midValue > myTarget)
        //    {
        //        newStartIndex = startIndex;
        //        newEndIndex = midIndex - 1;     
        //    }
        //    else
        //    {
        //        newStartIndex = midIndex + 1;
        //        newEndIndex = endIndex;
        //    }

        //    //return array
        //    int[] returnArray = { newStartIndex, newEndIndex, result };

        //    return returnArray;

        //}

        ////Show the result
        //static void ShowResult(int[] arrayInfo) { 
        //    if(arrayInfo[2] != -1)
        //    {
        //        Console.WriteLine($"Our number has index {arrayInfo[2]}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Our array does not include the target");
        //    }
        //}

        //Binary Search algorithm from book
        public static int BinarySearch<AnyType>(AnyType[] a, AnyType x) where AnyType : IComparable
        {
            return BinarySearch(a, x, 0, a.Length - 1);
        }

        // Hidden recursive routine.
        public static int BinarySearch<AnyType>(AnyType[] a, AnyType x, int low, int high) where AnyType : IComparable
        {
            if (low > high)
                return NOT_FOUND;

            int mid = (low + high) / 2;

            if (a[mid].CompareTo(x) < 0)
                return BinarySearch(a, x, mid + 1, high);
            else if (a[mid].CompareTo(x) > 0)
                return BinarySearch(a, x, low, mid - 1);
            else
                return mid;
        }

    }
}
