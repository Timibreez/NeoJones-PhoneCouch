using Microsoft.AspNetCore.Mvc;
using PhoneCouch.Models;

namespace PhoneCouch.Controllers
{
    public class PhonesController : Controller
    {
        public IActionResult Random()
        {
            var phone = new Phone() { Name = "X" };
            //return View(phone);
            //return Content("Hello world!");
            //return NotFound();
            //return new EmptyResult();
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }
    }
}
