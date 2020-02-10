using System;
using System.IO;
using System.Linq;
using System.Numerics;

namespace ProjectEuler.Problems
{
    [Problem(1)]
    internal class Problem001 : IProblem
    {
        public object Solve() => Enumerable.Range(0, 1000).Where(t => t % 3 == 0 || t % 5 == 0).Sum();
    }

    [Problem(2)]
    internal class Problem002 : IProblem
    {
        public object Solve() => Calculate.Fibonacci().TakeWhile(t => t < 4_000_000).Where(t => t % 2 == 0).Sum();
    }

    [Problem(15)]
    internal class Problem015 : IProblem
    {
        public object Solve() => Calculate.BinomialCoefficient(40, 20);
    }

    [Problem(16)]
    internal class Problem016 : IProblem
    {
        public object Solve() => Calculate.DigitSum(BigInteger.Pow(2, 1000));
    }

    [Problem(17)]
    internal class Problem017 : IProblem
    {
        public object Solve() => Enumerable.Range(1, 1000).SelectMany(n => Number.ToText(n)).Where(ch => ch != ' ' && ch != '-').LongCount();
    }

    [Problem(18)]
    internal class Problem018 : IProblem
    {
        public object Solve()
        {
            var array = this.ReadArray();

            for (var i = array.GetLength(0) - 2; i >= 0; i--)
            {
                for (var j = 0; j <= i; j++)
                {
                    array[i, j] += Math.Max(array[i + 1, j], array[i + 1, j + 1]);
                }
            }

            return array[0, 0];
        }

        private int[,] ReadArray()
        {
            var array = new int[15, 15];
            using var stream = Resources.Open("Problem18.txt");
            using var sr = new StreamReader(stream);

            var i = 0;
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                var parts = line.Split(' ');
                for (var j = 0; j < parts.Length; j++)
                {
                    array[i, j] = int.Parse(parts[j]);
                }
                i++;
            }

            return array;
        }
    }

    [Problem(19)]
    class Problem019 : IProblem
    {
        public object Solve() => Enumerable.Range(1901, 100)
            .SelectMany(year => Enumerable.Range(1, 12).Select(month => new DateTime(year, month, 1)))
            .Where(date => date.DayOfWeek == DayOfWeek.Sunday)
            .Count();
    }

    [Problem(20)]
    class Problem020 : IProblem
    {
        public object Solve() => Calculate.DigitSum(Calculate.Factorial(new BigInteger(100)));
    }
}
