using System.Linq;

namespace ProjectEuler.Problems
{
    [Problem(17)]
    internal class Problem017 : IProblem
    {
        public object Solve() => Enumerable.Range(1, 1000).SelectMany(n => Number.ToText(n)).Where(ch => ch != ' ' && ch != '-').LongCount();
    }
}
