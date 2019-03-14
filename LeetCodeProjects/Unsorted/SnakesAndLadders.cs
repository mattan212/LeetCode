using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/snakes-and-ladders/
    /// </summary>
    public class SnakesAndLadders
    {
        public class Solution
        {
            private Dictionary<int, List<Edge>> _edges = new Dictionary<int, List<Edge>>();

            private Dictionary<int, Vertex> _vertices = new Dictionary<int, Vertex>();


            public int SnakesAndLadders(int[][] board)
            {
                var flatBoard = FlattenBoard(board);

                BuildNodes(flatBoard);

                var queue = new Queue<Vertex>();
                _vertices.First().Value.Visited = true;
                queue.Enqueue(_vertices.First().Value);

                var res = -1;
                while (queue.Any())
                {
                    var v = queue.Dequeue();
                    var to = _edges[v.Id].Where(x => !x.To.Visited).Select(x => x.To).ToList();
                    to.ForEach(x =>
                    {
                        x.Value = v.Value + 1;
                        x.Visited = true;
                        if (x.Id == flatBoard.Length - 1)
                        {
                            res = x.Value;
                            queue = new Queue<Vertex>();
                        }
                        else
                        {
                            queue.Enqueue(x);
                        }
                    });
                }

                return res;
            }

            private int[] FlattenBoard(int[][] board)
            {
                var res = new int[(int)Math.Pow(board.GetLength(0), 2)];
                var index = 0;

                var direction = 1;
                for (var row = board.GetLength(0) - 1; row >= 0; row--)
                {
                    if (direction == 1)
                    {
                        for (var col = 0; col < board.GetLength(0); col++)
                        {
                            res[index] = board[row][col];
                            index++;
                        }
                    }
                    else
                    {
                        for (var col = board.GetLength(0) - 1; col >= 0; col--)
                        {
                            res[index] = board[row][col];
                            index++;
                        }
                    }

                    direction = direction * -1;
                }

                return res;
            }

            private void BuildNodes(int[] board)
            {
                for (var i = 0; i < board.Length; i++)
                {
                    Vertex from;
                    if (_vertices.ContainsKey(i))
                    {
                        from = _vertices[i];
                    }
                    else
                    {
                        from = new Vertex { Id = i };
                        _vertices.Add(i, from);
                    }

                    for (var j = i + 1; j < i + 7 && j < board.Length; j++)
                    {
                        Vertex to;
                        var id = board[j] == -1 ? j : board[j] - 1;

                        if (_vertices.ContainsKey(id))
                        {
                            to = _vertices[id];
                        }
                        else
                        {
                            to = new Vertex { Id = id };
                            _vertices.Add(id, to);
                        }

                        if (!_edges.ContainsKey(from.Id))
                        {
                            _edges[from.Id] = new List<Edge>();
                        }

                        _edges[from.Id].Add(new Edge
                        {
                            From = from,
                            To = to
                        });
                    }
                }
            }

            internal class Edge
            {
                public Vertex From { get; set; }

                public Vertex To { get; set; }
            }

            internal class Vertex
            {
                public int Id { get; set; }

                public int Value { get; set; }

                public bool Visited { get; set; }
            }
        }
    }
}
