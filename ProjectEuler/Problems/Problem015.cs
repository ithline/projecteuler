namespace ProjectEuler.Problems
{
    [Problem(15)]
    internal class Problem015 : IProblem
    {
        public object Solve() => Calculate.BinomialCoefficient(40, 20);
    }
}
