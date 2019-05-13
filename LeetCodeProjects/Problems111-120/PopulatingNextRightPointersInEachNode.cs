using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects.Problems111_120
{
    /// <summary>
    /// https://leetcode.com/problems/populating-next-right-pointers-in-each-node/
    /// </summary>
    public class PopulatingNextRightPointersInEachNode
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

                while (current.First() != null)
                {
                    var next = new List<Node>();
                    for (var i = 0; i < current.Count - 1; i++)
                    {
                        current[i].next = current[i + 1];
                        next.Add(current[i].left);
                        next.Add(current[i].right);
                    }

                    next.Add(current[current.Count - 1].left);
                    next.Add(current[current.Count - 1].right);

                    current = next;
                }

                return root;
            }
        }
    }
}
