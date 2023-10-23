using System;
using System.Collections.Generic;
using System.Linq;
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

            crops.Add(crop1);
            crops.Add(crop2);
            crops.Add(crop3);
            crops.Add(crop);

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
                        WorkerManager workerManager = new WorkerManager();
                        List<Worker> workers = workerManager.GetWorkers();
                        foreach (Worker worker in workers)
                        {
                            worker.GetDescription();
                        }



                        for (int i = 0; i < workers.Count; i++)
                        {
                            
                        }
                        AddCrop();
                        break;

                    case "3":
                        Console.WriteLine("Choose an crop to use by ID");
                        int id = int.Parse(Console.ReadLine());
                        RemoveCrop(id);
                        break;

                    case "9":
                        cropMenu = false;
                        break;
                }
            }
        }

        private void AddCrop(Worker worker)
        {
            ViewCrops();
            Console.WriteLine("Which crop would you like to harvest?");
            string input = Console.ReadLine();
            if (input = worker.Specialties)
            {

            }
            


        }

        private void RemoveCrop(int id)
        {
            Console.WriteLine("How many of the crops do you want to use?");
            int UsedCrop = int.Parse(Console.ReadLine());
                for (int i = 0; i < crops.Count; i++)
                {
                    if (crops[i].Id == id)
                    {
                        int newQuantity = crops[i].Quantity - UsedCrop;
                        crops[i].Quantity = newQuantity; 
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
    }

}
