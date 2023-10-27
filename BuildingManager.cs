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
 
        List<FarmBuilding> farmBuildings = new List<FarmBuilding>();

        //Animal animal = new Animal("");
        
        public BuildingManager()
        {
            List<Animal> animals = animalManager.GetAnimals();
            FarmBuilding farmBuilding1 = new FarmBuilding("Barn1", 20);
            FarmBuilding farmBuilding2 = new FarmBuilding("Barn2", 80);
            FarmBuilding farmBuilding3 = new FarmBuilding("Barn3", 5);
            FarmBuilding farmBuilding4 = new FarmBuilding("Barn4", 10);
            FarmBuilding farmBuilding5 = new FarmBuilding("Barn5", 20);
            FarmBuilding farmBuilding6 = new FarmBuilding("Barn6", 30);
            farmBuildings.Add(farmBuilding1);
            farmBuildings.Add(farmBuilding2);
            farmBuildings.Add(farmBuilding3);
            farmBuildings.Add(farmBuilding4);
            farmBuildings.Add(farmBuilding5);
            farmBuildings.Add(farmBuilding6);
            


            farmBuilding1.AddAnimalInBuilding(animals[0]);
            farmBuilding1.AddAnimalInBuilding(animals[1]);
            farmBuilding1.AddAnimalInBuilding(animals[2]);
            farmBuilding1.AddAnimalInBuilding(animals[3]);
            farmBuilding1.AddAnimalInBuilding(animals[4]);
            farmBuilding1.AddAnimalInBuilding(animals[5]);
            farmBuilding2.AddAnimalInBuilding(animals[6]);
            farmBuilding2.AddAnimalInBuilding(animals[7]);
            farmBuilding2.AddAnimalInBuilding(animals[8]);
            farmBuilding2.AddAnimalInBuilding(animals[9]);
            farmBuilding2.AddAnimalInBuilding(animals[10]);
            farmBuilding3.AddAnimalInBuilding(animals[11]);
            farmBuilding3.AddAnimalInBuilding(animals[12]);
            farmBuilding3.AddAnimalInBuilding(animals[13]);
            farmBuilding3.AddAnimalInBuilding(animals[14]);
            farmBuilding3.AddAnimalInBuilding(animals[15]);
            farmBuilding4.AddAnimalInBuilding(animals[16]);
            farmBuilding4.AddAnimalInBuilding(animals[17]);
            farmBuilding4.AddAnimalInBuilding(animals[18]);
            farmBuilding4.AddAnimalInBuilding(animals[19]);
            farmBuilding4.AddAnimalInBuilding(animals[20]);
            farmBuilding4.AddAnimalInBuilding(animals[21]);
            

        }
        
        public void BuildingMenu()
        {
            bool BuildingMenu = true;
            while (BuildingMenu)
            {
                List<Animal> animals = animalManager.GetAnimals();
                Console.WriteLine("Antal djur i animals-listan: " + animals.Count);
                foreach (var animal in animals)
                {
                    Console.WriteLine("Djur: " + animal.Id);
                }

                Console.WriteLine("Farm Buildings menu.");
                Console.WriteLine("1. View buildings");
                Console.WriteLine("2. Add building");
                Console.WriteLine("3. Remove building");
                Console.WriteLine("4. List animals in building");
                Console.WriteLine("5. Remove animal from building");
                Console.WriteLine("9. Quit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                    
                        if (farmBuildings.Any())
                        {
                            ViewBuildings();
                        }
                        else
                        {
                            Console.WriteLine("There are no buildings to view.");
                        }
                        break;

                        // Console.WriteLine("Number of farmbuildings: " + farmBuildings.Count);

                        //  ViewBuildings();
                       // break;

                    case "2":
                        AddBuilding();
                        break;

                    case "3":
                        RemoveBuilding();
                        break;
                    
                    case "4":
                        foreach (FarmBuilding farmBuilding in farmBuildings)
                        {
                            farmBuilding.GetDescription();
                        }
                        break;
                    case "5":
                        //AddAnimals();
                        break;

                    /*case "5":
                       foreach (Animal animal in animalsInBuilding)
                        {
                            animal.GetDescription();
                        }
                        FarmBuilding selectedFarmBuilding = null;
                        Console.WriteLine("Choose an Animal to Remove by Id");
                        int id = int.Parse(Console.ReadLine());
                        for (int i = 0; i < animalsInBuilding.Count; i++)
                        {
                            if (animalsInBuilding[i].Id == id)
                            {
                                selectedFarmBuilding.RemoveAnimalInBuilding(id);
                            }
                        }
                        break;*/


                    case "9":
                        BuildingMenu = false;
                        break;
                }
            }

        }

        private void RemoveBuilding()
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
            
            Console.WriteLine("List of buildings:");
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
        /*public void AddAnimals()
        {

            List<Animal> animals = animalManager.GetAnimals();
            farmBuildings[1].AddAnimalInBuilding(animals[0]);
            farmBuildings[1].AddAnimalInBuilding(animals[1]);
            farmBuildings[1].AddAnimalInBuilding(animals[2]);
            farmBuildings[1].AddAnimalInBuilding(animals[3]);
            farmBuildings[1].AddAnimalInBuilding(animals[4]);
            farmBuildings[1].AddAnimalInBuilding(animals[5]);
            farmBuildings[2].AddAnimalInBuilding(animals[6]);
            farmBuildings[2].AddAnimalInBuilding(animals[7]);
            farmBuildings[2].AddAnimalInBuilding(animals[8]);
            farmBuildings[2].AddAnimalInBuilding(animals[9]);
            farmBuildings[2].AddAnimalInBuilding(animals[10]);
            farmBuildings[3].AddAnimalInBuilding(animals[11]);
            farmBuildings[3].AddAnimalInBuilding(animals[12]);
            farmBuildings[3].AddAnimalInBuilding(animals[13]);
            farmBuildings[3].AddAnimalInBuilding(animals[14]);
            farmBuildings[3].AddAnimalInBuilding(animals[15]);
            farmBuildings[4].AddAnimalInBuilding(animals[16]);
            farmBuildings[4].AddAnimalInBuilding(animals[17]);
            farmBuildings[4].AddAnimalInBuilding(animals[18]);
            farmBuildings[4].AddAnimalInBuilding(animals[19]);
            farmBuildings[4].AddAnimalInBuilding(animals[20]);
            farmBuildings[4].AddAnimalInBuilding(animals[21]);

            Console.WriteLine("Antal djur i animals-listan: " + animals.Count);
            foreach (var animal in animals)
            {
                Console.WriteLine("Djur: " + animal.Id);
            }
        }*/

    }
}
