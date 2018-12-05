using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Harbivore
    {
        public delegate void HarbivoreHandler(string mes);
        public event HarbivoreHandler EatPlant;

        public string Kind { set; get; }
        public bool Eat {get; private set;}

        public Harbivore(string kind)
        {
            Eat = false;
            Kind = kind;
        }

        public void Eating(string Plant)
        {
            Eat = true;
            if (EatPlant != null)
                EatPlant($"{Plant} has been eaten by {Kind}");
        }
    }
}
