using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Farmen
{
    internal class Worker : Entity
    {

        public List<string> Specialities { get; set; }

        public Worker(string name, List<string> specialites)
        :base(name)
        {
            Specialities = specialites;
        }

        public override string GetDescription()
        {

            if (Name.Length <= 6)
            {
                Console.WriteLine(Id + "\t" + Name + "\t\t\t" + Specialities);
            }
            else if (Name.Length > 6 || Name.Length <= 12)
            {
                Console.WriteLine(Id + "\t" + Name + "\t\t" + Specialities);
            }
            else
            {
                Console.WriteLine(Id + "\t" + Name + "\t" + Specialities);
            }

            return null;
        }

    }

}
