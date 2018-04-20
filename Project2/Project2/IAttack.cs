using Thiagarajan.RPGCore;
namespace Thiagarajan.RoleplayingGameInterfaces
{
    public interface IAttack
    {
        void Attack(ICharacter attacker, ICharacter target);
    }
}