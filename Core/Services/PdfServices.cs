using Core.Models;
using Magicodes.ExporterAndImporter.Pdf;

namespace Core.Services
{
    public class PdfServices
    {
        [STAThread]
        public async Task ExportPdf()
        {
            try
            {
                PdfExporter exporter = new PdfExporter();
                List<Car> cars = new List<Car>
                {
                    new Car() { Brand = "BMW", Model = 1990, IsSedan = true },
                    new Car() { Brand = "Kia", Model = 2000, IsSedan = true }
                };

                var result = await exporter.ExportListByTemplate(@"C:\Users\i.abuhamdeh.ext\Documents\PDF Results\Default2.pdf", cars);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
