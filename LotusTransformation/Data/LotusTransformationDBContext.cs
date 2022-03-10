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
    }
}
