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

        public Animal(string name, string species)
            :base(name)
        {
            Species = species;
        }
        public override string GetDescription()
        {

            if (Name.Length <= 6)
            {
                Console.WriteLine(Id + "\t" + Name + "\t\t\t" + Species);
            }
            else if (Name.Length > 6 || Name.Length <= 12)
            {
                Console.WriteLine(Id + "\t" + Name + "\t\t" + Species);
            }
            else
            {
                Console.WriteLine(Id + "\t" + Name + "\t" + Species);
            }

            return null;
        }
    }
}
}
