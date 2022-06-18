using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CuaHangDongHo_API.Models
{
    public partial class DBWatch : DbContext
    {
        public DBWatch()
            : base("name=DBWatch")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<brand> brands { get; set; }
        public virtual DbSet<contact> contacts { get; set; }
        public virtual DbSet<image_details> image_details { get; set; }
        public virtual DbSet<notify> notifies { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<order_detail> order_detail { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<contact>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<contact>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<contact>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<notify>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<notify>()
                .Property(e => e.email)
                .IsUnicode(false);
        }
    }
}
