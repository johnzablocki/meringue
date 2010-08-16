using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meringue.Core.Extensions {
    public static class IEnumerableExtensions {

        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action) {
            foreach (var item in source) {
                action(item);
            }
        }

        public static void TryForEach<T>(this IEnumerable<T> source, Action<T> action, Action<Exception> exHandler) {
            foreach (var item in source) {
                try {
                    action(item);
                } catch (Exception ex) {
                    exHandler(ex);
                }
            }
        }
    }
}
