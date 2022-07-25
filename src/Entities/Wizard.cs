namespace Abstracao_RPG.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.Herotype = HeroType;
        }

        public override string Attack()
        {
            return this.Name + "Lançou Magia!";

        }
    }
}