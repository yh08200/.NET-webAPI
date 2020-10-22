using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Edu.Data.Domain;
using Edu.Data.DomainMap;

namespace Edu.BuildterData.Models
{
    public partial class SalesERPDBContext : DbContext
    {
        static SalesERPDBContext()
        {
            Database.SetInitializer<SalesERPDBContext>(null);
        }

        public SalesERPDBContext()
            : base("Name= EFDefaultConnection")
        {
        }

        public DbSet<TblEmployee> TblEmployees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TblEmployeeMap());
        }
    }
}
