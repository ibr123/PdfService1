using Core.Extensions;
using Core.Interfaces;
using Magicodes.ExporterAndImporter.Core.Models;
using Magicodes.ExporterAndImporter.Pdf;
using Microsoft.Extensions.Configuration;

namespace Core.Services
{
    public class PdfGenerics<Type, ReturnType> : IPdfGenericsMagicodes<Type, ReturnType>
        where Type : class
        where ReturnType : ExportFileInfo
    {
        const string ResultPath = @"C:\Users\i.abuhamdeh.ext\Documents\PDF Results\";
        private readonly IPdfExporter _pdfExporter = Dependencies.GetPdfExporter();

        public async Task<ReturnType> CreatePdf(ICollection<Type> data, string fileName)
        {
            try
            {
                var resultPath = Configurations.GetIConfigurationRoot().GetValue<string>("Data:resultPath");
                var result = await _pdfExporter.ExportListByTemplate(Path.Combine(resultPath, fileName), data);
                return (ReturnType)result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
