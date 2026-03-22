using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Services;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    public class PreguntasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PreguntasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var listaPreguntas = _context.Preguntas.ToList();
            return View(listaPreguntas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Pregunta pregunta)
        {
            if (ModelState.IsValid)
            {
                _context.Preguntas.Add(pregunta);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(pregunta);
        }
        public IActionResult Edit(int id)
        {
            var pregunta = _context.Preguntas.Find(id);
            if (pregunta == null)
            {
                return RedirectToAction("Index");
            }
            return View(pregunta);
        }

        [HttpPost]
        public IActionResult Edit(int id, Pregunta pregunta)
        {
            if (ModelState.IsValid)
            {
                _context.Preguntas.Update(pregunta);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pregunta);
        }

        public IActionResult Delete(int id)
        {
            var pregunta = _context.Preguntas.Find(id);
            if (pregunta == null)
            {
                return RedirectToAction("Index"); 
            }
            return View(pregunta); 
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var pregunta = _context.Preguntas.Find(id);
            if (pregunta != null)
            {
                _context.Preguntas.Remove(pregunta); 
                _context.SaveChanges(); 
            }
            return RedirectToAction("Index");
        }

        public IActionResult Jugar(int id)
        {
            var pregunta = _context.Preguntas.Find(id);
            if (pregunta == null)
            {
                return RedirectToAction("Index");
            }
            return View(pregunta);
        }

        public IActionResult SiguienteAleatoria()
        {
            var preguntaRandom = _context.Preguntas
                .OrderBy(x => Guid.NewGuid())
                .FirstOrDefault();

            if (preguntaRandom == null)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Jugar", new { id = preguntaRandom.Id });
        }

    }
}