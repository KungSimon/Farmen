using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    internal class BuildingManager
    {
        List<FarmBuilding> farmBuildings = new List<FarmBuilding>();
        public BuildingManager()
        {
            farmBuildings.Add(new FarmBuilding("Barn1", 20));
        }
        public void BuildingMenu()
        {
            bool BuildingMenu = true;
            while (BuildingMenu)
            {
                Console.WriteLine("Building menu.");
                Console.WriteLine("1. View buildings");
                Console.WriteLine("2. Add building");
                Console.WriteLine("3. Remove building");
                Console.WriteLine("4. Add animals");
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
                        //FarmBuilding.AddAnimalInBuilding(true);

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
        public void GetFarmBuilding()
        {
            ViewBuildings();

        }
    }
}
