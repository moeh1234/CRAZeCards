namespace CRAZeCards
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HolidayEntity : DbContext
    {
        public HolidayEntity()
            : base("name=HolidayEntity")
        {
        }

        public virtual DbSet<HOLIDAY> HOLIDAYS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HOLIDAY>()
                .Property(e => e.Holiday_Id)
                .IsUnicode(false);

            modelBuilder.Entity<HOLIDAY>()
                .Property(e => e.Holiday_Name)
                .IsUnicode(false);

            modelBuilder.Entity<HOLIDAY>()
                .Property(e => e.Holiday_Month)
                .IsUnicode(false);

            modelBuilder.Entity<HOLIDAY>()
                .Property(e => e.Holiday_Date)
                .IsUnicode(false);

            modelBuilder.Entity<HOLIDAY>()
                .Property(e => e.Holiday_View)
                .IsUnicode(false);
        }
    }
}
