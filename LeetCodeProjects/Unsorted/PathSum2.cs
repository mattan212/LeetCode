using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    public class PathSum2
    {
        public class Solution
        {
            private List<IList<int>> _res = new List<IList<int>>();

            public IList<IList<int>> PathSum(TreeNode root, int sum)
            {
                if (root != null)
                {
                    var list = new List<int>();

                    PathSum(root, sum, list);
                }

                return _res;
            }

            private void PathSum(TreeNode root, int sum, IList<int> rollingList)
            {
                rollingList.Add(root.val);

                sum = sum - root.val;

                if (sum == 0 && root.left == null && root.right == null)
                {
                    _res.Add(rollingList);
                }

                if (root.left != null)
                {
                    PathSum(root.left, sum, rollingList.ToList());
                }

                if (root.right != null)
                {
                    PathSum(root.right, sum, rollingList.ToList());
                }
            }
        }
    }
}
