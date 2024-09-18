using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Tesseract;

namespace PracticeSignalR.Controllers
{
    public class TestController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public TestController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
      


        [HttpPost]
        public async Task<IActionResult> ExtractDataFromImage(IFormFile postedFile)
        {
            if (postedFile != null && postedFile.Length > 0)
            {
                var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
                Directory.CreateDirectory(uploadsFolder); 

                var filePath = Path.Combine(uploadsFolder, Path.GetFileName(postedFile.FileName));

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await postedFile.CopyToAsync(fileStream);
                }
                var extractText = ExtractTextFromImage(filePath);

                ViewBag.Message = extractText.Replace("\n", "");
            }

            return View("Index");
        }

        private string ExtractTextFromImage(string filePath)
        {
            var path = Path.Combine(_webHostEnvironment.WebRootPath, "tessdata");

            using (var engine = new TesseractEngine(path, "eng", EngineMode.Default))
            {
                using (var pix = Pix.LoadFromFile(filePath))
                {
                    using (var page = engine.Process(pix))
                    {
                        return page.GetText();
                    }
                }
            }
        }
    }
}
