using System.Collections.Generic;
using System.Linq;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/unique-binary-search-trees-ii/
    /// </summary>
    public class UniqueBinarySearchTrees2
    {
        public class Solution
        {
            public IList<TreeNode> GenerateTrees(int n)
            {
                var res = new List<TreeNode>();
                if (n <= 0)
                {
                    return res;
                }

                return GenerateTrees(1, n); ;
            }

            private List<TreeNode> GenerateTrees(int start, int end)
            {
                var res = new List<TreeNode>();
                if (end < start)
                {
                    return res;
                }

                if (start == end)
                {
                    res.Add(new TreeNode(start));
                    return res;
                }
                
                for (var i = start; i <= end; i++)
                {
                    var left = GenerateTrees(start, i - 1);
                    var right = GenerateTrees(i + 1, end);
                    foreach (var t1 in left)
                    {
                        foreach (var t2 in right)
                        {
                            res.Add(new TreeNode(i)
                            {
                                left = t1,
                                right = t2
                            });
                        }
                    }

                    if (!right.Any())
                    {
                        foreach (var t1 in left)
                        {
                            res.Add(new TreeNode(i)
                            {
                                left = t1
                            });
                        }
                    }

                    if (!left.Any())
                    {
                        foreach (var t1 in right)
                        {
                            res.Add(new TreeNode(i)
                            {
                                right = t1
                            });
                        }
                    }

                }

                return res;
            }
        }
    }
}
