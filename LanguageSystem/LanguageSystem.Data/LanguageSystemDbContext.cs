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

        public DbSet<Answer> Answers { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Verb> Verbs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<QuestionAnswer>()
                .HasKey(x => new { x.QuestionId, x.AnswerId });

            builder
                .Entity<QuestionAnswer>()
                .HasOne(q => q.Question)
                .WithMany(qa => qa.QuestionAnswers)
                .HasForeignKey(fk => fk.QuestionId);

            builder
                .Entity<QuestionAnswer>()
                .HasOne(a => a.Answer)
                .WithMany(qa => qa.QuestionAnswers)
                .HasForeignKey(fk => fk.AnswerId);

            base.OnModelCreating(builder);
        }
    }
}