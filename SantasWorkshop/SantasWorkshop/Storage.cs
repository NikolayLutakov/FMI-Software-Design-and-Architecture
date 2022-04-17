using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasWorkshop
{
    internal class Storage
    {
        public Storage()
        {
            this.CreatedToys = new List<Toy>();
        }
        public List<Toy> CreatedToys { get; set; }
    }
}
