using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Essentials.Results
{
    /// <summary>
    /// Result that contains collection of pairs represented by a key and a value.
    /// Result is object representation of dictionary.
    /// </summary>
    /// <typeparam name="TKey">Type of the key.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    public class KeyValuePairsResult<TKey, TValue>
    {
        private KeyValuePairsResult(IDictionary<TKey, TValue> dictionary)
        {
            var pairs = dictionary.Select(x => new KeyValuePair<TKey, TValue>(x.Key, x.Value));
            this.Pairs = new ReadOnlyCollection<KeyValuePair<TKey, TValue>>(pairs.ToList());
        }

        /// <summary>
        /// Collection of all items in the result.
        /// </summary>
        public IEnumerable<KeyValuePair<TKey, TValue>> Pairs { get; }

        /// <summary>
        /// Returns key value items result from general input.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static KeyValuePairsResult<TKey, TValue> ResultFrom(IDictionary<TKey, TValue> dictionary) =>
            new KeyValuePairsResult<TKey, TValue>(dictionary);
    }
}