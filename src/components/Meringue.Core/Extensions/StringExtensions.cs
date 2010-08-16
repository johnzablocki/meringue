using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meringue.Core.Extensions {
    public static class StringExtensions {

        /// <summary>
        /// Get a substring of the source string, starting with the first character
        /// </summary>
        /// <param name="source">Source string</param>
        /// <param name="numberOfCharacters">Number of characters to include</param>
        /// <returns>New string with the first n characters</returns>
        public static string Left(this string source, int numberOfCharacters) {
            return source.leftOrRight(numberOfCharacters, 0);
        }

        /// <summary>
        /// Get a substring of the source string, starting with the last character
        /// </summary>
        /// <param name="source">Source string</param>
        /// <param name="numberOfCharacters">Number of characters to include</param>
        /// <returns>New string with the last n characters</returns>
        public static string Right(this string source, int numberOfCharacters) {
            return source.leftOrRight(numberOfCharacters, source.Length - numberOfCharacters);
        }


        //trims left or right based on starting point
        private static string leftOrRight(this string source, int numberOfCharacters, int whereToStart) {
            if (source.Length < numberOfCharacters || source.Length == 0) {
                return source;
            } else { 
                return source.Substring(whereToStart, numberOfCharacters);
            }
        }
    }
}
