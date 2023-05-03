using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkEntityFramework.ModelDatabase
{
    public class Spell
    {
        public int Id { get; private set; }

        [Column("Name")]
        public string NameSpell { get; private set; }

        public string ExpirienceId { get; private set;}

        public Spell(int id, string nameSpell, string expirienceId)
        {
            Id = id;
            NameSpell = nameSpell;
            ExpirienceId = expirienceId;
        }
    }
}
