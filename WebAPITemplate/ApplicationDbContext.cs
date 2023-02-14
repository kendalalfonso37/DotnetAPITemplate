using Microsoft.EntityFrameworkCore;

namespace WebAPITemplate
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

    }
}
