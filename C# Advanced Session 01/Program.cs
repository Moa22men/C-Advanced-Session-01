using System;

namespace C__Advanced_Session_01
{
    internal class Program
    {
        #region Part 1
        static void OptimizedBubbleSort(int[] array)
        {
            int n = array.Length;
            bool flag;

            for (int i = 0; i < n - 1; i++)
            {
                flag = false;

                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        flag = true;
                    }
                }

                if (!flag)
                    break;
            }
            #endregion
            static void Main(string[] args)
            {
                
            }
        }
    }
}
