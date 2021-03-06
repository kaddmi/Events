﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Carnivore
    {
        public delegate void CarnivoreHandler(string mes);
        public event CarnivoreHandler EatHerbivore;

        public string Kind { set; get; }
        public bool Eat { get; private set; }

        public Carnivore(string kind)
        {
            Eat = false;
            Kind = kind;
        }

        public void Eating(string Herbivore)
        {
            Eat = true;
            if (EatHerbivore != null)
                EatHerbivore($"{Herbivore} has been eaten by {Kind}");
        }
    }
}
