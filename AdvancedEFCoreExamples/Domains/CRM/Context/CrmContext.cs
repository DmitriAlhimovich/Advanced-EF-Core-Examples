using Microsoft.EntityFrameworkCore;

namespace AdvancedEFCoreExamples.Domains.CRM.Context
{
    public class CrmContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities{ get; set; }

        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Customer> Customers{ get; set; }

        public DbSet<Call> Calls{ get; set; }

        public DbSet<CallOutcome> Outcomes { get; set; }

        public CrmContext(DbContextOptions<CrmContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CallOutcome>().HasKey(e => e.CallId);
            modelBuilder.Entity<City>().HasKey(e => new {e.Name, e.CountryCode});
            modelBuilder.Entity<Country>().HasKey(e => e.Code);

            modelBuilder.Entity<Call>().HasOne(c => c.Outcome).WithOne(o => o.Call).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Seed();
        }

    }
}
