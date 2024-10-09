using Microsoft.AspNetCore.Mvc;
using Agrocity.Data;
using Agrocity.Models;
using System.Linq;


namespace FazendaUrbanaSite.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var produtos = _context.Products.ToList();
            return View(produtos);
        }

        public IActionResult Detalhes(int id)
        {
            var produto = _context.Products.FirstOrDefault(p => p.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }
    }
}
