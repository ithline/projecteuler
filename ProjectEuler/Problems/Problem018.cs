using System;
using System.IO;

namespace ProjectEuler.Problems
{
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
}
