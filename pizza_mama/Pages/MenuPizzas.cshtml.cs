using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizza_mama.Data;
using pizza_mama.Models;

namespace pizza_mama.Pages.Admin
{
    public class MenuPizzasModel : PageModel
    {
        private readonly pizza_mama.Data.DataContext _context;

        public IList<Pizza> Pizza { get; set; }

        public MenuPizzasModel(DataContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizzas.ToListAsync();
        }
    }
}
