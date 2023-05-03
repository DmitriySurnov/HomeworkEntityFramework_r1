using HomeworkEntityFramework.ModelDatabase;

namespace HomeworkEntityFramework
{
    internal static class Requests
    {
        public static List<string> NameOfPlayers(DataBase db)
        {
            return db.Characters.Select(x => x.Name).ToList();
        }

        public static int IdPlayers(DataBase db, string namePlayer)
        {
            var Characters = db.Characters.FirstOrDefault(x => x.Name == namePlayer);
            if (Characters == null)
            {
                return 0;
            }
            else
            {
                return Characters.Id;
            }
        }

        public static int UniquePlayerName(DataBase db,string namePlayer)
        {
            return db.Characters.Where(x => x.Name == namePlayer).Count();
        }

        public static int IdClass(DataBase db, string nameClass)
        {
            var charactersClass = db.CharactersClass.FirstOrDefault(x => x.NameClass == nameClass);
            if (charactersClass == null) {
                return 0;
            }
            else
            {
                return charactersClass.Id;
            }
        }

        public static string[] NameOfClass(DataBase db)
        {
            return db.CharactersClass.Select(x => x.NameClass).ToArray();
        }

        private static List<string[]> Conversion(List<Tuple<string, string>> values)
        {
            List<string[]> listString = new();
            try
            {
                foreach ((string value1, string value2) in values)
                {
                    listString.Add(new string[2]);
                    listString[^1][0] = value1;
                    listString[^1][1] = value2;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return listString;
        }

        public static List<string[]> NameOfPlayersAndNameOfClass(DataBase db)
        {
            return Conversion(
           db.Characters
                .Select(x => new
                {
                    x.Name,
                    db.CharactersClass.First(y => y.Id == x.CharactersClassId).NameClass
                })
                .Select(x => new Tuple<string, string>(x.Name, x.NameClass))
                .ToList()
               );
        }

        public static List<string[]> NameOfPlayersAndNameOfSpell(DataBase db)
        {
            return Conversion(
                db.CharacterClassBuild.Select(x => new
                {
                    db.Characters.First(z => z.CharactersClassId ==
                        db.CharactersClass.First(y => x.CharactersClassId == y.Id).Id).Name,
                    db.Spell.First(y => y.Id == x.SpellId).NameSpell
                })
                .Select(x => new Tuple<string, string>(x.Name, x.NameSpell))
                .ToList());
        }

        public static List<string[]> NameOfClassAndNameOfSpell(DataBase db)
        {
            return Conversion(
                db.CharacterClassBuild
                .Select(x => new
                {
                    db.CharactersClass.First(y => x.CharactersClassId == y.Id).NameClass,
                     db.Spell.First(y => y.Id == x.SpellId).NameSpell
                    })
                .Select(x => new Tuple<string, string>(x.NameClass, x.NameSpell))
                .ToList()
                );
        }
    }
}
