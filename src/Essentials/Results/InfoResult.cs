namespace Essentials.Results
{
    /// <summary>
    /// Result type that is designed to provides information only.
    /// </summary>
    public class InfoResult
    {
        private InfoResult(string message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Result message.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Returns info result from general input.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static InfoResult ResultFrom(string message) => new InfoResult(message);
    }
}