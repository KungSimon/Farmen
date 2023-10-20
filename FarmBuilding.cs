using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    internal class FarmBuilding : Entity
    {
        List<Animal> AnimalInBuilding { get; set; }
        public int Capacity { get; set; }

        public FarmBuilding(string name, int capacity /*, List <Animal> animalInBuilding*/)
            :base(name)
        {
            Capacity = capacity;
            AnimalInBuilding = new List<Animal>();  
        }

        
        public override string GetDescription()
        {
            if (Name.Length <= 6)
            {
                Console.WriteLine("Id" + Id + "\t" + Name + "\t\t\t" + Capacity);
            }
            else if (Name.Length > 6 || Name.Length <= 12)
            {
                Console.WriteLine("Id" + Id + "\t" + Name + "\t\t" + Capacity);
            }
            else
            {
                Console.WriteLine("Id" + Id + "\t" + Name + "\t" + Capacity);
            }

            return null;
        }

        public void ListAnimalInBuilding()
        {
            foreach ( Animal animal in AnimalInBuilding)
            {
                animal.GetDescription();

            }
            IsFull();
            IsEmpty();
        }

        public bool IsFull ()
        {
            if (AnimalInBuilding.Count >= Capacity)
            {
                Console.WriteLine("Building is full");
                return true;
            }
            else 
            { 
                return false; 
            }
        }
        public bool IsEmpty()
        {
            if (AnimalInBuilding.Count == 0)
            {
                Console.WriteLine("Building is empty");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddAnimalInBuilding(Animal animalToAdd)
        {
            if (AnimalInBuilding.Count < Capacity)
            {
                AnimalInBuilding.Add(animalToAdd);
            }
            else
            {
                Console.WriteLine($"Building {Name} is full");
            }
            
        }
        public void RemoveAnimalInBuilding(int id)
        {
            
            for (int i = 0; i < AnimalInBuilding.Count; i++)
            {
                if (AnimalInBuilding[i].Id == id)
                {
                    AnimalInBuilding.Remove(AnimalInBuilding[i]);
                }
            }
        }
        public void GetDescription1()
        {
            if (Name.Length <= 6)
            {
                Console.WriteLine("Id" + Id + "\t" + Name + "\t\t\t" + AnimalInBuilding);
            }
            else if (Name.Length > 6 || Name.Length <= 12)
            {
                Console.WriteLine("Id" + Id + "\t" + Name + "\t\t" + AnimalInBuilding);
            }
            else
            {
                Console.WriteLine("Id" + Id + "\t" + Name + "\t" + AnimalInBuilding);
            }
        }
    }
}
