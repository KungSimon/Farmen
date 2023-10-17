using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    internal class Farm
    {
        AnimalManager AnimalManager = new AnimalManager();
        WorkerManager WorkerManager = new WorkerManager();
        BuildingManager BuildingManager = new BuildingManager();
        public Farm() { }

        public void MainMenu()
        {
            bool mainMenu = true;
            while (mainMenu)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Animals");
                Console.WriteLine("2. Workers");
                Console.WriteLine("3. Buildings");
                Console.WriteLine("4. Crops");
                Console.WriteLine("9. Quit The Farm");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AnimalManager.AnimalMenu();
                        break;

                    case "2":
                        WorkerManager.WorkerMeny();
                        break;
                    case "3":
                        BuildingManager.BuildingMenu();
                        break;
                    case "4":
                        //CropManager.CropMenu();
                        break;

                    case "9":
                        mainMenu = false;
                        break;
                }
            }
        }

    }
}
