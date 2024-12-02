using System;
using System.Linq;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            return Enumerable.Range(1, n).Aggregate(1, (x, y) => { checked { return x * y; } });

            //if (n < 0 || n > 12) 
            //{ 
            //    throw new ArgumentOutOfRangeException(nameof(n));
            //}

            //if (n == 1 || n==0)
            //{
            //    return 1;
            //}

            //return GetFactorial(n-1) * n;
        }

        public static string FormatSeparators(params string[] items) 
        {
            var filteredItems = items.Where(i => !string.IsNullOrWhiteSpace(i)).ToList();

            if(filteredItems.Count <= 1)
            {
                return "";
            }

            if(filteredItems.Count == 1)
            {
                return filteredItems.First();
            }

            if(filteredItems.Count > 1)
            {
                return $"{string.Join(", ", filteredItems.SkipLast(1))} and {filteredItems.Last()}";
            }

            return "";
        }
    }
}