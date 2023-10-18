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
        
        public WorkerManager()
        {
            Worker worker1 = new Worker("Olle");
            worker1.AddSpecialty("Cow");
            worker1.AddSpecialty("Chicken");
            worker1.AddSpecialty("Tractor");
            worker1.AddSpecialty("Sheep");

            Worker worker2 = new Worker("Pelle");
            worker2.AddSpecialty("Oats");
            worker2.AddSpecialty("Cow");
            worker2.AddSpecialty("Rye");
            worker2.AddSpecialty("Wheat");
            worker2.AddSpecialty("Tractor");

            Worker worker3 = new Worker("Rut");
            worker3.AddSpecialty("Chicken");
            worker3.AddSpecialty("Rye");
            worker3.AddSpecialty("Wheat");
            worker3.AddSpecialty("Tractor"); 

            Worker worker4 = new Worker("Pernilla");
            worker4.AddSpecialty("Cow");
            worker4.AddSpecialty("Sheep");
            worker4.AddSpecialty("Ray");
            worker4.AddSpecialty("Tractor");

            workers.Add(worker1);
            workers.Add(worker2);
            workers.Add(worker3);
            workers.Add(worker4);
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
            Worker worker = new Worker(name);
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
