using System.Numerics;

namespace ProjectEuler.Problems
{
    [Problem(20)]
    internal class Problem020 : IProblem
    {
        public object Solve() => Calculate.DigitSum(Calculate.Factorial(new BigInteger(100)));
    }
}
