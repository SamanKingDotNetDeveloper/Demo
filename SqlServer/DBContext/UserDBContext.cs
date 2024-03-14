using Microsoft.EntityFrameworkCore;
using SqlServer.Models;

namespace SqlServer.DBContext
{
    public class UserDBContext :DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options)
            :base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("SqlServerBase", builder =>
            {
                builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            });
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<UserModel> Users { get; set; }
    }
}
