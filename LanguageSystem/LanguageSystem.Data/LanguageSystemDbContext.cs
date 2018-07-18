using LanguageSystem.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LanguageSystem.Data
{
    public class LanguageSystemDbContext : IdentityDbContext<User>
    {
        public LanguageSystemDbContext(DbContextOptions<LanguageSystemDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}