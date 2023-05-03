namespace HomeworkEntityFramework.ModelDatabase
{
    public class CharachtersExpirience
    {
        public int Id { get; private set; }

        public int CharactersId { get; private set; }

        public int ExpirienceId { get; private set; }

        public int Expirience { get; private set; }

        public CharachtersExpirience(int id, int charactersId, int expirienceId, int expirience)
        {
            Id = id;
            CharactersId = charactersId;
            ExpirienceId = expirienceId;
            Expirience = expirience;
        }

        public CharachtersExpirience(int charactersId)
        {
            CharactersId = charactersId;
            ExpirienceId = 1;
            Expirience = 0;
        }
    }
}
