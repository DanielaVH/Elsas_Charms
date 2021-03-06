using ElsasCharms.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElsasCharms.Web.Controllers
{
    public class ProductosController : Controller
    {
        ProductosBL _productosBL;

        public ProductosController()
        {
            _productosBL = new ProductosBL();
        }
        // GET: Productos
        public ActionResult Index()
        {
            var listadeProductos = _productosBL.ObtenerProductos();
            
            return View(listadeProductos);
        }

    }
}