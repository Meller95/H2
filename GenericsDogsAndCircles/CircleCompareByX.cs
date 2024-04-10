using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDogsAndCircles
{
    public class CircleCompareByX : IComparer<Circle>
    {
        public int Compare(Circle x, Circle y)
        {
            if (x == null || y == null)
                throw new ArgumentException("Argument cannot be null.");

            return x.X.CompareTo(y.X);
        }
        
    }
}
