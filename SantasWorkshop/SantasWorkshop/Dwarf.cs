using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasWorkshop
{
    internal class Dwarf
    {
        private ToyFactory factory;
        private Storage storage;

        public Dwarf(ToyFactory factory, Storage storage)
        {
            this.factory = factory;
            this.storage = storage;
        }


        public void OnCommandWritten(object source, CommandEventArgs args)
        {
            GetToy(args.Command);
        }

        public void GetToy(Command command)
        {
            var toyKind = command.Content;

            var toy = this.factory.CreateToy(toyKind);

            storage.CreatedToys.Add(toy);
        }
    }
}
