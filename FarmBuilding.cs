using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    internal class FarmBuilding : Entity
    {
        List<Animal> animalsInBuilding { get; set; }
        public int Capacity { get; set; }

        public FarmBuilding(string name, int capacity /*, List <Animal> animalsInBuilding*/)
            :base(name)
        {
            Capacity = capacity;
            animalsInBuilding = new List<Animal>();  
        }

        
        public override string GetDescription()
        {
            if (Name.Length <= 6)
            {
                Console.WriteLine("Id" + Id + "\t" + Name + "\t\t\t" + Capacity);
                foreach (Animal animal in animalsInBuilding)
                {
                    Console.Write(" " + animal);
                }

            }
           //else if (Name.Length > 6 || Name.Length <= 12)
           //{
           //    Console.WriteLine("Id" + Id + "\t" + Name + "\t\t" + Capacity + " " + animalsInBuilding);
           //}
           //else
           //{
           //    Console.WriteLine("Id" + Id + "\t" + Name + "\t" + Capacity + " " +  animalsInBuilding);
           //}

            return null;
        }

        public void ListAnimalInBuilding()
        {
            foreach ( Animal animal in animalsInBuilding)
            {
                animal.GetDescription();

            }
            IsFull();
            IsEmpty();
        }

        public bool IsFull ()
        {
            if (animalsInBuilding.Count >= Capacity)
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
            if (animalsInBuilding.Count == 0)
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
            AnimalManager animalManager = new AnimalManager();
            List <Animal> animals = animalManager.GetAnimals();
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i] == animalToAdd)
                {
                    animalsInBuilding.Add(animals[i]);
                }
            }
        }
        public void RemoveAnimalInBuilding(int id)
        {
            BuildingManager buildingManager = new BuildingManager();
            List <Animal> animals = animalsInBuilding;
            for (int i = 0; i < animalsInBuilding.Count; i++)
            {
                if (animalsInBuilding[i].Id == id)
                {
                    animalsInBuilding.Remove(animalsInBuilding[i]);
                }
            }
        }
        public void GetDescription1()
        {
            if (Name.Length <= 6)
            {
                Console.WriteLine("Id" + Id + "\t" + Name + "\t\t\t" + animalsInBuilding);
            }
            else if (Name.Length > 6 || Name.Length <= 12)
            {
                Console.WriteLine("Id" + Id + "\t" + Name + "\t\t" + animalsInBuilding);
            }
            else
            {
                Console.WriteLine("Id" + Id + "\t" + Name + "\t" + animalsInBuilding);
            }
        }
    }
}
