using System;
using System.Linq;

namespace ProjectEuler.Problems
{
    [Problem(19)]
    internal class Problem019 : IProblem
    {
        public object Solve() => Enumerable.Range(1901, 100)
            .SelectMany(year => Enumerable.Range(1, 12).Select(month => new DateTime(year, month, 1)))
            .Where(date => date.DayOfWeek == DayOfWeek.Sunday)
            .Count();
    }
}
