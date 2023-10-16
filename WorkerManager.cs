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
        
        List<Worker> workers=new List<Worker>();
        public WorkerManager() 
        {
            workers.Add(new Worker(1, "Olle"));
            workers.Add(new Worker(2, "Pelle"));
            workers.Add(new Worker(3, "Rut"));
            workers.Add(new Worker(4, "Pernilla"));
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
                Console.WriteLine("4. Get Workers");
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

                    case "4":
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
            string name= Console.ReadLine();
            Console.WriteLine("What is the workers speciality");
            string speciality= Console.ReadLine();

            workers.Add(new Worker(id, name, speciality));

            Console.WriteLine($"You've added {name} to the list of workers" );

        }

        private void ViewWorkers()
        {
            Console.WriteLine();
            foreach (Worker worker in workers)
            {
                
                worker.GetDescription();
            }
           
        }
    }
}
