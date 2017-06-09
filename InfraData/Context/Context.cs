using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using InfraData.Entities;

namespace InfraData.Context
{
    public class Context : DbContext
    {
        public Context() : base("ConnectionString") { }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("VARCHAR"));
        }
    }
}
