using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pry_CRUD.Data;
using Pry_CRUD.Models;
using System.Diagnostics;

namespace Pry_CRUD.Controllers
{
    public class InicioController : Controller
    {
        
        private readonly ApplicationDbContext _contexto;
        public InicioController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Contacto.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
