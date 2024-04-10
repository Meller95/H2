using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDogsAndCircles
{
    public class EvenBetterObjectComparer
    {
        public T Largest<T>(T obj1, T obj2, T obj3, IComparer<T> comparer)
        {
            T max = obj1;

            if (comparer.Compare(obj2, max) > 0)
            {
                max = obj2;
            }

            if (comparer.Compare(obj3, max) > 0)
            {
                max = obj3;
            }

            return max;
        }
    }
}
