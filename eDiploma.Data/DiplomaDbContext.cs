using Microsoft.EntityFrameworkCore;
using eDiploma.Models.Entities;

namespace eDiploma.Data.Context
{
    public class DiplomaDbContext : DbContext
    {
        public DiplomaDbContext(DbContextOptions<DiplomaDbContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Diploma> Diplomas { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}