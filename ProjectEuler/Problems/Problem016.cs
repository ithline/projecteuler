using System.Numerics;

namespace ProjectEuler.Problems
{
    [Problem(16)]
    internal class Problem016 : IProblem
    {
        public object Solve() => Calculate.DigitSum(BigInteger.Pow(2, 1000));
    }
}
