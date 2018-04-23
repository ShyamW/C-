using Thiagarajan.RoleplayingGameInterfaces;
using Thiagarajan.RPGCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPFBattle
{
    class zFireAttack : FireAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + "scorched " + target.Name + " with a melting fireball!");
            CharacterImage.CharacterState before = attacker.Image.State;
            attacker.Image.State = CharacterImage.CharacterState.Attacking;
            Thread.Sleep(3000);
            base.Attack(attacker, target);
            attacker.Image.State = CharacterImage.CharacterState.Idle;
        }
    }
}
