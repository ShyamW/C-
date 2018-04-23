using Thiagarajan.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Thiagarajan.RPGCore;

namespace WPFBattle
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            ICharacter robert = new zMage("Robert", Riku);
            ICharacter nick = new zWarrior("Nick", Vexen);
            ICharacter bob = new zComputerWizard("Bob", Xenmas);
            ICharacter alice = new Archer("Alice", Flare);
            // Team lists
            IList<ICharacter> jocks = new List<ICharacter>();
            IList<ICharacter> nerds = new List<ICharacter>();
            jocks.Add(robert);
            jocks.Add(nick);
            nerds.Add(bob);
            nerds.Add(alice);
            // Set up combat logic
            
            StreamWriter output = new StreamWriter(console);
            Console.SetOut(output);
            Combat battle = new Combat(jocks, nerds, "Jocks", "Nerds");
            CombatThread combatThread = new CombatThread(battle);
            combatThread.Start();


        }
    }
}
