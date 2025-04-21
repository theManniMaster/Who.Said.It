using Docnet.Core.Models;
using Docnet.Core;
using System.Text;
using Who.Said.It.Server.Services.Interfaces;

namespace Who.Said.It.Server.Services
{
    /// <summary>
    /// Implementation.
    /// </summary>
    public class PdfToTextService : IPdfToTextService
    {
        /// <inheritdoc />
        public string GetTextFromPdf(string filePath)
        {
            string basePath = AppContext.BaseDirectory;
            string combinedPathFromBase = Path.Combine(basePath, "MovieScripts", filePath);

            var sb = new StringBuilder();

            if (File.Exists(combinedPathFromBase))
            {
                using var docReader = DocLib.Instance.GetDocReader(combinedPathFromBase, new PageDimensions());

                for (var i = 0; i < docReader.GetPageCount(); i++)
                {
                    using var pageReader = docReader.GetPageReader(i);

                    var text = pageReader.GetText();
                    sb.Append(text);
                }
            }

            return sb.ToString();
        }
    }
}
