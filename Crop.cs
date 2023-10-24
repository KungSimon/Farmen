using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    internal class Crop : Entity
    {
        List<Crop> crops = new List<Crop>();
        public int Quantity { get; set; }
        public string CropType { get; set; }
        public Crop(string name, int quantity, string cropType)
            :base (name)
        {
            Quantity = quantity;
            CropType = cropType;
        }

        public override string GetDescription()
        {

            if (Name.Length <= 6)
            {
                Console.WriteLine("Id" + Id + "\t" + Name + "\t\t\t" + Quantity + "\t" + CropType);
            }
            else if (Name.Length > 6 || Name.Length <= 12)
            {
                Console.WriteLine("Id" + Id + "\t" + Name + "\t\t" + Quantity + "\t" + CropType);
            }
            else
            {
                Console.WriteLine("Id" + Id + "\t" + Name + "\t" + Quantity + "\t" + CropType);
            }

            return null;
        }
        public void AddCrop(int Id)
        {
            bool existingCropFound = true;

            for (int i = 0; i < crops.Count; i++)
            {
                if (Id == crops[i].Id)
                {
                    Console.WriteLine("Enter the quantity of the crop: ");
                    int Newquantity = int.Parse(Console.ReadLine());
                    crops[i].Quantity = + Newquantity;

                    Console.WriteLine($" The new quantity of {crops[i].Name} is {crops[i].Quantity} ");

                    existingCropFound = true;
                    break;
                }
            }
            if (!existingCropFound)
            {
                Console.WriteLine("Enter the name of the crop: ");
                string Newname = Console.ReadLine();

                Console.WriteLine("Enter the quantity of the crop: ");
                int quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("What type of crop is it?");
                string type = Console.ReadLine();

                crops.Add(new Crop(Newname, quantity, type));
                Console.WriteLine($"Added {quantity} units of {type} {Newname} ");
            }
        }


        public bool TakeCrop (int Id)
        {
            
            for (int i = 0;i<crops.Count; i++)
            {
                if (Id == crops[i].Id)
                {
                   int quantity = ChekQuantity();
                   crops[i].Quantity = -quantity;
                   Console.WriteLine($"Now you have {crops[i].Quantity} left");
                   

                }
            }

            return true;

        }
        public int ChekQuantity() //Skapade denna funktion för att inte fåp för många måsvingar så att koden blir mer överskådlig
        {

            for (int i = 0; i < crops.Count; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"How much {crops[i].Name} do you whant to use");
                        int quantity = int.Parse(Console.ReadLine());

                        if (crops[i].Quantity - quantity !< 0)
                        {
                            return quantity;
                            break;
                        }
                        else if (quantity == 0)
                        {
                            return quantity;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Not enough Crops ");
                            Console.WriteLine("0 will cancel the request");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Please use numbers");
                    }
                }
            }
            return 0;
        }
    }
}
