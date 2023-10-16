using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    internal class Farm
    {
        WorkerManager WorkerManager = new WorkerManager();
        public Farm() { }

        public void MainMenu() 
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Animals");
            Console.WriteLine("2. Workers");
            Console.WriteLine("9. Quit The Farm");

            string input = Console.ReadLine();

            bool mainMenu = true;
            while (mainMenu)
            {
                switch (input)
                {
                    case "1":

                        break;
                        
                    case "2":
                        WorkerManager.WorkerMeny();
                        break;

                    case "9":
                        break;
                }
            }
        }

    }
}
