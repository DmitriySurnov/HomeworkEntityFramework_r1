using Microsoft.EntityFrameworkCore;

namespace HomeworkEntityFramework.ModelDatabase
{
    public class DataBase:DbContext
    {
        public DbSet<Characters> Characters { get; set; }
        public DbSet<CharactersClass> CharactersClass { get; set; }
        public DbSet<Spell> Spell { get; private set; }
        public DbSet<CharacterClassBuild> CharacterClassBuild { get; private set; }
        public DbSet<Expirience> Expirience { get; private set; }
        public DbSet<CharachtersExpirience> CharachtersExpirience { get; private set; }


        public DataBase()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("host = db4free.net; username = dmitriy; password = qwertyasdfgh; database = training_base;", new MySqlServerVersion(new Version(8, 0)));
        }
    }
}
