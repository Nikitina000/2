using Microsoft.EntityFrameworkCore;


namespace Zadanie2
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Eat> Eat { get; set; } = null!;
        public ApplicationContext() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=voloda;password=rhenj;database=sys;", new MySqlServerVersion(new Version(8,0,34)));
        }

    }
}
