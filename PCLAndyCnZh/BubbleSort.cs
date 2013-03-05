using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCLAndyCnZh
{
    namespace Sort
    {
        public class BubbleSort
        {
            public int[] ExecuteBubbleSort(int[] unsortArray)
            {
                int temp = 0;

                for (int i = 0; i < unsortArray.Length - 1; i++)
                {
                    bool swap = false;

                    for (int j = unsortArray.Length - 1; j > i; j--)
                    {
                        if (unsortArray[j] < unsortArray[j - 1])
                        {
                            temp = unsortArray[j];
                            unsortArray[j] = unsortArray[j - 1];
                            unsortArray[j - 1] = temp;
                            swap = true;
                        }
                    }

                    if (!swap)
                    {
                        break;
                    }
                }

                return unsortArray;
            }

            public static T[] ExecuteBubbleSort<T>(T[] sortList) where T : IComparable<T>
            {
                T temp;

                for (int i = 0; i < sortList.Length - 1; i++)
                {
                    bool swap = false;

                    for (int j = sortList.Length - 1; j > i; j--)
                    {
                        if (sortList[j].CompareTo(sortList[j - 1]) < 0)
                        {
                            temp = sortList[j];
                            sortList[j] = sortList[j - 1];
                            sortList[j - 1] = temp;
                            swap = true;
                        }
                    }

                    if (!swap)
                    {
                        break;
                    }
                }

                return sortList;
            }

            public static List<T> ExecuteBubbleSort<T>(List<T> sortList) where T : IComparable<T>
            {
                T temp;

                for (int i = 0; i < sortList.Count - 1; i++)
                {
                    bool swap = false;

                    for (int j = sortList.Count - 1; j > i; j--)
                    {
                        if (sortList[j].CompareTo(sortList[j - 1]) < 0)
                        {
                            temp = sortList[j];
                            sortList[j] = sortList[j - 1];
                            sortList[j - 1] = temp;
                            swap = true;
                        }
                    }

                    if (!swap)
                    {
                        break;
                    }
                }

                return sortList;
            }

        }
    }
}
