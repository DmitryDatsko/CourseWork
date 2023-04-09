using Microsoft.EntityFrameworkCore;

namespace CourseWork.Models
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> opts)
            : base(opts) { }
        public DbSet<Test> Tests => Set<Test>();
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.UseCollation("Ukrainian_CI_AS");
		}
	}
}
