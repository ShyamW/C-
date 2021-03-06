﻿using Thiagarajan.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiagarajan.RPGCore
{
    
    public class Archer : CharacterBase
    {
      
        public Archer(string name, int health)
        {
            
            this.CharacterClass = "LongBowMan";
            this.attackBehavior = new BadGradeAttack();
            this.Name = name;
            this.Health = health;
        }

        public Archer() : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(), GameConstants.Instance.PlayerHitpoints)
        {
        }

        public Archer(string name) : this(name, GameConstants.Instance.PlayerHitpoints)
        {
        }
        
    }
}
