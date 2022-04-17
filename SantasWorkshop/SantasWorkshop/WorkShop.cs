using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasWorkshop
{
    internal class WorkShop
    {
        public WorkShop(
            MagicDesk desk, 
            List<Dwarf> dwarfs, 
            ToyFactory toyFactory,
            Storage storage)
        {
            this.MagicDesk = desk;
            this.ToyFactory = toyFactory;
            this.Dwarfs = dwarfs;
            this.Storage = storage;
        }

        public MagicDesk MagicDesk { get; }

        public List<Dwarf> Dwarfs { get; }

        public ToyFactory ToyFactory { get; }

        public Storage Storage { get; }

        public void ListToys()
        {
            var bicyclesCount = 0;
            var dollsCount = 0;

            foreach (var toy in Storage.CreatedToys)
            {
                if(toy.ToyKind == "Doll")
                {
                    dollsCount++;
                }
                else
                {
                    bicyclesCount++;
                }
            }

            Console.WriteLine($"Toys count: {Storage.CreatedToys.Count}");
            Console.WriteLine($"Dolls count: {dollsCount}");
            Console.WriteLine($"Bicycles count: {bicyclesCount}");
        }

    }
}
