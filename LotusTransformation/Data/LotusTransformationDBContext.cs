using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using LotusTransformation.Models;

namespace LotusTransformation.Data
{
    public class LotusTransformationDBContext : DbContext
    {
        
        
      
       
        public LotusTransformationDBContext(DbContextOptions<LotusTransformationDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<UserInformation> UserInformation { get; set; }

    }
}
