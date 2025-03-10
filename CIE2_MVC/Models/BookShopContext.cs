using Microsoft.EntityFrameworkCore;
using CIE2_MVC.Models;

public class BookShopContext : DbContext
{
    public BookShopContext(DbContextOptions<BookShopContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }
    public DbSet<Category> Categories { get; set; }
}
