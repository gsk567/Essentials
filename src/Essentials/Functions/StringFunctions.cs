﻿using System.Collections.Generic;
using System.Linq;

namespace Essentials.Functions
{
    /// <summary>
    /// Essential string functions.
    /// </summary>
    public static class StringFunctions
    {
        /// <summary>
        /// Splits pascal case string to separate words.
        /// </summary>
        /// <param name="stringValue"></param>
        /// <returns></returns>
        public static string SplitStringByCapitalLetters(string stringValue)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
            {
                return string.Empty;
            }

            return stringValue.Aggregate(string.Empty, (result, next) =>
            {
                if (char.IsUpper(next) &&
                    result.Length > 1 &&
                    result.Last() != ' ' &&
                    !char.IsUpper(result.Last()))
                {
                    result += ' ';
                }

                if (result.Length > 2 &&
                    char.IsUpper(result.ElementAt(result.Length - 2)) &&
                    char.IsUpper(result.Last()) &&
                    char.IsLower(next))
                {
                    result = result.Insert(result.Length - 1, " ");
                }

                return result + next;
            });
        }

        /// <summary>
        /// Convert pascal case word into a key format word (upper and snake case).
        /// </summary>
        /// <param name="stringValue"></param>
        /// <returns></returns>
        public static string ConvertToKey(string stringValue)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
            {
                return string.Empty;
            }

            var wordsElements = stringValue.Split('_');
            var resultKeysComponents = new List<string>();
            foreach (var wordsElement in wordsElements)
            {
                string processedWordsElement = SplitStringByCapitalLetters(ClearMultipleIntervals(wordsElement)).Replace(" ", "_");
                string key = processedWordsElement.Aggregate(string.Empty, (result, next) =>
                {
                    if (result.Length > 1 && next == '_')
                    {
                        return result + next;
                    }

                    if (char.IsUpper(next) &&
                        result.Length > 1 &&
                        result.Last() != '_' &&
                        !char.IsUpper(result.Last()))
                    {
                        result += '_';
                    }

                    if (result.Length > 1 && result.Last() == next && next == '_')
                    {
                        return result;
                    }

                    return result + next;
                });

                resultKeysComponents.Add(key?.ToUpper() ?? string.Empty);
            }

            return string.Join("_", resultKeysComponents.Where(x => !string.IsNullOrEmpty(x)));
        }

        /// <summary>
        /// Trim useless intervals from a string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ClearMultipleIntervals(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                return " ";
            }

            return value.Aggregate(string.Empty, (result, next) =>
            {
                if (result.Length > 1 &&
                    result.Last() == ' ' &&
                    next == ' ')
                {
                    return result;
                }

                return result + next;
            });
        }
    }
}