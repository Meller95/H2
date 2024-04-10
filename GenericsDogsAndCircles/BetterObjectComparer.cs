
public class BetterObjectComparer<T> where T : IComparable<T>
{
    public T Largest(T obj1, T obj2,T obj3)
    {
        T max = obj1;

        if (obj2.CompareTo(max) > 0)
        {
            max = obj2;
        }

        if (obj3.CompareTo(max) > 0)
        {
            max = obj3;
        }

        return max;
    }
}
