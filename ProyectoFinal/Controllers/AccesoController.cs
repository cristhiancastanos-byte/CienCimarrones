using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Services;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    public class AccesoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccesoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult LoginAdmin(string usuario, string password)
        {
            var user = _context.Usuarios.FirstOrDefault(u => u.NombreUsuario == usuario && u.Password == password && u.Rol == "Admin");

            if (user != null)
            {
                HttpContext.Session.SetString("Rol", "Admin");
                return RedirectToAction("Index", "Preguntas");
            }
            ViewBag.Error = "Credenciales de Admin incorrectas.";
            return View("Index");
        }

        [HttpPost]
        public IActionResult EntrarComoJugador()
        {
            HttpContext.Session.SetString("Rol", "Jugador");
            return RedirectToAction("SiguienteAleatoria", "Preguntas");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}