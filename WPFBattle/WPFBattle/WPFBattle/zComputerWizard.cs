using Thiagarajan.RoleplayingGameInterfaces;
using Thiagarajan.RPGCore;
using System.Threading;

namespace WPFBattle
{
    class zComputerWizard : ComputerWizard
    {
        public override void ReceiveAttack(int damage)
        {
            
            this.Image.State = CharacterImage.CharacterState.TakeDamage;
            Thread.Sleep(3001);
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
        public zComputerWizard(string name, CharacterImage cImage)
        {
            this.CharacterClass = "ComputerWizardHacker";
            this.Name = name;
            this.Image = cImage;
            this.attackBehavior = new zBadGradeAttack();
            this.Health = GameConstants.Instance.PlayerHitpoints;
        }

    }
}
