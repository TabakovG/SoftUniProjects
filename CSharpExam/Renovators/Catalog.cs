﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        public List<Renovator> renovators { get;private set; }

        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public int Count { get=>this.renovators.Count;}

        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            this.renovators = new List<Renovator>();
        }

        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information.";
            }
            if (this.Count == this.NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }

            this.renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";

        }
        public bool RemoveRenovator(string name)
        {
            return this.renovators.Remove(this.renovators.FirstOrDefault(r => r.Name == name));
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            return this.renovators.RemoveAll(r => r.Type == type);
        }
        public Renovator HireRenovator(string name)
        { 
            var hire = this.renovators.FirstOrDefault(r => r.Name == name);
            if (hire != null)
            {
                hire.Hired = true;
            }
            return hire;
        }
        public List<Renovator> PayRenovators(int days)
        { 
            return this.renovators.Where(r => r.Days >= days).ToList();
        }
        public string Report()
        {
            return $"Renovators available for Project {this.Project}:" + Environment.NewLine + 
                $"{string.Join(Environment.NewLine, this.renovators.Where(r=>r.Hired == false))}";
        }

    }
}
