﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects.Problems91_100
{
    /// <summary>
    /// https://leetcode.com/problems/same-tree/submissions/
    /// </summary>
    public class SameTree
    {
        public class Solution
        {
            private const string Deliminator = "X";

            public bool IsSameTree(TreeNode p, TreeNode q)
            {
                return GetTreeVal(p, "") == GetTreeVal(q, "");
            }

            private string GetTreeVal(TreeNode p, string s)
            {
                if (p == null)
                {
                    return Deliminator;
                }

                s += p.val;

                s += p.left != null ? GetTreeVal(p.left, "") : Deliminator;

                s += p.right != null ? GetTreeVal(p.right, "") : Deliminator;

                return s;
            }
        }
    }
}
