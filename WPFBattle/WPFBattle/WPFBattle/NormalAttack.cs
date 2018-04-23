using Thiagarajan.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiagarajan.RPGCore
{
    public class NormalAttack : IAttack
    {
        protected Random randomNumbers = new Random(); // Simple random number generator
                                                       // for attacks.
        public virtual void Attack(ICharacter attacker, ICharacter target)
        {

            int damage = GameConstants.Instance.DamageBonus + randomNumbers.Next(GameConstants.Instance.DamageRange);
            target.ReceiveAttack(damage);
        }

    }
}
