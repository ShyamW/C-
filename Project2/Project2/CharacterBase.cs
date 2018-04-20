using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thiagarajan.RoleplayingGameInterfaces;

namespace Thiagarajan.RPGCore
{
    public class CharacterBase : ICharacter
    {
        protected IAttack attackBehavior;

        public virtual void PerformAttack(ICharacter target)
        {
            attackBehavior.Attack(this, target);
        }

        protected Random randomNumbers = new Random();

        public override string ToString()
        {
            return String.Format("The {1} with name of {0} has {2} health.", Name, CharacterClass, Health);
        }

        protected const string AnonymousName = "The Anonymous";
        protected static int anonymousCounter = 0;

        public string Name
        {
            get;
            protected set;
        }

        public string CharacterClass
        {
            get;
            protected set;
        }
        public int Health
        {
            get;
            protected set;
        }

       


        public virtual void ReceiveAttack(int damage)
        {
            if (randomNumbers.Next(GameConstants.Instance.DodgeDiff) != 0)
            {
                Console.WriteLine(this.Name + " receives a staggering " + damage + " damage.");
                Health -= damage;
                if (Health < 0) Health = 0;
            }
            else
            {
                Console.WriteLine(this.Name + " dodges just in time!");
            }
        }

       



    }
}
