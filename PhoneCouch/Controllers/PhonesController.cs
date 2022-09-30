using Microsoft.AspNetCore.Mvc;
using PhoneCouch.Models;

namespace PhoneCouch.Controllers
{
    public class PhonesController : Controller
    {
        public IActionResult Random()
        {
            var phone = new Phone() { Name = "X" };
            return View(phone);
        }
    }
}
