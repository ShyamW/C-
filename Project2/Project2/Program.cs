using Thiagarajan.RoleplayingGameInterfaces;
using Thiagarajan.RPGCore;
using System;
using System.Collections.Generic;

namespace finalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<ICharacter> team1 = new List<ICharacter>();
            IList<ICharacter> team2 = new List<ICharacter>();

            /* Make Characters */
            ICharacter whitaker = new Mage("Whitaker");
            ICharacter judo = new Warrior("Judo");
            ICharacter dan = new Mage("Daniel");
            ICharacter connor = new Warrior("Connor");
            ICharacter Joe = new Mage("Joe");
            ICharacter Jim = new Warrior("Jim");

            /* add character to teams */
            team1.Add(dan);
            team1.Add(connor);
            team2.Add(whitaker);
            team2.Add(judo);
            team2.Add(Joe);
            team2.Add(Jim);

            Combat fightTime = new Combat(team1, team2, "Alpha Male", "Star");

            fightTime.AutoBattle();
         
        }
    }
}
