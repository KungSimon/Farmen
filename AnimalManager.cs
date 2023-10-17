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
            animals.Add(new Animal("Olle", "Pig"));
            animals.Add(new Animal("Pelle", "Cow"));
            animals.Add(new Animal("Rut", "Chicken"));
            animals.Add(new Animal("Pernilla", "Sheep"));
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
                        AddAnimal();
                        break;

                    case "3":
                        RemoveAnimal();
                        break;

                    case "4":
                        //SwitchBuilding()
                        break;

                    case "9":
                        animalMenu = false;
                        break;

                }
            }


        }

        private void AddAnimal()
        {
            Console.WriteLine();
            Console.WriteLine("Give the animal an Id No.");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the animals name");
            string name = Console.ReadLine();
            Console.WriteLine("What species is the animal");
            string species = Console.ReadLine();

            animals.Add(new Animal(name, species));
        }

        private void ViewAnimals()
        {
            Console.WriteLine();
            foreach (Animal animals in animals)
            {

                animals.GetDescription();
            }

        }
        private void RemoveAnimal()
        {
            Console.WriteLine("Choose a animal by Id");
            ViewAnimals();
            try
            {
                int id = int.Parse(Console.ReadLine());

                for (int i = 0; i < animals.Count; i++)
                {
                    if (animals[i].Id == id)
                    {
                        animals.Remove(animals[i]);
                    }
                }
            }
            catch
            {
                Console.WriteLine("No such animal");
            }
        }
        public void GetAnimals()
        {
            ViewAnimals();
        }
    }
}
