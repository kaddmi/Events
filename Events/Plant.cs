using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Plant
    {
        public delegate void PlantHandler(string mes);
        public event PlantHandler Grow;

        public string Kind { set; get; }
        public bool Grown { get; private set; }

        public Plant(string kind)
        {
            Grown = false;
            Kind = kind;
        }

        public void Grows()
        {
            if (Grow != null)
                Grow($"{Kind} grows");
        }

        public void HasGrown()
        {
            Grown = true;
            if (Grow != null)
                Grow($"{Kind} has grown");
        }


    }
}
