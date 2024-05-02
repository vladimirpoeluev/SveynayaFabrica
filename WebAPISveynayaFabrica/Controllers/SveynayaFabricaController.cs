using Microsoft.AspNetCore.Mvc;
using SveynayaFabrica.data.migrations;

namespace WebAPISveynayaFabrica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SveynayaFabricaController : Controller
    { 

        [HttpGet]
        public JsonResult Product() // вывод всей продукции
        {
            var data = new DatabaseTestsEntities();
            return new JsonResult(data.Product.ToList());
        }

        [HttpPost]
        public JsonResult Product(string str) // вывод информации о конкрентной продукции
        {
            var data = new DatabaseTestsEntities();
            return new JsonResult(data.Product.Where((p) => p.Id == str));
        }
    }
}
