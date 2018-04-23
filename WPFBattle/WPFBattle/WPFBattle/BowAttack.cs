using Thiagarajan.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiagarajan.RPGCore
{
    
    public class BowAttack : NormalAttack
    {
        
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " shoot an arrow to the knee" + target.Name + "!");
            base.Attack(attacker, target);
        }
    }
}
