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

        public DbSet<UserModel> Users { get; set; }
    }
}
