using System;

namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/min-stack/
    /// </summary>
    public class MinStack
    {
        private int _min;
        private int[] _arr;
        private int _index;
        
        public MinStack()
        {
            _arr = new int[1024];
            _min = int.MaxValue;
            _index = 0;
        }

        public void Push(int x)
        {
            if (_index + 1 > _arr.Length)
            {
                var temp = new int[_arr.Length * 2];
                for (var i = 0; i < _arr.Length; i++)
                {
                    temp[i] = _arr[i];
                    _arr = temp;
                }
            }
            _arr[_index++] = x;
            _min = Math.Min(_min, x);
        }

        public void Pop()
        {
            if (_index > 0)
            {
                _index--;
            }
            RefreshMin();
        }

        public int Top()
        {
            var res = _arr[_index - 1];
            RefreshMin();
            return res;
        }

        public int GetMin()
        {
            return _min;
        }

        private void RefreshMin()
        {
            _min = int.MaxValue;
            for (var i = 0; i < _index; i++)
            {
                _min = Math.Min(_min, _arr[i]);
            }
        }
    }
}
