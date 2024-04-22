using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    public class ScopedLocker : IDisposable
    {
        private readonly object _mutex;

        public ScopedLocker(object mutex)
        {
            _mutex = mutex;
            Monitor.Enter(_mutex);
        }

        public void Dispose()
        {
            Monitor.Exit(_mutex);
        }
    }
}
