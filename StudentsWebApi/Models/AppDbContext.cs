using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsWebApi.Models
{
    public class AppDbContext : DbContext
    {
        //Db Collections here
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base (options)
        {
            
        }
        // Sample of fluent api below to study
        protected override void OnModelCreating(ModelBuilder builder)
        {
            /* builder.Entity<Major>(e => {       //Statement block
             * e.ToTable("Majors");  // Table name
             * e.HasKey(p => p.Id);  // primary key
             * e.Property(p => p.Code).HasMaxLength(4).IsRequired(true); // Sets max length and makes non-null
             * e.HasIndex(p => p.Code).IsUnique(true);  // sets unique after prop set
             * e.Property(p => p.Description).HasMaxLength(30).IsRequired(true);
             * e.Property(p => p.MinSAT);
             * });
             * 
             * builder.Entity<Student>(e => {
             * e.ToTable("Students");
             * e.HasKey(p => p.Id);
             * e.Property(p => p.Firstname).HasMaxLength(30).IsRequired(true);
             * e.Property(p => p.Lastname).HasMaxLength(30).IsRequired(true);
             * e.Property(p => p.SAT);
             * e.Property(p => p.GPA).HasColumnType("decimal(4,2)");
             * e.HasOne(p => p.Major)
             *      .WithMany(p => p.Students)
             *      .HasForeignKey(p => p.MajorId)
             *      .OnDelete(DeleteBehavior.Restrict);
             *});
             */
        }

    }
}
