using Lab_2.Models;
using Microsoft.AspNetCore.Mvc;


namespace Lab_2.Controllers
{
    public class PriceQuotationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new PriceQuotationModel());
        }

        [HttpPost]
        public IActionResult Index(PriceQuotationModel model)
        {
            return View(model);
        }
    }
}