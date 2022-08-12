using Heroes.Models.Contracts;
using System;
using System.Text;

namespace Heroes.Models.Heroes
{
    public abstract class Hero : IHero
    {
        private string name;
        private int health;
        private int armour;
        private IWeapon weapon;

        protected Hero(string name, int health, int armour)
        {
            this.Name = name;
            this.Health = health;
            this.Armour = armour;
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Hero name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hero health cannot be below 0.");
                }
                this.health = value;
            }
        }

        public int Armour
        {
            get { return this.armour; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hero armour cannot be below 0.");
                }
                this.armour = value;
            }
        }

        public IWeapon Weapon
        {
            get { return this.weapon; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Weapon cannot be null.");
                }
                this.weapon = value;
            }
        }

        public bool IsAlive => this.Health > 0;

        public void AddWeapon(IWeapon weapon)
        {
            if (this.Weapon == null)
            {
                this.Weapon = weapon;
            }
            else
            {
                throw new InvalidOperationException($"Hero { this.Name } is well-armed.");
            }
        }

        public void TakeDamage(int points)
        {
            if (points > this.Armour + this.Health)
            {
                this.Armour = 0;
                this.Health = 0;
            }
            else if (points > this.Armour)
            {
                this.Health -= points - this.Armour;
                this.Armour = 0;
            }
            else
            {
                this.Armour -= points;
            }
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}: {this.Name}");
            sb.AppendLine($"--Health: {this.Health}");
            sb.AppendLine($"--Armour: {this.Armour}");
            string wpn = this.Weapon != null ? this.Weapon.Name : "Unarmed";
            sb.AppendLine($"--Weapon: {wpn}");
            return sb.ToString().Trim();
        }
    }
}
