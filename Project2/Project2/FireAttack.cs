using System;
using Thiagarajan.RoleplayingGameInterfaces;

namespace Thiagarajan.RPGCore
{
    public class FireAttack : NormalAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            String msg = attacker.Name + " shot, intending to mame, " + target.Name + "!";
            Console.WriteLine(msg);
            base.Attack(attacker, target);
        }

    }
}
