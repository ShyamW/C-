using System;
using Thiagarajan.RoleplayingGameInterfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Thiagarajan.RPGCore
{
   
    public class BadGradeAttack : NormalAttack
    {
        
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            System.Console.WriteLine(attacker.Name + " failed with resentment " + target.Name + "!");
            base.Attack(attacker, target);
        }
    }
}


