namespace LeTruongNam.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLDanhBaDB : DbContext
    {
        public QLDanhBaDB()
            : base("name=QLDanhBaDB")
        {
        }

        public virtual DbSet<DS_DANHBA> DS_DANHBA { get; set; }
        public virtual DbSet<NHOM> NHOMs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
