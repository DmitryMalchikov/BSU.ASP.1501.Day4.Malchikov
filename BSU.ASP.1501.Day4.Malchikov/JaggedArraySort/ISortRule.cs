using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
    //<summary>
    //T - type of key, T1 - type of array
    //</summary>
    public interface ISortRule<T,T1>
    {
        T GetKey(T1[] array);
    }
}
