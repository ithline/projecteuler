using System;
using System.Linq;
using System.Reflection;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.Write("Vyberte problem: ");
                var input = Console.ReadLine();
                if (int.TryParse(input, out var number) && TryGetProblem(number, out var problem))
                {
                    Console.WriteLine(problem.Solve());
                }
                else
                {
                    Console.WriteLine("Neplatny vstup.");
                }
                Console.WriteLine("Pokracovat? a/[n]");
            } 
            while (Console.ReadKey().Key == ConsoleKey.A);
        }

        private static bool TryGetProblem(int number, out IProblem problem)
        {
            var type = typeof(Program).Assembly
                .DefinedTypes
                .FirstOrDefault(t => t.GetCustomAttribute<ProblemAttribute>()?.Number == number);
            if (type != null)
            {
                problem = (IProblem)Activator.CreateInstance(type.AsType());
                return true;
            }
            problem = null;
            return false;
        }
    }
}
