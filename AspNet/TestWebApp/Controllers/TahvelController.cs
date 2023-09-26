using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Encodings.Web;

namespace TestWebApp.Controllers
{
    public class TahvelController : Controller
    {
        public IActionResult Index()
        {
            /*WebClient web = new WebClient();
            System.IO.Stream stream = web.OpenRead("https://tahvel.edu.ee/hois_back/timetableevents/timetableByGroup/14?from=2023-01-16T00:00:00Z&studentGroups=6934&thru=2023-01-22T00:00:00Z");
            using(System.IO.StreamReader reader = new System.IO.StreamReader(stream))
            {
                while(!reader.EndOfStream)
                {
                    string text = reader.ReadLine();
                    
                }
            }*/
            System.Diagnostics.Debug.WriteLine("Hit index controller");
            return View("Index");
        }

        public class TimeTable
        {
            public int id { get; set; }
            public string nameEt { get; set; }
            public string timeStart { get; set; }
            public string timeEnd { get; set; }

        }
    }
}
