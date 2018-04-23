using Thiagarajan.RoleplayingGameInterfaces;
using Thiagarajan.RPGCore;
using System.Threading;

namespace WPFBattle
{
    class Archer : Thiagarajan.RPGCore.Archer
    {
        public Archer(string name, CharacterImage cImage)
        {
            this.CharacterClass = "LongBowMan (Archer)";
            this.Name = name;
            this.Image = cImage;
            this.attackBehavior = new zBowAttack();
            this.Health = GameConstants.Instance.PlayerHitpoints;
        }

        public override void ReceiveAttack(int damage)
        {
            this.Image.State = CharacterImage.CharacterState.TakeDamage;
            Thread.Sleep(3000);
            base.ReceiveAttack(damage);
            // ternary operator change
            if (this.Health == 0)
            {
                this.Image.State = CharacterImage.CharacterState.Dead;
            }
            else
            {
                this.Image.State = CharacterImage.CharacterState.Idle;
            }
        }
        

    }
}
