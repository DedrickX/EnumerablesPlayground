using System.Collections.Generic;
using System.Linq;


namespace EnumerableDemo
{
    public static class IEnumerableExtensions
    {

        /// <summary>
        /// Funkcia overí, či má kolekcia väčší počet položiek než zadané číslo.
        /// </summary>
        public static bool HasMoreThan<T>(this IEnumerable<T> items, int count) =>
            items
                .Skip(count)
                .Any();

    }
}
