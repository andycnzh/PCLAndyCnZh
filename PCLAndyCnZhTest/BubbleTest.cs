using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCLAndyCnZh.Sort;

namespace PCLAndyCnZhTest
{
    namespace Sort
    {
        [TestClass]
        public class BubbleTest
        {
            [TestMethod]
            public void ExecuteBubbleSort()
            {
                BubbleSort bs = new BubbleSort();
                int[] arr = new int[9] { 2, 1, 4, 3, 6, 5, 8, 7, 9 };
                int[] sortArr = new int[9];

                sortArr = bs.ExecuteBubbleSort(arr);

                for (int i = 0; i < sortArr.Length; i++)
                {
                    Assert.AreEqual(sortArr[i], i + 1);
                }

            }
        }
    }
}
