using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Context
{
    public interface IPlayer
    {
        void SetWeapon(IWeapon newWeapon);
        int Attack();
        int Play();
    }
}