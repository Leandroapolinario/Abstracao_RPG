namespace Abstracao_RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.Herotype = HeroType;
        }

        public override string Attack()
        {
            return this.Name + "Atacou com uma adaga";

        }
    }
}