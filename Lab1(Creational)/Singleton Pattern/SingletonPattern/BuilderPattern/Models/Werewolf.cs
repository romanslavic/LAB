namespace BuilderPattern.Models
{
    public class Werewolf : Enemy
    {
        public string Weapon { get; private set; } = string.Empty;
        public int TransformationTime { get; private set; }

        public static WerewolfBuilder With()
        {
            return new WerewolfBuilder();
        }

        public class WerewolfBuilder
        {
            private readonly Werewolf _werewolf = new Werewolf();

            public WerewolfBuilder Name(string name)
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                _werewolf.Name = name;
                return this;
            }

            public WerewolfBuilder Health(int health)
            {
                if (health <= 0)
                {
                    throw new ArgumentException("Health cannot be zero or negative");
                }
                _werewolf.Health = health;
                return this;
            }

            public WerewolfBuilder Damage(int damage)
            {
                if (damage <= 0)
                {
                    throw new ArgumentException("Damage cannot be zero or negative");
                }
                _werewolf.Damage = damage;
                return this;
            }

            public WerewolfBuilder Weapon(string weapon)
            {
                if (string.IsNullOrEmpty(weapon))
                {
                    throw new ArgumentException("Weapon cannot be null or empty");
                }
                _werewolf.Weapon = weapon;
                return this;
            }

            public WerewolfBuilder TransformationTime(int transformationTime)
            {
                if (transformationTime < 0)
                {
                    throw new ArgumentException("TransformationTime cannot be negative");
                }
                _werewolf.TransformationTime = transformationTime;
                return this;
            }

            public Werewolf Build()
            {
                return _werewolf;
            }
        }
    }
}
