using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LeetCodeProjects.Contributions
{
    public class ConcurrentQueue
    {
        private int[] _container;
        private int _enqueueIndex = 0;
        private int _dequeueIndex = 0;

        public ConcurrentQueue(int size)
        {
            _container = Enumerable.Repeat(-1, size).ToArray();
        }

        public override string ToString()
        {
            return _container.Aggregate("", (s, n) => s + n + ",").TrimEnd(',', ' ');
        }

        public void Enqueue(int num)
        {
            if (num < 0)
            {
                return;
            }

            while (_container[_enqueueIndex] != -1)
            {
                Thread.Sleep(100);
            }
            
            _container[_enqueueIndex] = num;
            _enqueueIndex = (_enqueueIndex + 1) % _container.Length;
        }

        public int Dequeue()
        {
            while (_container[_dequeueIndex] == -1)
            {
                Thread.Sleep(100);
            }

            var res = _container[_dequeueIndex];
            _container[_dequeueIndex] = -1;
            _dequeueIndex = (_dequeueIndex + 1) % _container.Length;

            return res;
        }
    }
}
