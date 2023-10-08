using DBAppChef.Entities;
using Microsoft.EntityFrameworkCore;

namespace DBAppChef
{
    public class ChefContext : DbContext
    {
        public ChefContext(DbContextOptions<ChefContext> options) : base (options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionTag> QuestionTags { get; set; }
        //public DbSet<Answer2> Answers { get; set; }


    }
}