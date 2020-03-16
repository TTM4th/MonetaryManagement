namespace MonetaryManagementAccessor.Entity.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Common;
    using System.Configuration;

    public partial class UsingData : DbContext
    {
        public UsingData()
            : base($"name={ConfigurationManager.ConnectionStrings["UsingData"].Name}")
        {
        }

        public virtual DbSet<MoneyData> MoneyDataSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MoneyData>()
                .Property(e => e.Date);
                

            modelBuilder.Entity<MoneyData>()
                .Property(e => e.Price)
                .HasPrecision(28, 0);

            modelBuilder.Entity<MoneyData>()
                .Property(e => e.Classification)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
