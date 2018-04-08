using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Identity;
namespace SimpleBankSystem.Models
{
    public class ApplicationDbContext : IdentityDbContext<AppIdentityUser, AppIdentityRole, string>
    {
     public DbSet<BankAccount> BankAccounts { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            modelBuilder.Entity<AppIdentityUser>(entity => { 
                entity.Property(m => m.Email).HasMaxLength(127); 
                entity.Property(m => m.NormalizedEmail).HasMaxLength(127); 
                entity.Property(m => m.NormalizedUserName).HasMaxLength(127); 
                entity.Property(m => m.UserName).HasMaxLength(127); 
            }); 
            modelBuilder.Entity<AppIdentityRole>(entity => { 
                entity.Property(m => m.Name).HasMaxLength(127); 
                entity.Property(m => m.NormalizedName).HasMaxLength(127); 
            }); 
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => 
            { 
                entity.Property(m => m.LoginProvider).HasMaxLength(127); 
                entity.Property(m => m.ProviderKey).HasMaxLength(127); 
            }); 
            modelBuilder.Entity<IdentityUserRole<string>>(entity => 
            { 
                entity.Property(m => m.UserId).HasMaxLength(127); 
                entity.Property(m => m.RoleId).HasMaxLength(127); 
            }); 
            modelBuilder.Entity<IdentityUserToken<string>>(entity => 
            { 
                entity.Property(m => m.UserId).HasMaxLength(127); 
                entity.Property(m => m.LoginProvider).HasMaxLength(127); 
                entity.Property(m => m.Name).HasMaxLength(127); 
            });
        }

    }
}