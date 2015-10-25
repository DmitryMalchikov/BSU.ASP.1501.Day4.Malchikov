using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
    public class ByMaxModule : ISortRule<int, string>
    {
        public int GetKey(string[] array)
        {
            int max = array.Length == 0 ? int.MaxValue : array[0].Length;

            for (int i = 1; i < array.Length; i++)
                if (array[i].Length > max) max = array[i].Length;

            return max;
        }
    }
}
