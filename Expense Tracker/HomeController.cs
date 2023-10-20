using Microsoft.AspNetCore.Mvc;

namespace Expense_Tracker
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
