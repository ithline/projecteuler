using System.Linq;

namespace ProjectEuler.Problems
{
    [Problem(1)]
    internal class Problem001 : IProblem
    {
        public object Solve() => Enumerable.Range(0, 1000).Where(t => t % 3 == 0 || t % 5 == 0).Sum();
    }
}
