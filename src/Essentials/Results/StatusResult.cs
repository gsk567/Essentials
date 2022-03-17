namespace Essentials.Results
{
    /// <summary>
    /// Result type that provides generic status and message.
    /// </summary>
    /// <typeparam name="TStatus">Type of the status.</typeparam>
    public class StatusResult<TStatus>
    {
        private StatusResult(TStatus status, string message = null)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Result status.
        /// </summary>
        public TStatus Status { get; }

        /// <summary>
        /// Result message.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Returns status result from general input.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static StatusResult<TStatus> ResultFrom(TStatus status, string message = null) =>
            new StatusResult<TStatus>(status, message);
    }
}