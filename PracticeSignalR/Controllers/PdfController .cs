using DinkToPdf.Contracts;
using DinkToPdf;
using Microsoft.AspNetCore.Mvc;
using PracticeSignalR.Models;
using PracticeSignalR.Services;
using Newtonsoft.Json;
using static PracticeSignalR.Models.ChartPoint;

namespace PracticeSignalR.Controllers
{
    public class PdfController : Controller
    {
        //private readonly IConverter _pdfConverter;

        //public PdfController(IConverter pdfConverter)
        //{
        //    _pdfConverter = pdfConverter;
        //}

        //public IActionResult GeneratePdf()
        //{
        //    var employee = new Employee
        //    {
        //        Id = 1,
        //        FirstName = "John",
        //        LastName = "Doe"
        //    };

        //    var htmlContent = $@"
        //    <html>
        //        <head>
        //            <title>Employee Information</title>
        //        </head>
        //        <body>
        //            <h1>Employee Information</h1>
        //            <p>ID: {employee.Id}</p>
        //            <p>First Name: {employee.FirstName}</p>
        //            <p>Last Name: {employee.LastName}</p>
        //        </body>
        //    </html>
        //";

        //    var globalSettings = new GlobalSettings
        //    {
        //        ColorMode = ColorMode.Color,
        //        Orientation = Orientation.Portrait,
        //        PaperSize = PaperKind.A4,
        //        Margins = new MarginSettings { Top = 10, Bottom = 10 }
        //    };

        //    var objectSettings = new ObjectSettings
        //    {
        //        PagesCount = true,
        //        HtmlContent = htmlContent,
        //        WebSettings = { DefaultEncoding = "utf-8" },
        //        HeaderSettings = { FontName = "Arial", FontSize = 12, Right = "Page [page] of [toPage]", Line = true },
        //        FooterSettings = { FontName = "Arial", FontSize = 12, Line = true, Center = "Page [page] of [toPage]" }
        //    };

        //    var pdf = new HtmlToPdfDocument()
        //    {
        //        GlobalSettings = globalSettings,
        //        Objects = { objectSettings }
        //    };

        //    var pdfBytes = _pdfConverter.Convert(pdf);

        //    return File(pdfBytes, "application/pdf", "EmployeeInformation.pdf");
        //}

        private readonly PdfService _pdfService;

        public PdfController(PdfService pdfService)
        {
            _pdfService = pdfService;
        }
        public IActionResult Generate()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Generate(PdfRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.HtmlContent))
            {
                return BadRequest("Invalid request.");
            }

            var pdfBytes = _pdfService.GeneratePdf(request.HtmlContent);

            return File(pdfBytes, "application/pdf", "generated.pdf");
        }
      
            public IActionResult LineChart()
            {
            ViewBag.DataPoints1 = new List<ChartPoint>
    {
        new ChartPoint("January", 10),
        new ChartPoint("February", 20),
        new ChartPoint("March", 15),
        new ChartPoint("April", 30),
        new ChartPoint("May", 25),
    };

            ViewBag.DataPoints2 = new List<ChartPoint>
    {
        new ChartPoint("January", 15),
        new ChartPoint("February", 25),
        new ChartPoint("March", 20),
        new ChartPoint("April", 35),
        new ChartPoint("May", 30),
    };

            ViewBag.DataPoints3 = new List<ChartPoint>
    {
        new ChartPoint("January", 5),
        new ChartPoint("February", 10),
        new ChartPoint("March", 8),
        new ChartPoint("April", 12),
        new ChartPoint("May", 10),
    };

            return View();
        }
        



    }
}
