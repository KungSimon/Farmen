using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    internal class WorkerManager
    {


        List<Worker> workers = new List<Worker>();
        List<string> specialitetsList = new List<string>();
        public WorkerManager()
        {
            workers.Add(new Worker("Olle", specialitetsList));
            workers.Add(new Worker("Pelle", specialitetsList));
            workers.Add(new Worker("Rut", specialitetsList));
            workers.Add(new Worker("Pernilla", specialitetsList));
        }

        public void WorkerMeny()
        {
            bool workerMenu = true;
            while (workerMenu)
            {
                Console.WriteLine();
                Console.WriteLine("Worker Meny");
                Console.WriteLine("1. View Workers");
                Console.WriteLine("2. Add Worker");
                Console.WriteLine("3. Remove Worker");
                Console.WriteLine("9. Quit Menu");
                string input = Console.ReadLine();


                switch (input)
                {
                    case "1":
                        ViewWorkers();
                        break;
                        ;
                    case "2":
                        AddWorker();
                        break;

                    case "3":
                        RemoveWorker();
                        break;

                    case "9":
                        workerMenu = false;
                        break;

                }
            }


        }

        private void RemoveWorker()
        {
            Console.WriteLine("Choose a worker by Id");
            ViewWorkers();
            try
            {
                int id = int.Parse(Console.ReadLine());

                for (int i = 0; i < workers.Count; i++)
                {
                    if (workers[i].Id == id)
                    {
                        workers.Remove(workers[i]);
                    }
                }
            }
            catch
            {
                Console.WriteLine("No such worker");
            }
        }

        private void AddWorker()
        {
            Console.WriteLine();
            Console.WriteLine("Give the worker an Id No.");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the workers name");
            string name = Console.ReadLine();

            Addspeciality();
            bool AddSpec = true;
            while (AddSpec)
            {
                Console.WriteLine("Do you want to add speciality, Y or N?");
                string input = Console.ReadLine();
                if (input == "Y")
                {
                    Console.WriteLine("Add a speciality.");
                    string speciality = Console.ReadLine();
                    Worker worker = new Worker(name, specialitetsList);
                    worker.Specialities.Add(speciality);
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
            workers.Add(new Worker(name, specialitetsList));





            Console.WriteLine($"You've added {name} to the list of workers");



        }

        private void Addspeciality()
        {

        }

        private void ViewWorkers()
        {
            Console.WriteLine();
            foreach (Worker worker in workers)
            {

                worker.GetDescription();
            }

        }
        public void GetWorkers()
        {
            ViewWorkers();
        }
    }
}
