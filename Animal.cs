using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    internal class Animal : Entity
    {
        public string Species { get; set; }

        public Animal (int id, string name, string species )
            :base (id, name)
        {
            Species = species;
        }
        public override string GetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
