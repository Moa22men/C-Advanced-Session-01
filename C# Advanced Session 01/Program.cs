using System;

namespace C__Advanced_Session_01
{
    #region Part 2
    public class Range<T> where T : IComparable<T>
    {
        private T min;
        private T max;

        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
                Console.WriteLine("Minimum should not be greater than Maximum.");

            min = minimum;
            max = maximum;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }

        public dynamic Length()
        {
            return (dynamic)max - (dynamic)min;
        }
    }

    #endregion
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
