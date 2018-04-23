using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Sutherland.RoleplayingGameInterfaces;
using Sutherland.RPGCore;

namespace WPFBattle
{
    class submissiveMage: Mage
    {
        public override void ReceiveAttack(int damage)
        {
            this.Image.State = CharacterImage.CharacterState.TakeDamage;
            Thread.Sleep(1000);
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
        public submissiveMage(string name, CharacterImage cImage)
        {
            this.CharacterClass = "Mage";
            this.Name = name;
            this.Image = cImage;
            this.attackBehavior = new sFireAttack();
            this.Health = GameConstants.Instance.PlayerHitpoints;
        }

    }
}
