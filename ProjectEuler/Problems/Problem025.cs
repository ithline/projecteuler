using System.Numerics;

namespace ProjectEuler.Problems
{
    [Problem(25)]
    internal class Problem025 : IProblem
    {
        public object Solve()
        {
            var i = 2;
            var a = BigInteger.One;
            var b = BigInteger.One;
            var limit = BigInteger.Pow(10, 999);
            while (b < limit)
            {
                var temp = a + b;
                a = b;
                b = temp;
                i++;
            }
            return i;
        }
    }
}
