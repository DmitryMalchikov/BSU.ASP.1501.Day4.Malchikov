using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
    public class StringsBySum : ISortRule<int,string>
    {
        public int GetKey(string[] array)
        {
            int result = 0;

            for (int i = 0; i < array.Length; i++)
                foreach (var el in array[i])
                    result += el;

            return result;
        }
    }
}
