using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
    public static class ArraySorter
    {
        public static T1[][] Sort<T,T1>(T1[][] array, ISortRule<T,T1> comparer) where T : IComparable
        {
            T1[][] result = (T1[][])array.Clone();

            for (int i = 0; i < array.Length; i++)
                for (int j = i+1; j < array.Length; j++)
                {
                    if (comparer.GetKey(result[i]).CompareTo(comparer.GetKey(result[j])) == 1)
                        result.Swap(i, j);
                }

            return result;
        }

        private static void Swap<T>(this T[][] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
