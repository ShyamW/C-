using Sutherland.RoleplayingGameInterfaces;
using Sutherland.RPGCore;
using System.Threading;

namespace WPFBattle
{
    class submissiveArcher : Archer
    {
        public override void ReceiveAttack(int damage)
        {
            this.Image.State = CharacterImage.CharacterState.TakeDamage;
            Thread.Sleep(1000);
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
        public submissiveArcher(string name, CharacterImage cImage)
        {
            this.CharacterClass = "Archer";
            this.Name = name;
            this.Image = cImage;
            this.attackBehavior = new sBowAttack();
            this.Health = GameConstants.Instance.PlayerHitpoints;
        }

    }
}
