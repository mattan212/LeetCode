using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems91_100
{
    public class UniqueBinarySearchTrees
    {
        public class Solution
        {
            public int NumTrees(int n)
            {
                //Generating the trees (UniqueBinarySearchTrees2) and returning the count
                //resulted in TLE. 
                //However, the results of 1-5 hints us to look at Catalan Numbers (1,2,5,14,42,...)
                //Read more at: http://mathforum.org/advanced/robertd/catalan.html

                long ans = 1;
                long i = 1;
                for (i = 1; i <= n; i++)
                {
                    ans = ans * (i + n) / i;
                }

                return (int)(ans / i);
            }
        }
    }
}
