using CIE2_MVC.Models;
using Microsoft.EntityFrameworkCore;
public class BookShopContext : DbContext
{
    public BookShopContext(DbContextOptions<BookShopContext> options) : base(options) { }
    public DbSet<Book> Books { get; set; }
}
