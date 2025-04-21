namespace Who.Said.It.Server.Services.Interfaces
{
    /// <summary>
    /// Service to convert PDF files to text.
    /// </summary>
    public interface IPdfToTextService
    {
        /// <summary>
        /// Converts a PDF file to text.
        /// </summary>
        /// <param name="filePath">file Path.</param>
        /// <returns>String representation of text from pdf.</returns>
        string GetTextFromPdf(string filePath);
    }
}
