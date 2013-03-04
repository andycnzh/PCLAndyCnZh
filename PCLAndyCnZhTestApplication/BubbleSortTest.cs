﻿using PCLAndyCnZh.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCLAndyCnZhTestApplication
{
    class BubbleSortTest
    {
        public void ExecuteBubbleSortTest()
        {
            BubbleSort bs = new BubbleSort();
            int[] intArr = new int[9] { 2, 1, 4, 3, 6, 5, 8, 7, 9 };
            int[] sortIntArr = new int[9];

            sortIntArr = bs.ExecuteBubbleSort(intArr);

            for (int i = 0; i < sortIntArr.Length; i++)
            {
                Console.Write(sortIntArr[i] + ",");
            }

            Console.WriteLine();

            double[] doubleArr = new double[9] { 2.2, 1.1, 4.4, 3.3, 6.6, 5.5, 8.8, 7.7, 9.9 };
            double[] sortDoubleArr = new double[9];


            sortDoubleArr = bs.ExecuteBubbleSort(doubleArr);

            for (int i = 0; i < sortDoubleArr.Length; i++)
            {
                Console.Write(sortDoubleArr[i] + ",");
            }
        }
    }
}
