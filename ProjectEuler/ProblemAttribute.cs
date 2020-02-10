using System;

namespace ProjectEuler
{
    internal sealed class ProblemAttribute : Attribute
    {
        public ProblemAttribute(int number)
        {
            Number = number;
        }

        public int Number { get; }
    }
}
