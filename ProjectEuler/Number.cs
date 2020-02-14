using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    internal static class Number
    {
        private static readonly IReadOnlyDictionary<long, string> lookup = new Dictionary<long, string>
        {
            [1] = "one",
            [2] = "two",
            [3] = "three",
            [4] = "four",
            [5] = "five",
            [6] = "six",
            [7] = "seven",
            [8] = "eight",
            [9] = "nine",
            [10] = "ten",
            [11] = "eleven",
            [12] = "twelve",
            [13] = "thirteen",
            [14] = "fourteen",
            [15] = "fifteen",
            [16] = "sixteen",
            [17] = "seventeen",
            [18] = "eighteen",
            [19] = "nineteen",
            [20] = "twenty",
            [30] = "thirty",
            [40] = "forty",
            [50] = "fifty",
            [60] = "sixty",
            [70] = "seventy",
            [80] = "eighty",
            [90] = "ninety",
        };

        public static string ToText(long number)
        {
            if (lookup.TryGetValue(number, out var text))
            {
                return text;
            }

            if (number == 0)
            {
                return "";
            }

            if (number < 100)
            {
                var rem = number % 10;
                return ToText(number - rem) + " " + ToText(rem);
            }
            if (number < 1000)
            {
                var n = Math.DivRem(number, 100, out var rem);
                if (rem > 0)
                {
                    return ToText(n) + " hundred and " + ToText(rem);
                }
                return ToText(n) + " hundred";
            }
            if (number < 1000000)
            {
                var n = Math.DivRem(number, 1000, out var rem);
                if (rem > 0)
                {
                    return ToText(n) + "thousand " + ToText(rem);
                }
                return ToText(n) + " thousand";
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}
