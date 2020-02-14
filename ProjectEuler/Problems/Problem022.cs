using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectEuler.Problems
{
    [Problem(22)]
    internal class Problem022 : IProblem
    {
        public object Solve() => this.ParseInput()
            .OrderBy(name => name)
            .Select(ComputeValue)
            .Select((value, i) => value * (i + 1))
            .Sum();

        private IEnumerable<string> ParseInput()
        {
            using var stream = Resources.Open("Problem22.txt");
            using var sr = new StreamReader(stream);
            return sr.ReadToEnd().Split(',');
        }

        private static int ComputeValue(string name) => name.Select(ch => ch % 32).Sum();
    }
}
