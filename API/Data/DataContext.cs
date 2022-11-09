using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; } // db set for photos not needed
        public DbSet<UserLike> Likes { get; set; } // join table name = Likes

        // entity config
        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            // primary key
            builder.Entity<UserLike>().HasKey(k => new {k.SourceUserId, k.LikedUserId});

            // yung liker, maraming like
            builder.Entity<UserLike>()
                .HasOne(s => s.SourceUser) // UserLike.cs
                .WithMany(l => l.LikedUsers) // AppUser.cs
                .HasForeignKey(s => s.SourceUserId) // UserLike.cs
                .OnDelete(DeleteBehavior.Cascade); // SQL Server = DeleteBehavior.NoAction or you will get migration error

            // yung ni-liked, maraming liker
            builder.Entity<UserLike>()
                .HasOne(s => s.LikedUser) // UserLike.cs
                .WithMany(l => l.LikedByUsers) // AppUser.cs
                .HasForeignKey(s => s.LikedUserId) // UserLike.cs
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}