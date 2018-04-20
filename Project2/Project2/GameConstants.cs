namespace Thiagarajan.RPGCore
{
    public class GameConstants
    {
        private GameConstants()
        {

        }
        private const int dodgeDiff = 5;
        private const int dmgeMultiplier = 8; 
        private const int damageRng = 33; 
        public int DodgeDiff
        {
            get
            {
                return dodgeDiff;
            }
        }

        public int DamageBonus { get { return dmgeMultiplier; } }
        public int DamageRange { get { return damageRng; } }

        private static GameConstants instance = new GameConstants();
        public static GameConstants Instance
        {
            get
            {
                return instance;
            }
        }
        public int PlayerHitpoints = 50;
    }
}
