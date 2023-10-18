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

        public List<string> Specialties { get; set; }

        public Worker(string name)
        :base(name)
        {
            Specialties = new List<String>();
        }

        public void AddSpecialty(string specialty)
        {
            Specialties.Add(specialty);
        }

        public override string GetDescription()
        {

            if (Name.Length <= 6)
            {
                Console.WriteLine(Id + "\t" + Name + "\t\t\t" + Specialties);
            }
            else if (Name.Length > 6 || Name.Length <= 12)
            {
                Console.WriteLine(Id + "\t" + Name + "\t\t" + Specialties);
            }
            else
            {
                Console.WriteLine(Id + "\t" + Name + "\t" + Specialties);
            }

            return null;
        }

    }

}
