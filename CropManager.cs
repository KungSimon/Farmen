using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    internal class CropManager
    {
       
        List<Crop> crops = new List<Crop>();

        public CropManager()
        {

            Crop crop = new Crop("Wheat", 100, "Food");
            Crop crop1= new Crop("Corn", 80, "Feed");
            Crop crop2= new Crop("Rye", 100, "Food");
            Crop crop3= new Crop("Oat", 100, "Feed");
            Crop crop4= new Crop("Silage", 100, "Feed");

            crops.Add(crop);
            crops.Add(crop1);
            crops.Add(crop2);
            crops.Add(crop3);
            crops.Add(crop4);

        }
        public void CropMenu()
        {
            bool cropMenu = true;
            while (cropMenu)
            {
                Console.WriteLine("");
                Console.WriteLine("Crop Menu");
                Console.WriteLine("1. View Crops");
                Console.WriteLine("2. Add Crop");
                Console.WriteLine("3. Remove Crop");
                Console.WriteLine("9. Quit Menu");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ViewCrops();
                        break;

                    case "2":
                        Worker selectedWorker = ChooseWorker(); 
                        AddCrop(selectedWorker);
                        break;

                   case "3":
                        ViewCrops();
                        Console.WriteLine("Choose an crop to use by ID");
                        int id = int.Parse(Console.ReadLine());
                        RemoveCrop(id);
                        ViewCrops();
                        break;

                    case "9":
                        cropMenu = false;
                        break;
                }
            }
        }

        public void AddCrop(Worker worker)
        {
            foreach (Crop crop in crops)
            {
                crop.GetDescription();
            }
            Console.WriteLine("choose a crop to harvest by Id ");
            int id = int.Parse( Console.ReadLine());

            for (int i = 0;i < crops.Count;i++)
            {
                if (crops[i].Id == id)
                {
                    crops[i].AddCrop(crops[i].Id);
                }
            }
        }

        private void RemoveCrop(int id)
        {
            for (int i = 0; i < crops.Count; i++)
            {
                if (crops[i].Id == id)
                {
                    crops.Remove(crops[i]);
                }
            }
        }

        private void ViewCrops()
        {
            Console.WriteLine("List of Crops:");
            foreach (Crop crop in crops)
            {
                crop.GetDescription();
            }
        }
        public List<Crop> GetCrops()
        {
            return crops;
        }
        public Worker ChooseWorker() //Skapas för att minska kod i menyn och för att återanvändas i andra klasser.
        {
            WorkerManager workerManager = new WorkerManager();
            List<Worker> workers = workerManager.GetWorkers();
            foreach (Worker worker in workers)
            {
                worker.GetDescription();
            }
            bool WorkerExist = false;
            while (!WorkerExist)
            {
                try
                {
                    Console.WriteLine("Which worker do you whant to assign choose by Id");
                    int idWorker = int.Parse(Console.ReadLine());


                    for (int i = 0; i < workers.Count; i++)
                    {
                        if (workers[i].Id == idWorker)
                        {
                            return workers[i];
                            WorkerExist = true;
                        }
                    }
                    Console.WriteLine("Invalid worker, please try again");
                }
                catch
                {
                    Console.WriteLine("Please choose a worker by Id.");
                }
            }
            return null;
            
        }
    }

}
