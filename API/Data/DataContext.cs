using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        // // https://stackoverflow.com/questions/57745481/unable-to-create-an-object-of-type-mycontext-for-the-different-patterns-suppo
        // public DataContext()
        // {
        // }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // // https://stackoverflow.com/questions/57745481/unable-to-create-an-object-of-type-mycontext-for-the-different-patterns-suppo
        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        // {
        //     if (!options.IsConfigured)
        //     {
        //         options.UseSqlite("Data source=datingapp.db");
        //     }
        // }

        public DbSet<AppUser> Users { get; set; }
    }
}