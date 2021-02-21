using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaginacionXpagedList.Models;
using X.PagedList;

namespace PaginacionXpagedList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Productos(int? page)
        {
            //creo una lista con un for de productos
            List<Producto> products = new List<Producto>();
            Random random = new Random();
            String[] productos = {
                "Pan",
                "Donuts",
                "Pan grande",
                "Manolitos",
                "Croasanes",
                "Miguelitos",
                "Buñuelos",
                "Bizcocho",
                "Hojaldre",
                "Rosquillas" };

            for (int i = 0; i < 200; i++)
            {
                int numero = random.Next(0, 9);
                int precio = random.Next(1, 20);
                Producto productodeHorno = new Producto
                {
                    Precio = precio,
                    ProductName = productos[numero]
                };
                products.Add(productodeHorno);
            }
            return View(products.ToPagedList(page ?? 1,10));
            
        }
    }
}
