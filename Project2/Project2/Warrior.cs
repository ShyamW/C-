using Thiagarajan.RoleplayingGameInterfaces;

namespace Thiagarajan.RPGCore
{
    public class Warrior : CharacterBase
    {
        public Warrior(string name, int health)
        {
            this.CharacterClass = "WarriorKnight";
            this.attackBehavior = new SwordAttack();
            this.Name = name;
            this.Health = health;
        }
        public Warrior(string name) : this(name, GameConstants.Instance.PlayerHitpoints)
        {
        }
        public Warrior() : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(), GameConstants.Instance.PlayerHitpoints)
        {
        }
    }
}
