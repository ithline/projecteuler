using System.Linq;

namespace ProjectEuler.Problems
{
    [Problem(23)]
    internal class Problem023 : IProblem
    {
        public object Solve()
        {
            const int upperLimit = 28123;
            var abundantNumbers = Enumerable.Range(1, upperLimit)
                .Where(t => Calculate.DivisorSum(t) > t)
                .ToList()
                .AsReadOnly();

            var sums = abundantNumbers
                .SelectMany(_ => abundantNumbers, (a, b) => a + b)
                .ToHashSet();

            return Enumerable.Range(1, upperLimit).Where(t => !sums.Contains(t)).Sum();
        }
    }
}
