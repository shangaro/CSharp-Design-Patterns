using EnsureThat;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Linq
{
    public static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action) where T : class
        {
            EnsureArg.IsNotNull(enumerable, nameof(enumerable));
            foreach (T item in enumerable)
            {
                action(item);
            }
        }
    }
}