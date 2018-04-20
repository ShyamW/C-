using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thiagarajan.RoleplayingGameInterfaces;

namespace Thiagarajan.RPGCore
{
    public class BadGradeAttack : NormalAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            base.Attack(attacker, target);
            System.Console.WriteLine(attacker.Name + " flunks " + target.Name + "!");
            
        }
    }
    
}
