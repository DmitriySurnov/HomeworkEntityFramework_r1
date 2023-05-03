namespace HomeworkEntityFramework.ModelDatabase
{
    public class Characters
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public int CharactersClassId { get; private set; }

        public Characters(int id, string name, int charactersClassId)
        {
            Id = id;
            Name = name;
            CharactersClassId = charactersClassId;
        }

        public Characters( string name, int charactersClassId)
        {
            Name = name;
            CharactersClassId = charactersClassId;
        }
    }
}
