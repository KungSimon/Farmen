using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    internal class BuildingManager
    {
        AnimalManager animalManager = new AnimalManager();
        FarmBuilding farmBuilding = new FarmBuilding("Barn7", 20);
        List<FarmBuilding> farmBuildings = new List<FarmBuilding>();
        List<Animal> animals = new List<Animal>();
        Animal animal = new Animal("");
        
        public BuildingManager()
        {
            FarmBuilding farmBuilding1 = new FarmBuilding("Barn1", 20);
            FarmBuilding farmBuilding2 = new FarmBuilding("Barn2", 80);
            FarmBuilding farmBuilding3 = new FarmBuilding("Barn3", 30);
            FarmBuilding farmBuilding4 = new FarmBuilding("Barn4", 5);
            FarmBuilding farmBuilding5 = new FarmBuilding("Barn5", 50);
            FarmBuilding farmBuilding6 = new FarmBuilding("Barn6", 10);
            farmBuildings.Add(farmBuilding);
        }
        
        public void BuildingMenu()
        {
            bool BuildingMenu = true;
            while (BuildingMenu)
            {
                Console.WriteLine("Farm Buildings menu.");
                Console.WriteLine("1. View buildings");
                Console.WriteLine("2. Add building");
                Console.WriteLine("3. Remove building");
                Console.WriteLine("4. List Animals in building");
                Console.WriteLine("5. remove animal form building");
                Console.WriteLine("9. Quit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ViewBuildings();
                        break;

                    case "2":
                        AddBuilding();
                        break;

                    case "3":
                        ReamoveBuilding();
                        break;
                    
                    case "4":
                        farmBuilding.ListAnimalInBuilding();
                        break;
    
                    case "5":
                       
                        Console.WriteLine("Choose an Animal to Remove by Id");
                        int id = int.Parse(Console.ReadLine());

                        farmBuilding.RemoveAnimalInBuilding(id);
                        break;


                    case "9":
                        break;
                }
            }

        }

        private void ReamoveBuilding()
        {
            Console.WriteLine("Choose an building by Id");
            ViewBuildings();
            try
            {
                int id = int.Parse(Console.ReadLine());

                for (int i = 0; i < farmBuildings.Count; i++)
                {
                    if (farmBuildings[i].Id == id)
                    {
                        farmBuildings.Remove(farmBuildings[i]);
                    }
                }
            }
            catch
            {
                Console.WriteLine("No such building");
            }
        }

        private void AddBuilding()
        {
            Console.WriteLine("Whats the buildings name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is the capacity?");
            int capacity = int.Parse(Console.ReadLine());
            farmBuildings.Add(new FarmBuilding(name, capacity));
            Console.WriteLine($"You have now added {name} to your farm");
        }

        private void ViewBuildings()
        {
            foreach (FarmBuilding farmBuilding in farmBuildings)
            {
                farmBuilding.GetDescription();
            }
        }
        public List<FarmBuilding> GetFarmBuilding()
        {
            return farmBuildings;

        }
        public void AddAnimal1()
        {
            List<Animal> animals = animalManager.GetAnimals();
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

    }
}
