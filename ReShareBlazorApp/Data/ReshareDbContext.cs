using Microsoft.EntityFrameworkCore;
using ReShareBlazorApp.Date;

namespace ReShareBlazorApp.Data


{
    public class ReshareDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ReshareDbContext(DbContextOptions<ReshareDbContext> options)
        : base(options)
        {

        }
    }


}
