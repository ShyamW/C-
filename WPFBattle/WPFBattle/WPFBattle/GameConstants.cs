using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiagarajan.RPGCore
{
   public class GameConstants
    {
        private GameConstants()
        {

        }
        public int DamageBonus { get { return damageBonus; } }
        public int DamageRange { get { return damageRange; } }

        private static GameConstants instance = new GameConstants();
        public static GameConstants Instance
        {
            get
            {
                return instance;
            }
        }
        public int PlayerHitpoints = 50;
 
        private const int dodgeDifficulty = 2;
        private const int damageBonus = 2;
        private const int damageRange = 12;
        public int DodgeDifficulty
        {
            get
            {
                return dodgeDifficulty;
            }
        }

        
    }
}
