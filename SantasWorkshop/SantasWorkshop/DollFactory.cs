using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasWorkshop
{
    internal class DollFactory
    {
        public Doll Create()
        {
            return new Doll();
        }
    }
}
