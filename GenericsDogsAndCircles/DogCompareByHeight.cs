using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDogsAndCircles
{
    public class DogCompareByHeight : IComparer<Dog>
    {
        public int Compare(Dog x, Dog y)
        {
            if (x == null || y == null)
                throw new ArgumentException("Argument cannot be null.");

            return x.Height.CompareTo(y.Height);
        }

    }
}
