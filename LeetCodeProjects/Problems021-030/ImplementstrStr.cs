namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/implement-strstr/
    /// </summary>
    public class ImplementStrStr
    {
        public class Solution
        {
            public int StrStr(string haystack, string needle)
            {
                var res = -1;
                if (needle == "")
                {
                    res = 0;
                }

                if (haystack.Length == needle.Length)
                {
                    res = haystack == needle ? 0 : -1;
                }

                for (var i = 0; i < haystack.Length + 1 - needle.Length; i++)
                {
                    var part = haystack.Substring(i, needle.Length);
                    if (part == needle)
                    {
                        res = i;
                        break;
                    }
                }

                return res;
            }
        }
    }
}
