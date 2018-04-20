using Thiagarajan.RoleplayingGameInterfaces;

namespace Thiagarajan.RPGCore
{
    public class ComputerWizard : CharacterBase
    {
        public ComputerWizard(string name, int health)
        {
            this.CharacterClass = "DaPCWizardPrincipal";
            this.attackBehavior = new BowShoot();
            this.Name = name;
            this.Health = health;
        }
        public ComputerWizard(string name) : this(name, GameConstants.Instance.PlayerHitpoints)
        {
        }
        public ComputerWizard() : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(), GameConstants.Instance.PlayerHitpoints)
        {
        }
    }
}