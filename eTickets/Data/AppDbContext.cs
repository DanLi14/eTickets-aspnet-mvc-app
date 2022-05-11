using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    // Had to install DbContext from Microsoft.EntityFrameworkCore
    // by using suggested actions
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
