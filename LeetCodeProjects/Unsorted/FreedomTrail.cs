using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/freedom-trail/description/
    /// </summary>
    public class FreedomTrail
    {
        public class Solution
        {
            private Dictionary<char, List<int>> _map = new Dictionary<char, List<int>>();

            public int FindRotateSteps(string ring, string key)
            {
                for (var i = 0; i < ring.Length; i++)
                {
                    var c = ring[i];

                    if (!_map.ContainsKey(c))
                    {
                        _map.Add(c, new List<int>());
                    }

                    _map[c].Add(i);
                }

                var graph = new Graph<int>(new Func<int, int, int>((x, y) => { return Shortest(ring.Length, x, y); }));

                for (var i = 0; i < key.Length; i++)
                {
                    var options = _map[key[i]];

                    graph.Insert(options);
                }

                graph.Close();

                var res = graph.Dijkstra();

                return res;
            }

            private int Shortest(int ringSize, int currentIndex, int nextIndex)
            {
                //need to determine the shortest way to next index. 
                //This can be achieve by going from the front or from the back.
                var front = Math.Max(currentIndex, nextIndex) - Math.Min(currentIndex, nextIndex);

                var back = Math.Min(currentIndex, nextIndex) - Math.Max(currentIndex, nextIndex);
                back = back < 0 ? ringSize + back : back;

                return Math.Min(front, back);
            }
        }

        public class Vertex
        {
            public Vertex()
            {
                Edges = new List<Edge>();
                Value = int.MaxValue;
            }

            public int Data { get; set; }
            public List<Edge> Edges { get; set; }

            public int Value { get; set; }
        }

        public class Edge
        {
            public int Value { get; set; }
            public Vertex From { get; set; }
            public Vertex To { get; set; }
        }

        public class Graph<T>
        {
            public List<Vertex> Vertices { get; set; }
            
            Func<int, int, int> EdgeValue { get; set; }

            private List<Vertex> _lastVertices;

            public Graph(Func<int, int, int> edgeValue)
            {
                Vertices = new List<Vertex>
                {
                    new Vertex
                    {
                        Value = 0
                    }
                };
                _lastVertices = Vertices;
                EdgeValue = edgeValue;
            }

            public void Insert(int data)
            {
                var vertex = new Vertex
                {
                    Data = data
                };

                if (!_lastVertices.Any())
                {
                    _lastVertices.Add(vertex);
                }
                else
                {
                    foreach (var v in _lastVertices)
                    {
                        var edge = new Edge
                        {
                            From = v,
                            To = vertex,
                            Value = EdgeValue(v.Data, vertex.Data)
                        };

                        v.Edges.Add(edge);
                        vertex.Edges.Add(edge);
                    }

                    Vertices.AddRange(_lastVertices);
                    _lastVertices = new List<Vertex>
                    {
                        vertex
                    };
                }
            }

            public void Insert(List<int> data)
            {
                var vertices = data.Select(x => new Vertex
                {
                    Data = x
                }).ToList();

                if (!_lastVertices.Any())
                {
                    _lastVertices = vertices;
                }
                else
                {
                    foreach (var vertex in vertices)
                    {
                        foreach (var v in _lastVertices)
                        {
                            var edge = new Edge
                            {
                                From = v,
                                To = vertex,
                                Value = EdgeValue(v.Data, vertex.Data)
                            };

                            v.Edges.Add(edge);
                            vertex.Edges.Add(edge);
                        }
                    }

                    Vertices.AddRange(_lastVertices);

                    _lastVertices = vertices;
                }
            }

            public void Close()
            {
                Vertices.AddRange(_lastVertices);
            }

            public int Dijkstra()
            {
                foreach (var vertex in Vertices)
                {
                    vertex.Edges.ForEach(x => { x.To.Value = Math.Min(x.To.Value, 1 + x.Value + vertex.Value); });
                }

                return _lastVertices.Min(x => x.Value);
            }
        }
    }
}
