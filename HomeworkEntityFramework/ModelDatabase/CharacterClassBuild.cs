namespace HomeworkEntityFramework.ModelDatabase
{
    public class CharacterClassBuild
    {
        public int Id { get; private set; }
        public int CharactersClassId { get; private set; }
        public int SpellId { get; private set; }

        public CharacterClassBuild(int id, int CharactersClassId, int spellId)
        {
            Id = id;
            this.CharactersClassId = CharactersClassId;
            SpellId = spellId;
        }
    }
}
