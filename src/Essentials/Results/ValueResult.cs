namespace Essentials.Results
{
    /// <summary>
    /// Result type that is designed to provides value in the form of object.
    /// </summary>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    public class ValueResult<TValue>
    {
        private ValueResult(TValue value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Result value.
        /// </summary>
        public TValue Value { get; }

        /// <summary>
        /// Returns value result from general input.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ValueResult<TValue> ResultFrom(TValue value) => new ValueResult<TValue>(value);
    }
}