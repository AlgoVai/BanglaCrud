using banglaCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace banglaCrud.Data
{
    public class ApplicationDbContext :DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<House> houses { get; set; }

    }
}
