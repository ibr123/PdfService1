using Magicodes.ExporterAndImporter.Core.Models;

namespace Core.Interfaces
{
    public interface IPdfGenericsMagicodes<Type, ReturnType> : IPdfGenerics<Type, ReturnType>
        where Type : class
        where ReturnType : ExportFileInfo
    {
    }
}