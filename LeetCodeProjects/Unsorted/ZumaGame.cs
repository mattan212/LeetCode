using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/zuma-game/
    /// </summary>
    public class ZumaGame
    {
        public class OptionsTree
        {
            public OptionsTree(string board, string hand, int level)
            {
                Branches = new List<OptionsTree>();

                Board = board;

                Hand = hand;

                Level = level;
            }
            public List<OptionsTree> Branches { get; set; }

            public int Level { get; set; }

            public string Board { get; set; }

            public string Hand { get; set; }

            public string Id => OptionsTree.GetId(Board, Hand, Level);
            
            public static string GetId(string board, string hand, int level)
            {
                return $"Board: {board}, Hand: {hand}, Level: {level}";
            }
        }

        public class Solution
        {
            private Dictionary<string, OptionsTree> _cache = new Dictionary<string, OptionsTree>();

            private string RemoveFirstInstanceOf(string str, char c)
            {
                var index = str.IndexOf(c);
                str = str.Substring(0, index) + (str.Length >= index + 1 ? str.Substring(index + 1) : "");
                return str;
            }

            private OptionsTree BuildTree(OptionsTree tree)
            {
                var options = GetEntryIndices(tree.Board);

                foreach (var option in options)
                {
                    var c = tree.Board[option];
                    if (tree.Hand.Contains(c))
                    {
                        var board = ClearBoard(Insert(tree.Board, c, option));
                        var hand = RemoveFirstInstanceOf(tree.Hand, c);
                        var id = OptionsTree.GetId(board, hand, tree.Level + 1);

                        OptionsTree newTree;
                        if (_cache.ContainsKey(id))
                        {
                            newTree = _cache[id];
                        }
                        else
                        {
                            newTree = BuildTree(new OptionsTree(board, hand, tree.Level + 1));
                            _cache.Add(newTree.Id, newTree);
                        }
                        
                        tree.Branches.Add(newTree);
                    }
                }

                return tree;
            }

            public int FindMinStep(string board, string hand)
            {
                BuildTree(new OptionsTree(board, hand, 0));

                if (_cache.Any(x => x.Value.Board == ""))
                {
                    return _cache.Where(x => x.Value.Board == "").Min(x => x.Value.Level);
                }

                return -1;
            }

            public string Insert(string board, char c, int index)
            {
                return board.Insert(index, "" + c);
            }

            private List<int> GetEntryIndices(string board)
            {
                var res = new List<int>();

                char current = ' ';

                for (var i = 0; i < board.Length; i++)
                {
                    if (board[i] != current)
                    {
                        current = board[i];
                        res.Add(i);
                    }
                }

                return res;
            }
            
            private string ClearBoard(string board)
            {
                var j = 0;
                var res = "";
                var changed = false;
                for (var i = 0; i < board.Length; i++)
                {
                    if (i < board.Length - 2 && board[i] == board[i + 1] && board[i] == board[i + 2])
                    {
                        changed = true;
                        for (j = i; j < board.Length; j++)
                        {
                            if (board[j] != board[i])
                            {
                                break;
                            }
                        }
                        i = j - 1;
                    }
                    else
                    {
                        res += board[i];
                    }
                }

                return changed ? ClearBoard(res) : res;
            }
        }
    }
}
