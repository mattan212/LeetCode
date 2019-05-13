using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/lfu-cache/description/
    /// </summary>
    public class LFUCache
    {
        private Dictionary<int, Entry> _data = new Dictionary<int, Entry>();

        int _cap;

        public LFUCache(int capacity)
        {
            _cap = capacity;
        }

        public int Get(int key)
        {
            var res = -1;

            if (_data.ContainsKey(key))
            {
                _data[key].LastTimeUsed = DateTime.Now;

                _data[key].UsageCount++;

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
                var minUsages = _data.Min(x => x.Value.UsageCount);
                var options = _data.Where(x => x.Value.UsageCount == minUsages).OrderBy(x => x.Value.LastTimeUsed);
                _data.Remove(options.First().Key);
            }


            if (containsKey)
            {
                var entry = _data[key];
                entry.Value = value;
                entry.LastTimeUsed = DateTime.Now;
                entry.UsageCount++;
            }
            else
            {
                _data.Add(key, new Entry
                {
                    Value = value,
                    LastTimeUsed = DateTime.Now,
                    UsageCount = 1
                });
            }
        }
        private class Entry
        {
            public int Value { get; set; }

            public DateTime LastTimeUsed { get; set; }

            public int UsageCount { get; set; }
        }
    }
}
