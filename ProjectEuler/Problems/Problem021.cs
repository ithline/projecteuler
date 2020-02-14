namespace ProjectEuler.Problems
{
    [Problem(21)]
    internal class Problem021 : IProblem
    {
        public object Solve()
        {
            var sum = 0L;
            for (long a = 1; a < 10_000; a++)
            {
                var b = Calculate.DivisorSum(a);
                if (a < b && Calculate.DivisorSum(b) == a)
                {
                    sum += a;
                    sum += b;
                }
            }
            return sum;
        }
    }
}
