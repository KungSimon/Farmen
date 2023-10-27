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

                Console.Write("Id " + Id + "\t" +"Name:" + Name + "\t" + "Specialites: ");
            foreach (string speciality in Specialties)
            {
                Console.Write(" " + speciality);
            }
            Console.WriteLine();
            return Name;
        }

    }

}
