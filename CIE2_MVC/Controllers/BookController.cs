using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CIE2_MVC.Models;

public class BooksController : Controller
{
    private readonly BookShopContext _context;

    public BooksController(BookShopContext context)
    {
        _context = context;
    }

    // Show all books
    public async Task<IActionResult> Index()
    {
        return View(await _context.Books.Include(b => b.Category).ToListAsync());
    }

    // Create Book (GET)
    public IActionResult Create()
    {
        return View();
    }

    // Create Book (POST)
    [HttpPost]
    public async Task<IActionResult> Create(Book book)
    {
        if (ModelState.IsValid)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(book);
    }
}
