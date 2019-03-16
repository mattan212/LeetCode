using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems61_70
{
    /// <summary>
    /// https://leetcode.com/problems/valid-number/
    /// </summary>
    public class ValidNumber
    {
        public class Solution
        {
            public bool IsNumber(string s)
            {
                var stateMachine = new StateMachine();

                return stateMachine.IsValid(s);
            }
        }

        public abstract class State
        {
            public abstract State Next(char c);

            public virtual bool RequiresNext { get; set; }
        }

        public class InitialState : State
        {

            public override State Next(char c)
            {
                State nextState = this;
                if ('0' <= c && c <= '9')
                {
                    nextState = new IntegerPotionState();
                }
                else if (c == '-' || c == '+')
                {
                    nextState = new LeadingSignState();
                }
                else if (c == '.')
                {
                    nextState = new InitialDecimalPointState();
                }
                else if (c == ' ')
                {
                    RequiresNext = true;
                }
                else
                {
                    throw new Exception($"InvalidState {c} from InitialState");
                }
                return nextState;
            }
        }

        public class LeadingSignState : State
        {
            public override State Next(char c)
            {
                State nextState = this;
                if ('0' <= c && c <= '9')
                {
                    nextState = new IntegerPotionState();
                }
                else if (c == '.')
                {
                    nextState = new InitialDecimalPointState();
                }
                else
                {
                    throw new Exception($"InvalidState {c} from LeadingSignState");
                }
                return nextState;
            }
        }

        public class IntegerPotionState : State
        {
            public override State Next(char c)
            {
                State nextState = this;
                if ('0' <= c && c <= '9')
                {
                }
                else if (c == '.')
                {
                    nextState = new DecimalPointState();
                }
                else if (c == 'e')
                {
                    nextState = new ExponentState();
                }
                else
                {
                    throw new Exception($"InvalidState {c} from IntegerPotionState");
                }
                return nextState;
            }
        }

        public class InitialDecimalPointState : State
        {
            public InitialDecimalPointState()
            {
                RequiresNext = true;
            }

            public override State Next(char c)
            {
                State nextState = this;
                if ('0' <= c && c <= '9')
                {
                    nextState = new DecimalPointState();
                }
                else
                {
                    throw new Exception($"InvalidState {c} from InitialDecimalPointState");
                }
                return nextState;
            }
        }

        public class DecimalPointState : State
        {
            public override State Next(char c)
            {
                State nextState = this;
                if ('0' <= c && c <= '9')
                {
                }
                else if (c == 'e')
                {
                    nextState = new ExponentState();
                }
                else
                {
                    throw new Exception($"InvalidState {c} from DecimalPointState");
                }
                return nextState;
            }
        }

        public class ExponentState : State
        {
            public ExponentState()
            {
                RequiresNext = true;
            }
            public override State Next(char c)
            {
                State nextState = this;
                if ('0' <= c && c <= '9')
                {
                    RequiresNext = false;
                }
                else if (c == '+' || c == '-')
                {
                    nextState = new LeadingSignExponentState();
                }
                else
                {
                    throw new Exception($"InvalidState {c} from ExponentState");
                }
                return nextState;
            }
        }

        public class LeadingSignExponentState : State
        {

            public LeadingSignExponentState()
            {
                RequiresNext = true;
            }

            public override State Next(char c)
            {
                State nextState = this;
                if ('0' <= c && c <= '9')
                {
                    RequiresNext = false;
                }
                else
                {
                    throw new Exception($"InvalidState {c} from LeadingSignExponentState");
                }
                return nextState;
            }
        }

        public class StateMachine
        {
            State _currentState = new InitialState();

            public bool IsValid(string s)
            {
                s = s.Trim(' ');
                if (s == "")
                {
                    return false;
                }

                for (var i = 0; i < s.Length; i++)
                {
                    try
                    {
                        _currentState = _currentState.Next(s[i]);

                        if (_currentState.RequiresNext && i == s.Length - 1)
                        {
                            return false;
                        }
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
