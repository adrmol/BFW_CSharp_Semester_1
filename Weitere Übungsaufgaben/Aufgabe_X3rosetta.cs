using static System.Console;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Weitere_Übungsaufgaben
{
    internal class Aufgabe_X3rosetta
    {
        public static void Start()
        {
            const int limit = 1_000_000_000;
            WriteLine("Lower than 1_000_000_000:");
            WriteLine(FindEmirpPrimes(limit).Take(172279600).Delimit());
            WriteLine();
        }

        private static IEnumerable<int> FindEmirpPrimes(int limit)
        {
            var primes = Primes(limit).ToHashSet();

            foreach (int prime in primes)
            {
                int reverse = prime.Reverse();
                if (reverse != prime && primes.Contains(reverse)) yield return prime;
            }
        }

        private static IEnumerable<int> Primes(int bound)
        {
            if (bound < 2) yield break;
            yield return 2;

            BitArray composite = new BitArray((bound - 1) / 2);
            int limit = ((int)(Math.Sqrt(bound)) - 1) / 2;
            for (int i = 0; i < limit; i++)
            {
                if (composite[i]) continue;
                int prime = 2 * i + 3;
                yield return prime;

                for (int j = (prime * prime - 2) / 2; j < composite.Count; j += prime)
                    composite[j] = true;
            }
            for (int i = limit; i < composite.Count; i++)
                if (!composite[i]) yield return 2 * i + 3;
        }
    }

    public static class Extensions
    {
        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source) => new HashSet<T>(source);

        private const string defaultSeparator = " ";
        public static string Delimit<T>(this IEnumerable<T> source, string separator = defaultSeparator) =>
            string.Join(separator ?? defaultSeparator, source);

        public static int Reverse(this int number)
        {
            if (number < 0) return -Reverse(-number);
            if (number < 10) return number;
            int reverse = 0;
            while (number > 0)
            {
                reverse = reverse * 10 + number % 10;
                number /= 10;
            }
            return reverse;
        }
    }
}
