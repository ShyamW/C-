using System;
using Thiagarajan.RPGCore;
using System.Windows;

namespace Thiagarajan.RoleplayingGameInterfaces
{
    public class CharacterBase : ICharacter
    {
        protected const string AnonymousName = "Anonymous???";
        protected static int anonymousCounter = 0;
        public CharacterImage Image
        {
            get;
            set;
        }
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
        protected IAttack attackBehavior;

        public virtual void PerformAttack(ICharacter target)
        {
            attackBehavior.Attack(this, target);
        }
        protected Random randomNumbers = new Random();
        public override string ToString()
        {
            return String.Format("The {1}, {0}, has {2} health remaining.", Name, CharacterClass, Health);
        }

        public virtual void ReceiveAttack(int damage)
        {
            if (randomNumbers.Next(GameConstants.Instance.DodgeDifficulty) != 0)
            {
                Console.WriteLine(this.Name + " took a serious " + damage + " damage.");
                Health -= damage;
                if (Health < 0) Health = 0;
            }
            else
            {
                Console.WriteLine(this.Name + " evaded the attack with a swift dodge");
            }
        }

        
    }
}
