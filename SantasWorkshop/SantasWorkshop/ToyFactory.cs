using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasWorkshop
{
    internal class ToyFactory
    {
        private BicycleFactory bicycleFactory = new BicycleFactory();
        private DollFactory dollFactory = new DollFactory();
        public Toy CreateToy(string toyKind)
        {
            Toy toy;
            switch (toyKind)
            {
                case "bicycle":
                    toy = this.bicycleFactory.Create();
                    break;
                case "doll":
                    toy = this.dollFactory.Create();
                    break;
                default:
                    throw new NotImplementedException();
            }

            return toy;
        }
        
    }
}
