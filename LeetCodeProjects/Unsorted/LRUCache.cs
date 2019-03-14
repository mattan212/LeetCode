using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/lru-cache/description/
    /// </summary>
    public class LRUCache
    {
        private Dictionary<int, Entry> _data = new Dictionary<int, Entry>();

        int _cap;

        public LRUCache(int capacity)
        {
            _cap = capacity;
        }

        public int Get(int key)
        {
            var res = -1;

            if (_data.ContainsKey(key))
            {
                _data[key].LastTimeUsed = DateTime.Now;

                res = _data[key].Value;
            }

            return res;
        }

        public void Put(int key, int value)
        {
            if (_cap <= 0)
            {
                return;
            }

            var containsKey = _data.ContainsKey(key);

            if (_data.Count >= _cap && !containsKey)
            {
                var options = _data.OrderBy(x => x.Value.LastTimeUsed).Select(x => x.Key);
                _data.Remove(options.First());
            }

            if (containsKey)
            {
                var entry = _data[key];
                entry.Value = value;
                entry.LastTimeUsed = DateTime.Now;
            }
            else
            {
                _data.Add(key, new Entry
                {
                    Value = value,
                    LastTimeUsed = DateTime.Now
                });
            }
        }

        private class Entry
        {
            public int Value { get; set; }

            public DateTime LastTimeUsed { get; set; }
        }
    }
}
