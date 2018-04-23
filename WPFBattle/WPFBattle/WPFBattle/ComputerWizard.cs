using Thiagarajan.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiagarajan.RPGCore
{
    public class ComputerWizard : CharacterBase
    {
        
        public ComputerWizard(string name) : this(name, GameConstants.Instance.PlayerHitpoints)
        {
        }
        public ComputerWizard() : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(), GameConstants.Instance.PlayerHitpoints)
        {
        }

        public ComputerWizard(string name, int health)
        {
            this.CharacterClass = "ComputerWizardHacker";
            this.attackBehavior = new BowAttack();
            this.Name = name;
            this.Health = health;
        }
    }
}
