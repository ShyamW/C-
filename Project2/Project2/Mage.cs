using Thiagarajan.RoleplayingGameInterfaces;

namespace Thiagarajan.RPGCore
{
    public class Mage : CharacterBase
    {
        public Mage(string name, int health)
        {
            this.CharacterClass = "WarriorKnight";
            this.attackBehavior = new FireAttack();
            this.Name = name;
            this.Health = health;
        }

        public Mage(string name) : this(name, GameConstants.Instance.PlayerHitpoints)
        {
        }
        public Mage() : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(), GameConstants.Instance.PlayerHitpoints)
        {
        }
    }
}
