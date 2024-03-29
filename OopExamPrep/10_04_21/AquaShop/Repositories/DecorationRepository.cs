﻿using AquaShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Repositories
{
    using AquaShop.Models.Decorations.Contracts;
    using Contracts;
    using System.Linq;

    public class DecorationRepository : IRepository<IDecoration>
    {
        private readonly List<IDecoration> models;

        public DecorationRepository()
        {
            this.models = new List<IDecoration>();
        }

        public IReadOnlyCollection<IDecoration> Models => this.models.AsReadOnly();

        public void Add(IDecoration model)
        {
            this.models.Add(model);
        }

        public IDecoration FindByType(string type)
        {
            return this.models.FirstOrDefault(m=>m.GetType().Name == type);
        }

        public bool Remove(IDecoration model)
        {
            return this.models.Remove(model);
        }
    }
}
