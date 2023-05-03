namespace HomeworkEntityFramework.ModelDatabase
{
    public class Expirience
    {
        public int Id { get; private set; }

        public int CurrentLevel { get; private set; }

        public int NextLevelExpirience { get; private set; }

        public Expirience(int id, int currentLevel, int nextLevelExpirience)
        {
            Id = id;
            CurrentLevel = currentLevel;
            NextLevelExpirience = nextLevelExpirience;
        }
    }
}
