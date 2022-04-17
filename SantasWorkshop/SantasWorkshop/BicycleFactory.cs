using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasWorkshop
{
    internal class BicycleFactory
    {
        public Bicycle Create()
        {
            return new Bicycle();
        }
    }
}
