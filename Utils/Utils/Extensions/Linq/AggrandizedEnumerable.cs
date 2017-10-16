using System;
using System.Collections.Generic;

namespace Lokf.Utils.Extensions.Linq
{
    /// <summary>
    /// Provides extension methods for <see cref="IEnumerable{T}"/>.
    /// </summary>
    public static class AggrandizedEnumerable
    {
        /// <summary>
        /// Executes the given action on each element in the given sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of elements in the given sequence.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="action">The action to execute on each element.</param>
        public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));           
            if (action == null) throw new ArgumentNullException(nameof(source));            

            foreach (var element in source)
            {
                action(element);
            }
        }
    }
}
