using Microsoft.EntityFrameworkCore;
namespace DnDCompanionWebApp.Models
{
    public class LoginContext:DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options) { }
        public DbSet<LoginModel> LoginModels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginModel>().HasData(
                new LoginModel {
                    Id = 1,
                    UserName = "dm",
                    Password = "password",
                    IsDungeonMaster = true
                },
                new LoginModel
                {
                    Id = 2,
                    UserName = "user",
                    Password = "password",
                    IsDungeonMaster = false
                }
                );

        }
    }
}
