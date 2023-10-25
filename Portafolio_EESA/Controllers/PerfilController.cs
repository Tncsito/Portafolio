using Microsoft.AspNetCore.Mvc;
using Portafolio_EESA.Datos;

namespace Portafolio_EESA.Controllers
{
    public class PerfilController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PerfilController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var people = _context.People.ToList();
            return View(people);
        }


    }
}
