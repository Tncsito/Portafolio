using Microsoft.AspNetCore.Mvc;
using Portafolio_EESA.Datos;
using Portafolio_EESA.Models;

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
            var perfil = _context.perfil.ToList();
            return View(perfil);
        }


    }
}
