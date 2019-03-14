using System;

namespace LeetCodeProjects
{
    public class DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }

            var sign = ((dividend > 0 && divisor < 0) || (dividend < 0 && divisor > 0)) ? -1 : 1;

            var lDividend = Math.Abs((long)dividend);
            var lDivisor = Math.Abs((long)divisor);

            if (dividend == 0 || lDividend < lDivisor)
            {
                return 0;
            }

            var res = sign * Math.Abs(Helper(lDividend, lDivisor));

            if (res >= int.MaxValue)
            {
                return int.MaxValue;
            }
            if (res <= int.MinValue)
            {
                return int.MinValue;
            }

            return (int)res;
        }

        private long Helper(long dividend, long divisor)
        {
            if (dividend < divisor) return 0;

            var sum = divisor;
            var multiple = 1;
            while ((sum + sum) <= dividend)
            {
                sum += sum;
                multiple += multiple;
            }
            
            return multiple + Helper(dividend - sum, divisor);
        }
    }
}
