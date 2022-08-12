using Heroes.Models.Contracts;
using Heroes.Models.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Heroes.Models.Map
{
    public class Map : IMap
    {
        public string Fight(ICollection<IHero> players)
        {
            List<IHero> knights = players.Where(p => p.GetType().Name == "Knight").ToList();
            List<IHero> barbarians = players.Where(p => p.GetType().Name == "Barbarian").ToList();

            while (true)
            {
                foreach (var knight in knights.Where(k => k.IsAlive))
                {
                    foreach (var barb in barbarians.Where(b => b.IsAlive))
                    {
                        barb.TakeDamage(knight.Weapon.DoDamage());
                    }
                }

                foreach (var barb in barbarians.Where(b => b.IsAlive))
                {
                    foreach (var knight in knights.Where(k => k.IsAlive))
                    {
                        knight.TakeDamage(barb.Weapon.DoDamage());
                    }
                }
                if (barbarians.Where(b => b.IsAlive).Count() == 0)
                {
                    return $"The knights took {knights.Where(k => !k.IsAlive).Count()} casualties but won the battle.";
                }
                if (knights.Where(k => k.IsAlive).Count() == 0)
                {
                    return $"The barbarians took {barbarians.Where(b => !b.IsAlive).Count()} casualties but won the battle.";
                }
            }


        }
    }
}
