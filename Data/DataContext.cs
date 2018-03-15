using Microsoft.EntityFrameworkCore;
using Sec.API.Model;

namespace Sec.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Lesson> Lessons { get; set; }           
    }
}