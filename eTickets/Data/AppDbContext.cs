using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options : base(options))
        {

        }
    }
}
