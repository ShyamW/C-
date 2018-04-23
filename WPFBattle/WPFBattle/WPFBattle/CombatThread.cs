using Thiagarajan.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPFBattle
{
    class CombatThread
    {
      private Thread thread;
        private ICombat encounter;
    
        public CombatThread(ICombat yay)
        {
            this.encounter = yay;
        }
        public void Start()
         {
             thread = new System.Threading.Thread(() =>
              {
            encounter.AutoBattle();
                });
         thread.Name = "GameThread";
         thread.Start();
         }

        public void Deactivate()
         {
         thread.Abort();
         }
    }
}
