using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Edu.Data.Domain;

namespace Edu.Data.DomainMap
{
    public class TblEmployeeMap : EntityTypeConfiguration<TblEmployee>
    {
        public TblEmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeId);

            // Properties
            // Table & Column Mappings
            this.ToTable("TblEmployee");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.FristName).HasColumnName("FristName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Salary).HasColumnName("Salary");
        }
    }
}
