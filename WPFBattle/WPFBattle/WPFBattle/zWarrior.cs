using Thiagarajan.RoleplayingGameInterfaces;
using Thiagarajan.RPGCore;
using System.Threading;

namespace WPFBattle
{
    class zWarrior : Warrior
    {
        public override void ReceiveAttack(int damage)
        {
            this.Image.State = CharacterImage.CharacterState.TakeDamage;
            Thread.Sleep(3000);
            base.ReceiveAttack(damage);
            if (this.Health == 0)
            {
                this.Image.State = CharacterImage.CharacterState.Dead;
            }
            else
            {
                this.Image.State = CharacterImage.CharacterState.Idle;
            }
        }
        public zWarrior(string name, CharacterImage cImage)
        {
            this.CharacterClass = "Warrior";
            this.Name = name;
            
            this.Health = GameConstants.Instance.PlayerHitpoints;
            this.Image = cImage;
            this.attackBehavior = new zSwordAttack();
        }

    }
}
