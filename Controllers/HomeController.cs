using Microsoft.AspNetCore.Mvc;
using FutureValueReal.Models;
public class HomeController : Controller 


{ 
        public IActionResult About()
        {
        return View();
        }

        public IActionResult Contact()
        {
        return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index (FutureValueModel model)
    {
        if (ModelState.IsValid)
        {
            ViewBag.FV = model.CalculateFutureValue();
        }
        else
        {
            ViewBag.FV = 0; 
        }
        return View(model);
    }
        

 
}
