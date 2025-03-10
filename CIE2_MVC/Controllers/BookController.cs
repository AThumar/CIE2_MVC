using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;  // Required for ToListAsync()
using System.Threading.Tasks;        // Required for async/await
using CIE2_MVC.Models;               // Ensure this is your namespace where BookShopContext is defined

namespace CIE2_MVC.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookShopContext _context;

        public BooksController(BookShopContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Books.ToListAsync());
        }
    }

}
