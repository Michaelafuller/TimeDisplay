using Microsoft.AspNetCore.Mvc;


namespace TimeDisplay
{
    public class IndexController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            // DateTime CurrentTime = DateTime.Now;
            
            return View("Index");
        }
    }
}