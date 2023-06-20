using Microsoft.EntityFrameworkCore;

namespace Lab13StudentsApi.Models
{
    public class SourceContext: DbContext
    {
        public SourceContext(DbContextOptions<SourceContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
