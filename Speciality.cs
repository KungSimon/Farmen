using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    internal class Speciality
    {
        public string Skill { get; set; }
        public string V { get; }

        public Speciality() { }

        public Speciality(string v)
        {
            V = v;
        }
    }
}
