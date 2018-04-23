using Thiagarajan.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiagarajan.RPGCore
{
  public class Warrior : CharacterBase
    {
        public Warrior(string name, int health)
        {
            this.CharacterClass = "Warrior";
            this.Health = health;
            this.attackBehavior = new SwordAttack();
            this.Name = name;
        }
        public Warrior(string name) : this(name, GameConstants.Instance.PlayerHitpoints)
        {
        }
        public Warrior() : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(), GameConstants.Instance.PlayerHitpoints)
        {
        }
    }
}
