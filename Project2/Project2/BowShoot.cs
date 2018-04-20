using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thiagarajan.RoleplayingGameInterfaces;

namespace Thiagarajan.RPGCore
{
    public class BowShoot : NormalAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            base.Attack(attacker, target);
            Console.WriteLine(attacker.Name + " Slices " + target.Name + " With an Arrow to the knee!");
        }
    }
}
