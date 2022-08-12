using Heroes.Models.Contracts;
using Heroes.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Heroes.Repositories
{
    public class HeroRepository : IRepository<IHero>
    {

        private readonly List<IHero> models;

        public HeroRepository()
        {
            this.models = new List<IHero>();
        }

        public IReadOnlyCollection<IHero> Models => this.models.AsReadOnly();

        public void Add(IHero model)
        {
            if (this.models.Any(x=>x.Name == model.Name))
            {
                throw new InvalidOperationException($"The hero {model.Name} already exists.");
            }
            this.models.Add(model);
        }
        public bool Remove(IHero model)
        {
            return this.models.Remove(model);
        }

        public IHero FindByName(string name)
        {
            return this.models.FirstOrDefault(x=>x.Name == name);
        }

    }
}
