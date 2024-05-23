using Microsoft.AspNetCore.Mvc;
using OCR.Infraestuctura.Datos;

namespace OCR.Web.Controllers
{
    public class FichaController : Controller
    {
        private readonly AplicacionDbContexto _aplicacionDb;

        public FichaController(AplicacionDbContexto aplicacíonDb)
        {
            _aplicacionDb = aplicacíonDb;
        }
        public IActionResult Index()
        {
            var listaFicha = _aplicacionDb.incripciones.ToList();
            return View(listaFicha);
        }
    }
}
