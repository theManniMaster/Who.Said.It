namespace Who.Said.It.Server.Services.Interfaces
{
    /// <summary>
    /// Service to search dialogues in movie scripts.
    /// </summary>
    public interface IDialogueSearchService
    {
        /// <summary>
        /// Searches for dialogues in movie scripts.
        /// </summary>
        /// <param name="searchTerm">The term to search for.</param>
        /// <param name="resultCount">Number of results to return.</param>
        /// <param name="token">Cancellation token to cancel the operation.</param>
        /// <returns>A list of top {resultCount} dialogues that match the search term.</returns>
        Task<IEnumerable<string>> SearchTopNDialoguesAsync(string searchTerm, int resultCount, CancellationToken token);
    }
}
