using Heroes.Models.Contracts;
using Heroes.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes.Repositories
{
    public class WeaponRepository : IRepository<IWeapon>
    {
        private readonly List<IWeapon> models;

        public WeaponRepository()
        {
            this.models = new List<IWeapon>();
        }

        public IReadOnlyCollection<IWeapon> Models => this.models.AsReadOnly();

        public void Add(IWeapon model)
        {
            if (this.Models.Any(x=>x.Name == model.Name))
            {
                throw new InvalidOperationException($"The weapon { model.Name } already exists.");
            }
            this.models.Add(model);
        }
        public bool Remove(IWeapon model)
        {
            return this.models.Remove(model);
        }

        public IWeapon FindByName(string name)
        {
            return this.models.FirstOrDefault(x => x.Name == name);
        }
    }
}
