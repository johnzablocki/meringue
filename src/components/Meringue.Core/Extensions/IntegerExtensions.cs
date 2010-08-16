using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meringue.Core.Extensions {
    public static class IntegerExtensions {

        /// <summary>
        /// Create an array of ints from the lowerBound to upperBound
        /// </summary>
        /// <param name="lowerBound">Inclusive lower bound</param>
        /// <param name="upperBound">Inclusive upper bound</param>
        /// <returns></returns>
        public static int[] To(this int start, int end) {
            int[] ints = null;

            if (start < end) {
                ints = new int[end];
                for (int i = 0; i < end; i++) {
                    ints[i] = start++;
                }
            } else if (start > end) {
                ints = new int[start];
                for (int i = start-1, j=0; i >= 0; i--, j++) {
                    ints[j] = start--;
                }
            } else {
                ints = new int[] { start };
            }

            return ints;
        }       
    }
}
