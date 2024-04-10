using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository
{
    public class Repository<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public void printAll()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public int Count
        {
            get { return items.Count; }
        }
    }
}
