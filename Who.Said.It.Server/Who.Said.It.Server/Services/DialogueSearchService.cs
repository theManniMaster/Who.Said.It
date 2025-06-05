using Who.Said.It.Server.Services.Interfaces;

namespace Who.Said.It.Server.Services
{
    /// <summary>
    /// Implementation of a service to search dialogues in movie scripts.
    /// </summary>
    public class DialogueSearchService : IDialogueSearchService
    {
        /// <inheritdoc />
        public Task<IEnumerable<string>> SearchTopNDialoguesAsync(string searchTerm, int resultCount, CancellationToken token)
        {
            return Task.FromResult((new List<string> {  }).Where(i => i.Contains(searchTerm)));
        }
    }
}
