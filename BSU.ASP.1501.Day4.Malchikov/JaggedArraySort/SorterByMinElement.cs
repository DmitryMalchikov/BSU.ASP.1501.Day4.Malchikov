using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
    public class SorterByMinElementDescending : ISortRule<int,int>
    {
        public int GetKey(int[] array)
        {
            int min = array.Length == 0 ? int.MaxValue : array[0];

            for (int i = 1; i < array.Length; i++)
                if (array[i] < min) min = array[i];

            return -min;
        }
    }
}
