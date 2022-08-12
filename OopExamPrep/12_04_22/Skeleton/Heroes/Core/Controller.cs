using Heroes.Core.Contracts;
using Heroes.IO;
using Heroes.Models.Contracts;
using Heroes.Models.Heroes;
using Heroes.Models.Map;
using Heroes.Models.Weapons;
using Heroes.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes.Core
{
    public class Controller : IController
    {
        public Controller()
        {
            this.heroes = new HeroRepository();
            this.weapons = new WeaponRepository();
        }

        private HeroRepository heroes;
        private WeaponRepository weapons;


        public string CreateHero(string type, string name, int health, int armour)
        {
            if (type == "Knight")
            {
                heroes.Add(new Knight(name, health, armour));
                return $"Successfully added Sir { name } to the collection.";
            }
            else if (type == "Barbarian")
            {
                heroes.Add(new Barbarian(name, health, armour));
                return $"Successfully added Barbarian { name } to the collection.";
            }
            else
            {
                throw new InvalidOperationException("Invalid hero type.");
            }
        }

        public string CreateWeapon(string type, string name, int durability)
        {
            if (type == "Claymore")
            {
                weapons.Add(new Claymore(name, durability));
            }
            else if (type == "Mace")
            {
                weapons.Add(new Mace(name, durability));

            }
            else
            {
                throw new InvalidOperationException("Invalid weapon type.");
            }
            return $"A {type.ToLower()} {name} is added to the collection.";
        }
        public string AddWeaponToHero(string weaponName, string heroName)
        {
            var weapon = weapons.FindByName(weaponName);
            var hero = heroes.FindByName(heroName);
            if (hero == null)
            {
                throw new InvalidOperationException($"Hero {heroName} does not exist.");
            }
            else if (weapon == null)
            {
                throw new InvalidOperationException($"Weapon {weaponName} does not exist.");
            }

            hero.AddWeapon(weapon);
            weapons.Remove(weapon);
            return $"Hero {hero.Name} can participate in battle using a { weapon.GetType().Name.ToLower() }.";



        }
        public string StartBattle()
        {
            var map = new Map();
            return map.Fight(
                heroes.Models
                .Where(x=>x.IsAlive && x.Weapon != null)
                .ToArray()
                );
        }

        public string HeroReport()
        {
            var list = this.heroes.Models
                .OrderBy(x => x.GetType().Name)
                .ThenByDescending(x => x.Health)
                .ThenBy(x => x.Name);
            var sb = new StringBuilder();
            foreach (var hero in list)
            {
                sb.AppendLine(hero.ToString());
            }
            return sb.ToString().Trim();
        }

    }
}
