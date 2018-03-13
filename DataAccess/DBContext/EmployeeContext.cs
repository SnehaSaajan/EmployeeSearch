using DataAccess.Model;
using System.Data.Entity;

namespace DataAccess.DBContext
{
    class EmployeeContext :DbContext
    {
        public EmployeeContext() : base(nameOrConnectionString: "MyConnString")
        {
           // Database.SetInitializer<EmployeeContext>(new DropCreateDatabaseIfModelChanges<EmployeeContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
