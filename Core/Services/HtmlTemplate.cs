using Core.Models;
using Magicodes.ExporterAndImporter.Pdf;

namespace Core.Services
{
    public class HtmlTemplate
    {
        const string ResultPath = @"C:\Users\i.abuhamdeh.ext\Documents\PDF Results\";

        [STAThread]
        public async Task ExportHtmlReceipt()
        {
            try
            {
                string resultPdfPath = "testHtmlttah.pdf";
                //string tplPath = @"C:\Users\i.abuhamdeh.ext\Documents\HtmlTemplate.html";
                string tplPath = @"C:\Users\i.abuhamdeh.ext\Documents\InvoiceHtml.html";                
                var tpl = File.ReadAllText(tplPath);
                var exporter = new PdfExporter();

                DataToPass dataToPass = new DataToPass()
                {
                    Title = "Data to pass test",
                    Amount = 100,
                    Code = "Ng120990",
                    Grade = "Medium",
                    IdNo = "1040639",
                    Name = "Html PDF",
                    Payee = "Mr.Me",
                    PaymentMethod = "Visa",
                    Profession = "Empror",
                    Remark = "Good",
                    TradeStatus = "Approved",
                    TradeTime = DateTime.Now,
                    UppercaseAmount = "don't know what it means",
                    
                };

                DataToPass dataToPassAr = new DataToPass()
                {
                    Title = "معلومات للاستعمال",
                    Amount = 100,
                    Code = "Ng120990",
                    Grade = "متوسط متوسط متوسط متوسط متوسط",
                    IdNo = "1040639",
                    Name = "Html PDF",
                    Payee = "Mr.Me",
                    PaymentMethod = "فيزا",
                    Profession = "موظف",
                    Remark = "جيد",
                    TradeStatus = "موافق",
                    TradeTime = DateTime.Now,
                    UppercaseAmount = "غير معروف"
                };

                var result = await exporter.ExportByTemplate(Path.Combine(ResultPath, resultPdfPath), dataToPass, tpl);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        [STAThread]
        public async Task BatchExportReceipt()
        {
            try
            {
                string resultPdfPath = "HtmlList.pdf";
                string tplPath = @"C:\Users\i.abuhamdeh.ext\Documents\HtmlList.html";
                var tpl = File.ReadAllText(tplPath);
                var exporter = new PdfExporter();

                DataToPass dataToPass = new DataToPass()
                {
                    Title = "Data to pass test",
                    Amount = 100,
                    Code = "Ng120990",
                    Grade = "Medium",
                    IdNo = "1040639",
                    Name = "Html PDF",
                    Payee = "Mr.Me",
                    PaymentMethod = "Visa",
                    Profession = "Empror",
                    Remark = "Good",
                    TradeStatus = "Approved",
                    TradeTime = DateTime.Now,
                    UppercaseAmount = "don't know what it means"
                };

                var inputList = new DataList()
                {
                    Payee = "asdf",
                    DataToPassList = new List<DataToPass>()
                };

                inputList.DataToPassList.Add(dataToPass);
                inputList.DataToPassList.Add(dataToPass);

                var result = await exporter.ExportByTemplate(Path.Combine(ResultPath, resultPdfPath), inputList, tpl);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
