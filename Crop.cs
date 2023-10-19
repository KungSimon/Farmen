using System;
using System.Collections.Generic;
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
                Console.WriteLine(Id + "\t" + Name + "\t\t\t" + Quantity + "\t" + CropType);
            }
            else if (Name.Length > 6 || Name.Length <= 12)
            {
                Console.WriteLine(Id + "\t" + Name + "\t\t" + Quantity + "\t" + CropType);
            }
            else
            {
                Console.WriteLine(Id + "\t" + Name + "\t" + Quantity + "\t" + CropType);
            }

            return null;
        }
        public void AddCrop()
        {
            Console.WriteLine("Enter the name of the crop: ");
            string Newname = Console.ReadLine();

            Console.WriteLine("Enter the quantity of the crop: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("What type of crop is it?");
            string type = Console.ReadLine();

            bool existingCropFound = false;

            for (int i = 0; i < crops.Count; i++)
            {
                if (Newname == crops[i].Name && type == crops[i].CropType)
                {
                    crops[i].Quantity += quantity;
                    Console.WriteLine($"Added {quantity} units of {type} {Newname}. Total quantity: {crops[i].Quantity}");
                    existingCropFound = true;
                    break;
                }
            }
            if (!existingCropFound)
            {
                crops.Add(new Crop(Newname, quantity, type));
                Console.WriteLine($"Added {quantity} units of {type} {Newname} ");
            }
        }
    }
}
