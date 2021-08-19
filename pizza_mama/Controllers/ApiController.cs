using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pizza_mama.Data;
using pizza_mama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_mama.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        private readonly pizza_mama.Data.DataContext _context;

        public ApiController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetPizzas")]
        public async Task<IActionResult> GetPizzas()
        {
            var pizzas = await _context.Pizzas.ToListAsync();
            pizzas = pizzas.OrderBy(p => p.nom).ToList();
            return Json(pizzas);
        }
    }
}
