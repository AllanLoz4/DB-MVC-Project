using ALozanoMVCAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ALozanoMVCAPP.Controllers
{
    public class UsersController : Controller
    {
        UsersContext uc = new();
        public IActionResult ALView()
        {
            return View(uc.AlozanoTables.ToList());
        }
    }
}
