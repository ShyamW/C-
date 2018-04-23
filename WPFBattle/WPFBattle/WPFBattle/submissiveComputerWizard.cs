using Sutherland.RoleplayingGameInterfaces;
using Sutherland.RPGCore;
using System.Threading;

namespace WPFBattle
{
    class submissiveComputerWizard : ComputerWizard
    {
        public override void ReceiveAttack(int damage)
        {
            
            this.Image.State = CharacterImage.CharacterState.TakeDamage;
            Thread.Sleep(100);
            base.ReceiveAttack(damage);
            //ternary
            if (this.Health == 0)
            {
                this.Image.State = CharacterImage.CharacterState.Dead;
            }
            else
            {
                this.Image.State = CharacterImage.CharacterState.Idle;
            }
        }
        public submissiveComputerWizard(string name, CharacterImage cImage)
        {
            this.CharacterClass = "ComputerWizard";
            this.Name = name;
            this.Image = cImage;
            this.attackBehavior = new sBadGradeAttack();
            this.Health = GameConstants.Instance.PlayerHitpoints;
        }

    }
}
