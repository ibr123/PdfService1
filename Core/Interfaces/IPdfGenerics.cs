using Magicodes.ExporterAndImporter.Core.Models;

namespace Core.Interfaces
{
    public interface IPdfGenerics<Type, ReturnType>
    {
        Task<ReturnType> CreatePdf(ICollection<Type> data, string fileName);
    }
}
