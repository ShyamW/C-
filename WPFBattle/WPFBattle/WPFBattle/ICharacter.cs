using Thiagarajan.RPGCore;

namespace Thiagarajan.RoleplayingGameInterfaces
{
    public interface ICharacter
    {
        CharacterImage Image { get; }
        string CharacterClass { get; }
        string Name { get; }
        int Health { get; }
        void PerformAttack(ICharacter target);
        void ReceiveAttack(int damage);
    }
}
