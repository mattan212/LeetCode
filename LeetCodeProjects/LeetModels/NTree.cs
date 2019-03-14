using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.LeetModels
{
    public class NTree
    {
        public string Id { get; set; }
        public int Level { get; set; }

        public int Value { get; set; }

        public List<NTree> Branches { get; set; }

        public NTree(int value, int level)
        {
            Value = value;
            Level = level;
            Branches = new List<NTree>();
        }
    }
}
