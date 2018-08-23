using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMAWebApi.Models;

namespace SMAWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Articulo")]
    public class ArticuloController : Controller
    {
        private DataContext db = new DataContext();

        [HttpGet("ObtenerTodos")]
        public IActionResult ObtenerProductos()
        {
            var articulo = db.Articulo.ToList();
            if (articulo == null)
            {
                return NotFound();
            }
            return Ok(articulo);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorCodigoBarra(string id)
        {
            var articulo = db.Articulo.FirstOrDefault(c => c.CodigoBarra == id);
            if (articulo == null)
            {
                return NotFound();
            }

            return Ok(articulo);

        }
    }
}