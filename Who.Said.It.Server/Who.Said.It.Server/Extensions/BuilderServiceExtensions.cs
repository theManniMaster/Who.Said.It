using Who.Said.It.Server.Services.Interfaces;
using Who.Said.It.Server.Services;
using MudBlazor.Services;

namespace Who.Said.It.Server.Extensions
{
    public static class BuilderServiceExtensions
    {
        /// <summary>
        /// Extension method to add services to the service collection.
        /// </summary>
        /// <param name="services">Services</param>
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddRazorComponents().AddInteractiveServerComponents();

            services.AddMudServices();

            services.AddSingleton<IPreprocessorService, PreprocessorService>();

            services.AddTransient<IPdfToTextService, PdfToTextService>();
            services.AddTransient<IDialogueSearchService, DialogueSearchService>();
        }
    }
}
