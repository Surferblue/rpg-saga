namespace Abilities
{
    using Players;
    using Effects;
    public class Bleeding : IAbility
    {
        public int NumberUses { get; set; } = 0;
        private int MaxUses { get; set; } = 1;
        public string AbilityName { get; set; } = "Кровотечение";
        public void Spell(IPlayer myself, IPlayer enemy, int round)
        {
            enemy.MyEffects.Add(new LongDamage(7, round));
            NumberUses++;
        }
        public bool CanSpell()
        {
            if (NumberUses < MaxUses)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

