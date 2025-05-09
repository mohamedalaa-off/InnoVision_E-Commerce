using Microsoft.AspNetCore.Mvc;

namespace InnoVision.V0.Controllers
{
    using InnoVision.V0.Data;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    public class ProductsController : Controller
    {
        private readonly ShoppingContext _context;

        public ProductsController(ShoppingContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.Include(p => p.Store).ToListAsync();
            return View(products);
        }
    }
}
