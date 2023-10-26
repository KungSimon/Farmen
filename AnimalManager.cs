using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    //test
    internal class AnimalManager
    {

        
        List<Animal> animals = new List<Animal>();
        public AnimalManager()
        {
            Animal animal1 = new Animal("Olle", "Pig");
            animal1.AddCropType("Corn");
            animal1.AddCropType("Rye");
            animal1.AddCropType("Oats");
            animal1.AddCropType("Wheat");
            Animal animal2 = new Animal("Olle", "Pig");
            animal2.AddCropType("Corn");
            animal2.AddCropType("Rye");
            animal2.AddCropType("Oats");
            animal2.AddCropType("Wheat");
            Animal animal3 = new Animal("Olle", "Pig");
            Animal animal4 = new Animal("Olle", "Pig");
            Animal animal5 = new Animal("Olle", "Pig");
            Animal animal6 = new Animal("Olle", "Pig");
            Animal animal7 = new Animal("Pelle", "Cow");
            Animal animal8 = new Animal("Pelle", "Cow");
            Animal animal9 = new Animal("Pelle", "Cow");
            Animal animal10 = new Animal("Pelle", "Cow");
            Animal animal11 = new Animal("Pelle", "Cow");
            Animal animal12 = new Animal("Rut", "Chicken");
            Animal animal13 = new Animal("Rut", "Chicken");
            Animal animal14 = new Animal("Rut", "Chicken");
            Animal animal15 = new Animal("Rut", "Chicken");
            Animal animal16 = new Animal("Rut", "Chicken");
            Animal animal17 = new Animal("Pernilla", "Sheep");
            Animal animal18 = new Animal("Pernilla", "Sheep");
            Animal animal19 = new Animal("Pernilla", "Sheep");
            Animal animal20 = new Animal("Pernilla", "Sheep");
            Animal animal21 = new Animal("Pernilla", "Sheep");
            Animal animal22 = new Animal("Pernilla", "Sheep");

            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
            animals.Add(animal6);
            animals.Add(animal7);
            animals.Add(animal8);
            animals.Add(animal9);
            animals.Add(animal10);
            animals.Add(animal11);
            animals.Add(animal12);
            animals.Add(animal13);
            animals.Add(animal14);
            animals.Add(animal15);
            animals.Add(animal16);
            animals.Add(animal17);
            animals.Add(animal18);
            animals.Add(animal19);
            animals.Add(animal20);
            animals.Add(animal21);
            animals.Add(animal22);
            
        }
        public void AnimalMenu()
        {
            
            bool animalMenu = true;
            while (animalMenu)
            {
                Console.WriteLine();
                Console.WriteLine("Animal Meny");
                Console.WriteLine("1. View Animals");
                Console.WriteLine("2. Add Animal");
                Console.WriteLine("3. Remove Animal");
                Console.WriteLine("4. Switch Building");
                Console.WriteLine("5. Feed Animals");
                Console.WriteLine("9. Quit Menu");
                string input = Console.ReadLine();


                switch (input)
                {
                    case "1":
                        ViewAnimals();
                        break;
                        ;
                    case "2":
                        BuildingManager buildingManager = new BuildingManager();
                        List<FarmBuilding> farmBuildings = buildingManager.GetFarmBuilding();
                        int animalCount = 0;
                        foreach (FarmBuilding farmBuilding in farmBuildings)
                        {
                            farmBuilding.ListAnimalInBuilding();
                            animalCount++;
                        }
                        Console.WriteLine("Choose a farm building by Id.");
                        int building = int.Parse(Console.ReadLine());
                        for (int i = 0; i < farmBuildings.Count; i++)
                        {
                            if (building == farmBuildings[i].Id)
                            {
                                if (animalCount < farmBuildings[i].Capacity)
                                {
                                    AddAnimal(farmBuildings[i]);
                                }
                                else
                                {
                                    Console.WriteLine($"{farmBuildings[i]} is full. Choose another building.");
                                }

                            }
                            
                        }
                        break;

                    case "3":
                        Console.WriteLine("Choose an animal to remove by Id");
                        int id = int.Parse(Console.ReadLine());
                        RemoveAnimal(id);
                        break;

                    case "4":
                        //SwitchBuilding()
                        break;

                    case "5":
                        //FeedAnimal();
                        break;

                    case "9":
                        animalMenu = false;
                        break;

                }
            }


        }

        private bool AddAnimal(FarmBuilding farmBuilding)
        {
            BuildingManager buildingManager = new BuildingManager();
            List<FarmBuilding> farmBuildings = buildingManager.GetFarmBuilding();
            Console.WriteLine();
            Console.WriteLine("What is the animals name");
            string name = Console.ReadLine();
            Console.WriteLine("What species is the animal");
            string species = Console.ReadLine();
            /*Console.WriteLine("What does the animal eat?");
            bool AddSpec = true;
            while (AddSpec)
            {
                Console.WriteLine("What does the animal eat?");
                string input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine("Add a speciality.");
                    string speciality = Console.ReadLine();

                    worker.Specialties.Add(speciality);
                }
                else if (input == "N")
                {
                    AddSpec = false;
                }
                else if (input != "Y" || input != "N")
                {
                    Console.WriteLine("Invalid Input. You need to choose Y or N");
                }

            }
            workers.Add(worker);
            string acceptableCropTypes = Console.ReadLine();*/
            Animal animalToAdd = new Animal(name, species);
            //AddAnimal();
            return true;
        }

        private void ViewAnimals()
        {
            Console.WriteLine();
            foreach (Animal animals in animals)
            {

                animals.GetDescription();
            }

        }
        private void RemoveAnimal(int id)
        {
                for (int i = 0; i < animals.Count; i++)
                {
                    if (animals[i].Id == id)
                    {
                    Console.WriteLine($"Animal {animals[i].Id} succesfully removed.");
                    animals.Remove(animals[i]);
                    }
                }

        }
        public List<Animal> GetAnimals()
        {
            return animals;
        }
    }
}
