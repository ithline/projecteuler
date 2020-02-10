using System;
using System.Collections.Generic;
using System.Numerics;

namespace ProjectEuler
{
    internal static class Calculate
    {
        public static IEnumerable<long> Fibonacci()
        {
            long a = 1;
            long b = 2;
            yield return a;
            while (true)
            {
                var c = a + b;
                a = b;
                b = c;
                yield return a;
            }
        }

        public static long BinomialCoefficient(in long n, in long k)
        {
            if (k < 0 || k > n) return 0;
            if (k == 0 || k == n) return 1;

            var r = 1L;
            var c = Math.Min(k, n - k);
            for (var i = 0; i < c; i++)
            {
                r = r * (n - i) / (i + 1);
            }
            return r;
        }

        public static long DigitSum(BigInteger n)
        {
            long result = 0;
            while (n != 0)
            {
                n = BigInteger.DivRem(n, 10, out var rem);
                result += (long)rem;
            }
            return result;
        }

        public static BigInteger Factorial(BigInteger n)
        {
            if (n < 2) return 1;
            var result = BigInteger.One;
            while (n > 1)
            {
                result *= n--;
            }
            return result;
        }
    }
}
