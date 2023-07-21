using Magicodes.ExporterAndImporter.Pdf;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Core.Extensions
{
    internal static class Dependencies
    {
        internal static IServiceProvider BuildServices()
        {
            var serviceCollection = new ServiceCollection();
            return serviceCollection.BuildServiceProvider();
        }

        static IHost RegisterDependencies()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IPdfExporter, PdfExporter>();
                }).Build();
        }

        internal static PdfExporter GetPdfExporter()
        {
            return ActivatorUtilities.CreateInstance<PdfExporter>(RegisterDependencies().Services);
        }
    }
}