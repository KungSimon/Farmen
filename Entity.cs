using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    internal abstract class Entity
    {
        public int Id { get; set; } 
        protected string Name { get; set; }


        public Entity(int id, string name)
        {
            Id = id;
            Name = name;

        }
        public abstract string GetDescription();
    }
   
}
