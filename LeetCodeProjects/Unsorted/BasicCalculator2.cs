using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/basic-calculator-ii/
    /// </summary>
    public class BasicCalculator2
    {
        public class Solution
        {
            public int Calculate(string s)
            {
                s = s.Replace(" ", "");
                var numbersStack = new Stack<int>();
                var operationsStack = new Stack<char>();

                var current = "";
                for (var i = 0; i < s.Length; i++)
                {
                    if (s[i] == '*' || s[i] == '/')
                    {
                        if (current != "")
                        {
                            numbersStack.Push(int.Parse(current));
                        }

                        current = "";
                        var right = "";
                        int j;
                        for (j = i + 1; j < s.Length; j++)
                        {
                            if (s[j] == '+' || s[j] == '-' || s[j] == '*' || s[j] == '/')
                            {
                                break;
                            }

                            right += s[j];
                        }

                        var prev = numbersStack.Pop();
                        var next = int.Parse(right);
                        numbersStack.Push(s[i] == '*' ? prev * next : prev / next);
                        i = j - 1;
                    }
                    else if (s[i] == '+' || s[i] == '-')
                    {
                        if (current != "")
                        {
                            numbersStack.Push(int.Parse(current));
                        }

                        operationsStack.Push(s[i]);
                        current = "";
                    }
                    else
                    {
                        current += s[i];
                    }
                }

                if (current != "")
                {
                    numbersStack.Push(int.Parse(current));
                }

                var reversed = new Stack<int>();
                while (numbersStack.Any())
                {
                    reversed.Push(numbersStack.Pop());
                }

                numbersStack = reversed;

                var reversedOperations = new Stack<char>();
                while (operationsStack.Any())
                {
                    reversedOperations.Push(operationsStack.Pop());
                }

                operationsStack = reversedOperations;

                while (operationsStack.Any())
                {
                    var operation = operationsStack.Pop();
                    var n1 = numbersStack.Pop();
                    var n2 = numbersStack.Pop();
                    numbersStack.Push(operation == '+' ? n1 + n2 : n1 - n2);
                }

                return numbersStack.First();
            }
        }
    }
}
