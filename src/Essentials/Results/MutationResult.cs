namespace Essentials.Results
{
    /// <summary>
    /// Result type that provides the identifier entity that participate in mutation operation and message.
    /// </summary>
    public class MutationResult
    {
        private MutationResult(object mutatedEntityId, string message = null)
        {
            this.MutatedEntityId = mutatedEntityId;
            this.Message = message;
        }

        /// <summary>
        /// Id of the mutated entity.
        /// </summary>
        public object MutatedEntityId { get; }

        /// <summary>
        /// Flat that indicates whether the result is successful or not.
        /// </summary>
        public bool Succeeded => !string.IsNullOrWhiteSpace(this.MutatedEntityId?.ToString());

        /// <summary>
        /// Result message.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Returns mutation result from general input.
        /// </summary>
        /// <param name="mutatedEntityId"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static MutationResult ResultFrom(object mutatedEntityId, string message = null) =>
            new MutationResult(mutatedEntityId, message);
    }
}