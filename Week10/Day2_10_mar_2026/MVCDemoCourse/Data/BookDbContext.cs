using Microsoft.EntityFrameworkCore;
using MVCDemoCourse.Models;

namespace MVCDemoCourse.Data
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }
        public DbSet<BookModel> books { get; set; }
    }
}
