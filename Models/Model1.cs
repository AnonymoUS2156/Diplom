using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Diploma.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Disciplines> Disciplines { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
        public virtual DbSet<AuthArchivist> AuthArchivist { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Employee)
                .WithOptional(e => e.Book)
                .HasForeignKey(e => e.ReservedBookID);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employee)
                .WithOptional(e => e.Department1)
                .HasForeignKey(e => e.Department);

            modelBuilder.Entity<Disciplines>()
                .HasMany(e => e.Book)
                .WithOptional(e => e.Disciplines1)
                .HasForeignKey(e => e.Disciplines);

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Author)
                .WithOptional(e => e.Gender1)
                .HasForeignKey(e => e.Gender);
        }
    }
}
