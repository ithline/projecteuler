using System;
using System.Linq;

namespace ProjectEuler.Problems
{
    [Problem(24)]
    internal class Problem024 : IProblem
    {
        private const int N = 10;

        public object Solve()
        {
            var set = Enumerable.Range(0, N).ToList();
            var result = "";
            var remain = 999_999;

            for (var i = 1; i < N && remain > 0; i++)
            {
                // vypocitame kolko moznosti mame ked prve cislo je dane
                // to nam da rozmedzia v ktorych kazde zaciatocne cislo obsahuje permutacie
                var factorial = Calculate.Factorial(N - i);

                // vypocitame kolke cislo potrebujeme zo zoznamu a kolko moznosti sme vzdialeni od vysledku
                // ktory musime dosiahnut preusporiadanim zvysnych cisel
                var index = Math.DivRem(remain, factorial, out remain);
                result += set[index];
                set.RemoveAt(index);
            }

            result += string.Join("", set);
            return result;
        }
    }
}
