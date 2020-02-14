using System.Linq;

namespace ProjectEuler.Problems
{
    [Problem(2)]
    internal class Problem002 : IProblem
    {
        public object Solve() => Calculate.Fibonacci().TakeWhile(t => t < 4_000_000).Where(t => t % 2 == 0).Sum();
    }
}
