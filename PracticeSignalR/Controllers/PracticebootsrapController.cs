using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PracticeSignalR.Controllers
{
    public class PracticebootsrapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index1()
        {
            return View();
        }
        public IActionResult Animate()
        {
       // Read();
            return View();
        }
        public IActionResult Practice()
        {
            // Read();
            return View();
        }

        public IActionResult Json()
        {
            string jPath = "C:\\Users\\GovindaRaju\\source\\repos\\.Net Framework Gd\\PracticeSignalR\\PracticeSignalR\\Practice.json";
            string jsonData = System.IO.File.ReadAllText(jPath);

            // Deserialize the JSON string into a JObject
            JObject jsonObject = JObject.Parse(jsonData);
            JObject obj1 = new JObject();
            //obj1["name"] = "John";
            //obj1["age"] = 30;

            // create the second JObject
            JObject obj2 = new JObject();
            obj2["address"] = "123 Main St";
            obj2["city"] = "Anytown";

            // add obj2 to obj1
            obj1.Add("details", obj2);
            //List<JObject> list = new List<JObject> { obj1 };

            //// Serializing the list to JSON
            //var jData = JsonConvert.SerializeObject(list,Formatting.Indented);
          var   existingDetails = obj1;
             foreach (var property in obj1)
            {
                existingDetails[property.Key] = property.Value;
            }
            System.IO.File.WriteAllTextAsync(jPath, jsonObject.ToString());
         
            return View("Animate");
        }

        public IActionResult Read()
        {
            string jPath = "C:\\Users\\GovindaRaju\\source\\repos\\.Net Framework Gd\\PracticeSignalR\\PracticeSignalR\\Practice.json";
            string jsonData = System.IO.File.ReadAllText(jPath);

            // Deserialize the JSON string into a JObject
            JObject jsonObject = JObject.Parse(jsonData);

            // Accessing properties
            foreach (var property in jsonObject.Properties())
            {
                Console.WriteLine($"{property.Name}: {property.Value}");
            }




            return View("Animate");
        }
    }
}
