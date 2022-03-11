using LotusTransformation.Models;
using Microsoft.EntityFrameworkCore;

namespace LotusTransformation.Data
{
    public class LotusTransformationDBContext : DbContext
    {
        public LotusTransformationDBContext(DbContextOptions<LotusTransformationDBContext> options) : base(options) { }

        public DbSet<ClientAccountInformation> ClientAccountInformation { get; set; }

        public DbSet<ClientContactInformation> ClientContactInformation { get; set; }

        public DbSet<Administrator> Admin { get; set; }

        public DbSet<AdminClientNotes> AdminClientNotes { get; set; }

        public DbSet<ClientWorkInformation> ClientWorkInformation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientAccountInformation>()
                .HasIndex(u => new { u.UserName }).IsUnique(true);
        }

    }
}
