namespace BuilderPattern.Models
{
    public class Vampire : Enemy
    {
        public string Ability { get; private set; } = string.Empty;
        public int BloodAmount { get; private set; }

        public class VampireBuilder
        {
            private readonly Vampire _vampire = new Vampire();

            public VampireBuilder Name(string name)
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                _vampire.Name = name;
                return this;
            }

            public VampireBuilder Health(int health)
            {
                if (health <= 0)
                {
                    throw new ArgumentException("Health cannot be zero or negative");
                }
                _vampire.Health = health;
                return this;
            }

            public VampireBuilder Ability(string ability)
            {
                if (string.IsNullOrEmpty(ability))
                {
                    throw new ArgumentException("Ability cannot be null or empty");
                }
                _vampire.Ability = ability;
                return this;
            }

            public VampireBuilder Damage(int damage)
            {
                if (damage <= 0)
                {
                    throw new ArgumentException("Damage cannot be zero or negative");
                }

                _vampire.Damage = damage;
                return this;
            }

            public VampireBuilder BloodAmount(int bloodAmount)
            {
                if (bloodAmount < 0)
                {
                    throw new ArgumentException("Blood amount cannot be negative");
                }

                _vampire.BloodAmount = bloodAmount;
                return this;
            }

            public Vampire Build()
            {
                return _vampire;
            }
        }

        public static VampireBuilder With()
        {
            return new VampireBuilder();
        }
    }
}
