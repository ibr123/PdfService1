using Core.Models;
using Core.Services;
using Magicodes.ExporterAndImporter.Core.Models;


///template by path
//HtmlTemplate template = new HtmlTemplate();
//await template.ExportHtmlReceipt();

///default
//PdfServices asdf = new PdfServices();
//asdf.ExportPdf();

List<Car> cars = new List<Car>
{
    new Car() { Brand = "BMW", Model = 1990, IsSedan = true },
    new Car() { Brand = "Kia", Model = 2000, IsSedan = true }
};

//List<Students> students = new List<Students>()
//{
//    new Students{ Name="Student 1", Age=15},
//    new Students {Name="Student 2", Age=16}
//};


PdfGenerics<Car, ExportFileInfo> genericsCars = new PdfGenerics<Car, ExportFileInfo>();
var result = await genericsCars.CreatePdf(cars, "GenericDataSetCars.pdf");


//PdfGenerics<Students, ExportFileInfo> genericsStudent = new PdfGenerics<Students, ExportFileInfo>();
//var result2 = await genericsStudent.CreatePdf(students, "GenericDataSetStudents.pdf");


