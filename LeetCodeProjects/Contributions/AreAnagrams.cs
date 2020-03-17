using System.Collections.Generic;

namespace LeetCodeProjects.Contributions
{
    public class AreAnagrams
    {
        public bool Solution(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            if (s1 == s2)
            {
                return true;
            }

            var dict1 = PopulateDict(s1);
            var dict2 = PopulateDict(s2);

            if (dict1.Count != dict2.Count)
            {
                return false;
            }
            foreach (var entry in dict1)
            {
                if (!dict2.ContainsKey(entry.Key) || entry.Value != dict2[entry.Key])
                {
                    return false;
                }
            }

            return true;
        }

        private Dictionary<char, int> PopulateDict(string s)
        {

            var dict = new Dictionary<char, int>();

            foreach (var c in s.ToLower())
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 0);
                }
                dict[c]++;
            }
            return dict;
        }
    }
}
