using Magicodes.ExporterAndImporter.Pdf;
using ServiceCore.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ServiceCore
{
    public class HtmlTemplate
    {
        public async Task ExportHtmlReceipt()
        {
            try
            {
                string tplPath = @"C:\Users\i.abuhamdeh.ext\Documents\HtmlTemplate.html";
                var tpl = File.ReadAllText(tplPath);
                var exporter = new PdfExporter();

                var result = await exporter.ExportByTemplate("test.pdf",
                    new ReceiptInfo
                    {
                        Amount = 22939.43M,
                        Grade = "2019秋",
                        IdNo = "43062619890622xxxx",
                        Name = "Name 1",
                        Payee = "payee name",
                        PaymentMethod = "Cash",
                        Profession = "worker",
                        Remark = "nothing",
                        TradeStatus = "good",
                        TradeTime = DateTime.Now,
                        UppercaseAmount = "normal",
                        Code = "19071800001"
                    }, tpl);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
