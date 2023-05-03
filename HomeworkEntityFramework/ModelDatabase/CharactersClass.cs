using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkEntityFramework.ModelDatabase
{
    public class CharactersClass
    {
        public int Id { get; private set; }

        [Column("Name")]
        public string NameClass { get; private set; }

        public CharactersClass(int id, string nameClass)
        {
            Id = id;
            NameClass = nameClass;
        }

        public CharactersClass(string nameClass)
        {
            NameClass = nameClass;
        }
    }
}
