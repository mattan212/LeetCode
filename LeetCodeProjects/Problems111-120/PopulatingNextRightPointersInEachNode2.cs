using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects.Problems111_120
{
    /// <summary>
    /// https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii/
    /// </summary>
    public class PopulatingNextRightPointersInEachNode2
    {
        public class Solution
        {
            public Node Connect(Node root)
            {
                if (root == null)
                {
                    return null;
                }
                var current = new List<Node> { root };

                while (current.Any())
                {
                    var next = new List<Node>();
                    for (var i = 0; i < current.Count - 1; i++)
                    {
                        current[i].next = current[i + 1];
                        if (current[i].left != null) next.Add(current[i].left);
                        if (current[i].right != null) next.Add(current[i].right);
                    }

                    if (current[current.Count - 1].left != null) next.Add(current[current.Count - 1].left);
                    if (current[current.Count - 1].right != null) next.Add(current[current.Count - 1].right);

                    current = next;
                }

                return root;
            }
        }
    }
}
