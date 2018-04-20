using Thiagarajan.RoleplayingGameInterfaces;
using System;

namespace Thiagarajan.RPGCore
{
    public class SwordAttack : NormalAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            String msg = attacker.Name + " swings sword at " + target.Name + "!";
            Console.WriteLine(msg);
            base.Attack(attacker, target);
        }
    }


}
