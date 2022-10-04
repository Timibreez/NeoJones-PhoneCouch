using Microsoft.AspNetCore.Mvc;
using PhoneCouch.Models;

namespace PhoneCouch.Controllers
{
    public class PhonesController : Controller
    {
        // Random IPhones
        public IActionResult Random()
        {
            var phone = new Phone() { Name = "X" };
            //return View(phone);
            //return Content("Hello world!");
            //return NotFound();
            //return new EmptyResult();
            return View(phone);
        }

        public IActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        // list of Available Phones
        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy)){
                sortBy = "Name";
            }
            return Content(String.Format("pageindex= {0} & sortBy= {1}", pageIndex, sortBy));
        }
    }
}
