namespace Essentials.Results
{
    /// <summary>
    /// Result type that provides boolean status and message.
    /// </summary>
    public class StandardResult
    {
        private StandardResult(bool succeeded, string message = null)
        {
            this.Succeeded = succeeded;
            this.Message = message;
        }

        /// <summary>
        /// Flat that indicates whether the result is successful or not.
        /// </summary>
        public bool Succeeded { get; }

        /// <summary>
        /// Result message.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Returns standard result from general input.
        /// </summary>
        /// <param name="succeeded"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static StandardResult ResultFrom(bool succeeded, string message = null) =>
            new StandardResult(succeeded, message);

        /// <summary>
        /// Returns successful standard result.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static StandardResult SuccessfulResult(string message = null) => ResultFrom(true, message);

        /// <summary>
        /// Returns unsuccessful standard result.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static StandardResult UnsuccessfulResult(string message = null) => ResultFrom(false, message);
    }
}